using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using OfficeOpenXml;
using System.Linq;
using OfficeOpenXml.Style;
using System.Drawing;
using Microsoft.AspNetCore.Mvc;

namespace com.study.core.utility
{
    public interface IToExcel
    {
        MemoryStream convertToExcel<T>(List<T> subscribers);
    }
    public class ToExcelWithOfficeOpenXml : IToExcel
    {
        public string DefaultSheetName { get; set; } = "Result";
        public string DataPosition { get; set; } = "A2";
        public bool DrawingHeaderBoarder { get; set; } = true;

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
                    using (ExcelRange rng = ws.Cells["A1:BZ1"])
                    {
                        rng.Style.Font.Bold = true;
                        rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                        rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));  //Set color to dark blue
                        rng.Style.Font.Color.SetColor(Color.White);
                    }
                }
                package.Save();
            }
            return stream;
        }

    }
}
