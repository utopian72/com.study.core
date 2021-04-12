using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Compression;
using System.IO;

namespace com.study.core.utility.io.compression
{
    public  class ZipArchiveFolder
    {

        public static string  ExtractToDirectory(string zipPath, string extractPath)
        {
            if (File.Exists(zipPath))
            {
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }

            if(Directory.Exists(extractPath))
            {
                return extractPath;
            }
            return "";
        }

        public static string CreateFromDirectory(string startPath, string zipPath)
        {
            if (Directory.Exists(startPath))
            {
                ZipFile.CreateFromDirectory(startPath, zipPath);
                string resultfile =  System.IO.Path.Combine(startPath , zipPath);

                if(File.Exists(resultfile))
                {
                    return resultfile;
                }
            }
            return "";
        }
    }
}
