using com.study.core.web.filter;
using com.study.core.web.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace com.study.core.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
         

            _logger = logger;
        }

        public IActionResult Login(string username, string password)
        {
            HttpContext.Session.SetString("UserId", "utopian");
            return RedirectToAction("Index", "TblSurveys");
        }
        public IActionResult Index()
        {
            HttpContext.Session.SetString("UserId", "");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var features = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = features.Error; // Your exception

            //session error 체크
            
            if (exception is ApiSessionTimeoutException)
            {

                JsonReturnModel returnModel = new JsonReturnModel();
                returnModel.IsSession = false;
                returnModel.IsSuccess = false;
                returnModel.Msg = exception.Message;

                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All, UnicodeRanges.All),
                    WriteIndented = true
                };
                return Ok(returnModel);
                //string jsonstring = JsonSerializer.Serialize<JsonReturnModel>(returnModel, options);
                //HttpContext.Response.ContentType = "application/json;charset=UTF-8";
                ////context.HttpContext.Response.ContentType = "application/json";
                //HttpContext.Response.WriteAsync(jsonstring);
            }
            else
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier, Message = exception.Message });
            }


            //if (exception is SessionTimeoutException)
            //{
            //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier, Message = exception.Message });
            //}

            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier, Message= exception.Message);

        }
    }
}
