using NUnit.Framework;
using com.study.core.utility.io.compression;
using System.Linq;

namespace com.study.core.utility.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateTest()
        {
            string filePath = @"F:\ziptest";
            string fileName = "tes.zip";

            var zipfilepath = new ZipFilePath() { FilePath= filePath, FileName= fileName };
            var zip = new com.study.core.utility.io.compression.ZipArchiveFiles(zipfilepath);

            zip.AddFilesInFolder(@"F:\강의\대용량아키텍처설계\대용량아키텍처설계");
            zip.CreateFile();

            string zipfile = System.IO.Path.Combine(zipfilepath.FilePath, zipfilepath.FileName);
            Assert.IsTrue(System.IO.File.Exists(zipfile));
        }

        [Test]
        public void CreateFolderTest()
        {
            string sourcepath = @"F:\강의\대용량아키텍처설계\대용량아키텍처설계";
            string filePath = @"F:\ziptest";
            string fileName = "foldertest.zip";

            var zipfilepath = new ZipFilePath() { FilePath = filePath, FileName = fileName };
            //var zip = new com.study.core.utility.io.compression.ZipArchiveFolder();
            
            var targetfile = System.IO.Path.Combine(zipfilepath.FilePath, zipfilepath.FileName);

            string createfile = com.study.core.utility.io.compression.ZipArchiveFolder.CreateFromDirectory(  sourcepath , targetfile);

            
            Assert.IsTrue(System.IO.File.Exists(createfile));


        }

        [Test]
        public void ExtractFolderTest()
        {
          
            string filePath = @"F:\ziptest";
            string fileName = "foldertest.zip";

            var zipfilepath = new ZipFilePath() { FilePath = filePath, FileName = fileName };
            //var zip = new com.study.core.utility.io.compression.ZipArchiveFolder();

            var sourcepath = System.IO.Path.Combine(filePath, fileName);
            string tatgetfolder = System.IO.Path.Combine(filePath, System.IO.Path.GetFileNameWithoutExtension(fileName));
            com.study.core.utility.io.compression.ZipArchiveFolder.ExtractToDirectory( sourcepath, tatgetfolder);

            string[] files = System.IO.Directory.GetFiles(tatgetfolder);
            var notzipfiles =  files.Where(file =>System.IO.Path.GetExtension(file) != "zip");


            Assert.IsTrue(notzipfiles.ToList().Count > 0);
        }


    }
}