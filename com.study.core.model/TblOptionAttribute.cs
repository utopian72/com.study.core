using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblOptionAttribute
    {
        public int SurveyNo { get; set; }
        public string QtCode { get; set; }
        public string OpCode { get; set; }
        public string AttrName { get; set; }
        public string AttrValue { get; set; }

        public virtual TblOption TblOption { get; set; }
    }
}
