using com.study.core.model;
using System;
using System.Linq;

namespace com.study.core.service
{
    public class LoginService
    {
        private mobileSurveyContext _context;
        public LoginService(mobileSurveyContext context)
        {
            _context = context;
        }

        public bool Login(string id, string password)
        {
            try
            {
                var user = _context.TblUsers.Where(u => u.MemId.Equals(id)).FirstOrDefault();

                if (user.Pwd.Equals(password))
                    return true;
                else
                    return false;
            }catch
            {
                return false;
            }
        }
    }
}
