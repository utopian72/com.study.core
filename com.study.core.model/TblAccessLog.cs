using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblAccessLog
    {
        public int SurveyNo { get; set; }
        public int ListNo { get; set; }
        public int SendNo { get; set; }
        public int AccessNo { get; set; }
        public string EncryKey { get; set; }
        public DateTime? AcDate { get; set; }
    }
}
