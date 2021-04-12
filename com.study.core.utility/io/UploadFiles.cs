using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.study.core.utility.io
{
   
    public interface IUploadFiles
    {
        List<IUploadFileResult> Upload(IFormFile file, string parentsfolder = "", string childfolder = "");
    }

    public class UploadFiles: IUploadFiles
    {
        private string _rootPath = "";
        
        private int _count =0;
        public UploadFiles(string rootPath)
        {
            _rootPath = rootPath;
        }

        public string RootPath { get { return _rootPath; } }



        public List<IUploadFileResult> Upload(IFormFile file, string parentsfolder = "", string childfolder = "")
        {
            if (file == null) return null;

            List<IFormFile> files = new List<IFormFile>();
            files.Add(file);
            return Upload(files , parentsfolder, childfolder);
        }


        public List<IUploadFileResult> Upload( List<IFormFile> files , string parentsfolder="", string childfolder="")
        {

            List<IUploadFileResult> results = new List<IUploadFileResult>();

            files.ForEach(file => {

                
                string filePath = getFilePath(file , parentsfolder , childfolder);

                filePath = rename(file, filePath);

                CopyTo(file, filePath);

                results.Add(new UploadFileResult(Path.GetFullPath(filePath) ,  file.FileName ));

                _count++;

            });

            return results;
        }

        private string getFilePath(IFormFile file ,  string parentsfolder, string childfolder)
        {
            string filePath = "";
            if (!string.IsNullOrWhiteSpace(parentsfolder) && string.IsNullOrWhiteSpace(childfolder))
                filePath = System.IO.Path.Combine(_rootPath, parentsfolder, file.FileName);
            else if (!string.IsNullOrWhiteSpace(parentsfolder) && !string.IsNullOrWhiteSpace(childfolder))
                filePath = System.IO.Path.Combine(_rootPath, parentsfolder, childfolder, file.FileName);
            else if (string.IsNullOrWhiteSpace(parentsfolder) && string.IsNullOrWhiteSpace(childfolder))
                filePath = "";

            return filePath;
        }


        private void CopyTo(IFormFile file  , string filePath)
        {

            using (var uploadFile = System.IO.File.Create(filePath))
            {
                file.CopyTo(uploadFile);
            }
        }
        private string rename(IFormFile file ,   string filePath)
        {
            var k = 1;
            while (System.IO.File.Exists(filePath))
            {
                var name = file.FileName.Substring(0, file.FileName.LastIndexOf("."));
                var ext = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);
                filePath = System.IO.Path.Combine(_rootPath, $"{name} ({k++}).{ext}");
            }

            return filePath;
        }

    }

    
}
