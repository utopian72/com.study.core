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

namespace NiceReport.Web.Utility
{
    //단위 테스트 완료
    public interface IExcelToDataTable
    {
        DataTable convertTo(string filePath , int sheetindex = 0);
    }

    public class ExcelToDataTableWithOLE: IExcelToDataTable
    {
        private const string oleConStringFormat = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";

        

        public DataTable convertTo(string filePath , int sheetindex  = 0)
        {
            try
            {
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
                            string sheetName = dtExcelSchema.Rows[sheetindex]["TABLE_NAME"].ToString();
                            dt.TableName = sheetName;
                            connExcel.Close();

                            //Read Data from First Sheet.
                            connExcel.Open();
                            cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                            odaExcel.SelectCommand = cmdExcel;
                            odaExcel.Fill(dt);
                            connExcel.Close();
                        }

                    }
                    return dt;
                }
            }catch(Exception ex)
            {
                return null;
            }
        }

        public List<DataTable> convertAllTo(string filePath)
        {
            try
            {
                List<DataTable> dts = new List<DataTable>();

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
                            connExcel.Close();


                            for (int count = 0; count < dtExcelSchema.Rows.Count; count++)
                            {
                                try
                                {
                                    DataTable dt = new DataTable();
                                    int rowindex = count;
                                    string sheetName = dtExcelSchema.Rows[rowindex]["TABLE_NAME"].ToString();
                                    //connExcel.Close();

                                    //Read Data from index Sheet.
                                    connExcel.Open();
                                    cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                                    odaExcel.SelectCommand = cmdExcel;
                                    odaExcel.Fill(dt);
                                    connExcel.Close();

                                    dt.TableName = sheetName.Substring(0 , sheetName.Length-1) ;

                                    dts.Add(dt);
                                }
                                catch
                                {
                                    
                                }
                            }
                            connExcel.Close();
                        }
                    }
                }
                //table이 없으면 0를 리턴한다.
                return dts.Count > 0 ? dts : null;
            }catch
            {
                return null;
            }
        }
    }
}
