using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using com.study.core.utility.io;

namespace com.study.core.web.Controllers.Api
{
    public class FileController : Controller
    {

        private IWebHostEnvironment _environment;
        private ILogger<FileController> _logger;
        public FileController( IWebHostEnvironment environment , ILogger<FileController> logger)
        {
            _environment = environment;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult UploadFile()
        {
            var file = new RegisterFile();
            file.SecondName = "";
            file.ResumeFileName = "";
            return View(file);
        }


        public IActionResult UploadFiles(List<IFormFile> files)
        {
            var uploadPath = _environment.WebRootPath;
            var subfolder = "upload";
            
            List<IUploadFileResult> results = null;
            try
            {
                var uploadFiles = new UploadFiles(uploadPath);
                results = uploadFiles.Upload(files, subfolder);
            }
            catch(Exception ex)
            {
                return  Json(ex.Message);
            }
            return Json(results);
        }

        public IActionResult UploadFile(IFormFile file)
        {
            var uploadPath = _environment.WebRootPath;
            var subfolder = "upload";
            var response = "";
            
            try
            {
                var uploadFiles = new UploadFiles(uploadPath);
                var results = uploadFiles.Upload(file, subfolder);
                response = $"{results.Count} files are uploaded.";
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }

            return Json(response);
        }

    }

}
