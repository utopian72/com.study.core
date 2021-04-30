using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using com.study.core.utility.io.compression;
using System.Linq;
using System.Data;
using com.study.core.model;
using Microsoft.EntityFrameworkCore;

namespace com.study.core.utility.test
{
    class toDataTableTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToDataTableTest()
        {
            string sourcefile = @"i:\toexceltest.xlsx";
            var exelto = new ExcelToDataTableWithOLE();
            var dt = exelto.convertTo(sourcefile);

            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count >=1);

        }

        [Test]
        public void toExecTest()
        {
            //string connectionstring = "Data Source=172.29.181.161;Initial Catalog=mobileSurvey;User ID=sa;Password=skdltmfltjcl";


            //DbContextOptions<mobileSurveyContext> options = new DbContextOptions<mobileSurveyContext>();
            //options.UseSqlServer(connectionstring);

            var context = new com.study.core.model.mobileSurveyContext( );
            var surveys =  context.TblSurvey.ToList();

            var totable = new ToExcelWithOfficeOpenXml();
            Assert.IsNotNull(surveys);
            var stream =   totable.convertToExcel<TblSurvey>(surveys);
            Assert.IsNotNull(stream);

            string sourcefile = @"i:\toexceltest1.xlsx";

            System.IO.File.WriteAllBytes(sourcefile , stream.ToArray());


            Assert.IsTrue(System.IO.File.Exists(sourcefile));
        }

    }
}
