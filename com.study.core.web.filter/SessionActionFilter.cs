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

    public class SessionActionFilter : TypeFilterAttribute
    {
        public SessionActionFilter() : base(typeof(SessionActionFilterImpl))
        {
        }

        private class SessionActionFilterImpl : IActionFilter
        {
            private readonly ILogger _logger;

            public SessionActionFilterImpl(ILoggerFactory loggerFactory)
            {
                _logger = loggerFactory.CreateLogger<SessionActionFilter>();
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {
                string session = context.HttpContext.Session.GetString("UserId");


                if (string.IsNullOrWhiteSpace(session))
                {
                    throw new SessionTimeoutException();
                }
            }

            public void OnActionExecuted(ActionExecutedContext context)
            {
                _logger.LogInformation("OnActionExecuted:Business Action completed.");
            }
        }
    }

}
