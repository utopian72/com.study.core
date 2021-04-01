using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblQuestionAttribute
    {
        public int SurveyNo { get; set; }
        public string QtCode { get; set; }
        public string AttrName { get; set; }
        public string AttrValue { get; set; }

        public virtual TblQuestion TblQuestion { get; set; }
    }
}
