using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblQuestionLog
    {
        public int SurveyNo { get; set; }
        public int ListNo { get; set; }
        public string QtCode { get; set; }
        public int QlNo { get; set; }
        public bool? InBl { get; set; }
        public DateTime? Regdate { get; set; }
    }
}
