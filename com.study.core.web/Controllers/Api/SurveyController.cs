using com.study.core.model;
using com.study.core.web.filter;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.study.core.web.Controllers.Api
{
    
    public class SurveyController : Controller
    {
        private readonly mobileSurveyContext _context;
        public SurveyController(mobileSurveyContext context)
        {
            _context = context;
        }

        //[ApiSessionActionFilter]
        public List<TblSurvey> List(int? id)
        {
            return _context.TblSurvey.Where(a=> a.SurveyNo.Equals(id)).ToList();
        }

        public List<TblSurvey> All()
        {
            return _context.TblSurvey.ToList();
        }

    }
}
