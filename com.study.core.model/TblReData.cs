using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblReData
    {
        public int SurveyNo { get; set; }
        public int ListNo { get; set; }
        public string QtCode { get; set; }
        public string OpCode { get; set; }
        public int QhNo { get; set; }
        public string Value { get; set; }
        public DateTime? Regdate { get; set; }
        public string Text { get; set; }

        public virtual TblList TblList { get; set; }
        public virtual TblOption TblOption { get; set; }
        public virtual TblQuestionHistory TblQuestionHistory { get; set; }
    }
}
