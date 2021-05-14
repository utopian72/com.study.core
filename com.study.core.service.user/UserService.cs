using com.study.core.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace com.study.core.service.user
{
    public class UserService
    {
        private daoUser _daoUser = null;
        private mobileSurveyContext _context;

        public UserService()
        {
            
        }
        
        public UserService(mobileSurveyContext context)
        {
            _context = context;

            _daoUser = new daoUser(context);
        }

        public void UpdatePassword(TblUser user)
        {
            throw new NotImplementedException();
        }

        public void UpdateColumnEcrypt(TblUser user , string column , string value)
        {
            throw new NotImplementedException();
        }


    }
}
