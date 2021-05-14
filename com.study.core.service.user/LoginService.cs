using com.study.core.model;
using System;
using System.Linq;

namespace com.study.core.service.user
{
    public class LoginService
    {
        private daoUser _daoUser = null;
        private mobileSurveyContext _context;
        public LoginService(mobileSurveyContext context)
        {
            _context = context;
            _daoUser = new daoUser(context);
        }

        public bool Login(string id, string password)
        {
            try
            {
                var user = _daoUser.GetUser(id, password);

                if (user == null)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
