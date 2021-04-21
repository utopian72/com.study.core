using System;
using System.Collections.Generic;
using System.Text;

namespace NiceReport.Web.Utility.io
{
    public interface IUploadFileResult
    {
         string FilePath { get; set; }
         string FileName { get; set; }
    }

    public class UploadFileResult:IUploadFileResult
    {
        public UploadFileResult(string filePath ,  string filename)
        {
            FilePath = filePath;
            FileName = filename;
        }

        public string FilePath { get; set; }
        public string FileName { get; set; }
        

    }
}
