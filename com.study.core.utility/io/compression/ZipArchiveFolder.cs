using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Compression;
using System.IO;

namespace NiceReport.Web.Utility.io.compression
{
    //단위 테스트 완료
    public  class ZipArchiveFolder
    {

        public static string  ExtractToDirectory(string zipPath, string extractPath)
        {
            if (File.Exists(zipPath))
            {
                //폴더가 없으면 생성한다.
                if (!Directory.Exists(extractPath))
                    Directory.CreateDirectory(extractPath);

                ZipFile.ExtractToDirectory(zipPath, extractPath,true);
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
                if(File.Exists(zipPath))
                {
                    File.Delete(zipPath);
                }

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
