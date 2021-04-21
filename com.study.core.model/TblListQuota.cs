using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblListQuota
    {
        public int SurveyNo { get; set; }
        public int ListNo { get; set; }
        public int QuotaNo { get; set; }
        public int QuotaCode { get; set; }

        public virtual TblList TblList { get; set; }
        public virtual TblQuotaLabel TblQuotaLabel { get; set; }
    }
}
