using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblRefusalLog
    {
        public int SurveyNo { get; set; }
        public int ListNo { get; set; }
        public int RefNo { get; set; }
        public string ClickPoint { get; set; }
        public DateTime? Regdate { get; set; }
    }
}
