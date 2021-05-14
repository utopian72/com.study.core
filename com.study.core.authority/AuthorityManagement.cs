using System;

namespace com.study.core.authority
{
    public class AuthorityManagement
    {
        private IUser _user;
        public AuthorityManagement(IUser user)
        {
            _user = user;
        }

        
    }
}
