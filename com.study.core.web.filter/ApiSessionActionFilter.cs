using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace com.study.core.web.filter
{

    public class JsonReturnModel
    {
        public bool IsSuccess { get; set; } = true;
        public bool IsSession { get; set; } = true;
        public string Msg { get; set; }
    }
    public class ApiSessionActionFilter : TypeFilterAttribute
    {
        public ApiSessionActionFilter() : base(typeof(ApiSessionActionFilterImpl))
        {
        }

        private class ApiSessionActionFilterImpl : IActionFilter
        {
            private readonly ILogger _logger;

            public ApiSessionActionFilterImpl(ILoggerFactory loggerFactory)
            {
                _logger = loggerFactory.CreateLogger<ApiSessionActionFilter>();
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {
                string session = context.HttpContext.Session.GetString("UserId");


                if (string.IsNullOrWhiteSpace(session))
                {
                    JsonReturnModel returnModel = new JsonReturnModel();
                    returnModel.IsSession = false;
                    returnModel.IsSuccess = false;
                    returnModel.Msg = "사용자 섹션 오류가 발생하였습니다.";

                    var options = new JsonSerializerOptions
                    {
                        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All, UnicodeRanges.All),
                        WriteIndented = true
                    };

                    string jsonstring = JsonSerializer.Serialize<JsonReturnModel>(returnModel, options);
                    context.HttpContext.Response.ContentType = "application/json;charset=UTF-8";
                    //context.HttpContext.Response.ContentType = "application/json";
                    context.HttpContext.Response.WriteAsync(jsonstring);
                }
            }

            public void OnActionExecuted(ActionExecutedContext context)
            {
                _logger.LogInformation("OnActionExecuted:Business Action completed.");
            }
        }
    }

}
