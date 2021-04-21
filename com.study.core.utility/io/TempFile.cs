using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NiceReport.Web.Utility.io
{
    public class TempFile
    {
        public string RootPath { get; set; }

        public TempFile(string rootpath)
        {
            RootPath = rootpath;
        }

        public string createTempFile(string filepullpath)
        {
            if(!File.Exists(filepullpath))
            {
                return "";
            }

            string extention = System.IO.Path.GetExtension(filepullpath);
            
            if (string.IsNullOrWhiteSpace(extention)) return "";

            string newfilename = getTempFile(extention);
            try
            {
                if (File.Exists(newfilename))
                {
                    File.Delete(newfilename);
                }

                File.Copy(filepullpath, newfilename, true);
            }catch
            {
                return "";
            }
            return newfilename;
        }

        private string getTempFile(string extention)
        {
            string newfilename = $"{Guid.NewGuid()}{extention}";

            return Path.Combine(RootPath, newfilename);
        }
    }
}
