using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Compression;
using System.IO;

//단위 테스트 완료
namespace NiceReport.Web.Utility.io.compression
{
    public class ZipArchiveFiles
    {
        private ZipFilePath _zipFilePath = null;
        private List<ZipFilePath> _files = null;
        public ZipFilePath FilePath { get { return _zipFilePath; } }

        public List<ZipFilePath> Files { get { return _files; } }


        public ZipArchiveFiles(ZipFilePath target)
        {
            _zipFilePath = target;
            _files = new List<ZipFilePath>();
        }


        public void AddFilesInFolder(string folder)
        {
            if (Directory.Exists(folder))
            {
                string[] files = Directory.GetFiles(folder);

                if (!files.Length.Equals(0))
                {
                    foreach (string file in files)
                    {
                        _files.Add(new ZipFilePath(folder, Path.GetFileName(file)));
                    }
                }
            }
        }
        public void Add(List<ZipFilePath> files)
        {
            _files.AddRange(files.ToArray());
        }

        public void Add(ZipFilePath file)
        {
            _files.Add(file);
        }

        public string CreateFile()
        {
            string targetpath = System.IO.Path.Combine(_zipFilePath.FilePath, _zipFilePath.FileName);
            var stream = CreateSream();
            System.IO.File.WriteAllBytes(targetpath, stream.ToArray());
            return targetpath;
        }

        public MemoryStream CreateSream()
        {

            string zippath = System.IO.Path.Combine(_zipFilePath.FilePath, _zipFilePath.FileName);
            using (var memoryStream = new MemoryStream())
            {
                using (var ziparchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    foreach (var file in _files)
                    {
                        string targetfile = System.IO.Path.Combine(file.FilePath, file.FileName);
                        ziparchive.CreateEntryFromFile(targetfile, file.FileName);
                    }
                }
                return memoryStream;
            }
        }
    }
}
