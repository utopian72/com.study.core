using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using OfficeOpenXml;
using System.Linq;
using OfficeOpenXml.Style;
using System.Drawing;
using Microsoft.AspNetCore.Mvc;
//사용예
/*
        public IActionResult DownLoad(string query)
        {
            var toexcel = new com.study.core.utility.ToExcelWithOfficeOpenXml();
            var lists = getSurveys(query);

            MemoryStream stream = toexcel.convertToExcel<TblSurvey>(lists.ToList());

            string fileName = "data.xlsx";
            string fileType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            stream.Position = 0;

            return File(stream, fileType, fileName);

        }

 */
namespace NiceReport.Web.Utility
{
    //단위 테스트 완료
    public interface IToExcel
    {
        MemoryStream convertToExcel<T>(List<T> subscribers);
        MemoryStream convertToExcel(DataTable dt);
        FileStreamResult download(DataTable dt, string filename);
        FileStreamResult download<T>(List<T> lists, string filename);
    }
    public class ToExcelWithOfficeOpenXml : IToExcel
    {
        public string DefaultSheetName { get; set; } = "Result";
        public string DataPosition { get; set; } = "A2";
        public string HeaderPosition { get; set; } = "A1";
        public bool DrawingHeaderBoarder { get; set; } = true;


        public FileStreamResult download(DataTable dt ,string filename)
        {
            MemoryStream ms = convertToExcel(dt);
            return createFileStreamResult(dt , filename);
        }

        public FileStreamResult download<T>(List<T> lists, string filename)
        { 
            MemoryStream ms = convertToExcel(lists);
            return createFileStreamResult(lists, filename);
        }


        public MemoryStream convertToExcel(DataTable dt)
        {
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add(dt.TableName);
                ws.Cells[HeaderPosition].LoadFromDataTable(dt, true);

                if (DrawingHeaderBoarder)
                {
                    drawBorder(ws);
                }

                var ms = new System.IO.MemoryStream();
                pck.SaveAs(ms);
                return ms;
            }
        }

        public MemoryStream convertToExcel <T>(List<T> subscribers )
        {
            var stream = new System.IO.MemoryStream();
            using (ExcelPackage package = new ExcelPackage(stream))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add(DefaultSheetName);

                var t = typeof(T);
                var Headings = t.GetProperties();
                for (int i = 0; i < Headings.Count(); i++)
                {
                    ws.Cells[1, i + 1].Value = Headings[i].Name;
                }

                if (subscribers.Count() > 0)
                {
                    ws.Cells[DataPosition].LoadFromCollection(subscribers);
                }

                if (DrawingHeaderBoarder)
                {
                    drawBorder(ws);
                }
                package.Save();
            }
            return stream;
        }
        private void drawBorder(ExcelWorksheet ws)
        {
            using (ExcelRange rng = ws.Cells["A1:BZ1"])
            {
                rng.Style.Font.Bold = true;
                rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));  //Set color to dark blue
                rng.Style.Font.Color.SetColor(Color.White);
            }
        }

        private FileStreamResult createFileStreamResult<T>(List<T> lists  , string tofilename)
        {
            var toexcel = new ToExcelWithOfficeOpenXml();
            MemoryStream stream = toexcel.convertToExcel<T>(lists.ToList());
            return createFileStreamForExcel(stream, tofilename);
        }

        private FileStreamResult createFileStreamResult(DataTable dt , string tofilename)
        {
            var toexcel = new ToExcelWithOfficeOpenXml();
            MemoryStream stream = toexcel.convertToExcel(dt);
            
            return createFileStreamForExcel(stream, tofilename);
        }


        private FileStreamResult createFileStreamForExcel(MemoryStream stream , string tofilename)
        {
            string fileType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            stream.Position = 0;
            var file = new FileStreamResult(stream, fileType);
            file.FileDownloadName = tofilename;
            return file;

        }
    }
}
