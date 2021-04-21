using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace com.study.core.utility.io.compression
{
    public class ZipFilePath: IUploadFileResult
    {

        public ZipFilePath()
        {

        }

        public  ZipFilePath(string filepath , string filename)
        {
            FilePath = filepath;
            FileName = filename;
        }
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public string FullPath { get { return System.IO.Path.Combine(FilePath, FileName);  } }
    }
}
