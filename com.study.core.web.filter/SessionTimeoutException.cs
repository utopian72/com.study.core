using System;
using System.Collections.Generic;
using System.Text;

namespace com.study.core.web.filter
{
    public class SessionTimeoutException:Exception
    {
        public SessionTimeoutException():base("섹션이 만료되었습니다. 다시 로그인해주세요.")
        {

        }


    }

    public class ApiSessionTimeoutException : Exception
    {
        public ApiSessionTimeoutException() : base("섹션이 만료되었습니다. 다시 로그인해주세요.")
        {

        }


    }
}
