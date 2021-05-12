using com.study.core.model;
using System;

namespace com.study.core.service
{
    public class LoginService
    {
        private mobileSurveyContext _context;
        public LoginService(mobileSurveyContext context)
        {
            _context = context;
        }

        public bool Login(string id , string password)
        {
            
        }
    }
}
