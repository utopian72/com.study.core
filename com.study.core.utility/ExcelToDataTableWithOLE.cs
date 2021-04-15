using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace com.study.core.utility
{

    public interface IExcelToDataTable
    {
        DataTable convertTo(string filePath);
    }

    public class ExcelToDataTableWithOLE : IExcelToDataTable
    {
        private const string oleConStringFormat = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";

        public int TargetSheetIndex { get; set; } = 0;

        public DataTable convertTo(string filePath)
        {
            try
            {
                if (!System.IO.File.Exists(filePath)) throw new Exception("파일이 존재한지 않습니다.");

                string extension = System.IO.Path.GetExtension(filePath);

                if (!extension.Contains("xls") && !extension.Contains("xlsx")) throw new Exception("지원하지 않는 파일입니다.(xls,xlsx)");

                DataTable dt = new DataTable();
                string conString = string.Format(oleConStringFormat, filePath);

                using (OleDbConnection connExcel = new OleDbConnection(conString))
                {
                    using (OleDbCommand cmdExcel = new OleDbCommand())
                    {
                        using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                        {
                            cmdExcel.Connection = connExcel;

                            //Get the name of First Sheet.
                            connExcel.Open();
                            DataTable dtExcelSchema;
                            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                            string sheetName = dtExcelSchema.Rows[TargetSheetIndex]["TABLE_NAME"].ToString();
                            connExcel.Close();

                            //Read Data from First Sheet.
                            connExcel.Open();
                            cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                            odaExcel.SelectCommand = cmdExcel;
                            odaExcel.Fill(dt);
                            connExcel.Close();
                            return dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return null;
            }

        }
    }
}
