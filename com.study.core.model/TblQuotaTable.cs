using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblQuotaTable
    {
        public int SurveyNo { get; set; }
        public int QuotaNo { get; set; }
        public int QuotaCode { get; set; }
        public string CellName { get; set; }
        public int? Target { get; set; }
        public int? Sample { get; set; }
        public int? Sms { get; set; }
        public int? Surveying { get; set; }
        public int? Completed { get; set; }
        public bool WithoutBl { get; set; }
    }
}
