using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
