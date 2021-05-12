using System;
using System.Collections.Generic;
using System.Linq;

namespace com.study.core.web.errorcode
{
    public class ErrorCode
    {
        private static List<ErrorCode> _lists = new List<ErrorCode>();

        static ErrorCode()
        {
            _lists.Add(new ErrorCode(404 , "해당 페이지는 폐쇄되어 거나 사용할 수  없는 페이지 입니다.", "해당 페이지는 폐쇄되어 거나 사용할 수  없는 페이지 입니다."));
        }

        public ErrorCode(int code , string label , string description)
        {
            Code = code;
            Label = label;
            Description = description;
        }

        public int Code { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }

        public static ErrorCode GetError(int code)
        {
            try
            {
                return _lists.Where(c => c.Code.Equals(code)).FirstOrDefault();
            }catch
            {
                return null;
            }
        }
    }
}
