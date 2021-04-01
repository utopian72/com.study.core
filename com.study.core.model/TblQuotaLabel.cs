using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblQuotaLabel
    {
        public TblQuotaLabel()
        {
            TblListQuota = new HashSet<TblListQuota>();
        }

        public int SurveyNo { get; set; }
        public int QuotaNo { get; set; }
        public string QuotaAlias { get; set; }
        public string QuotaLabel { get; set; }

        public virtual TblSurvey SurveyNoNavigation { get; set; }
        public virtual ICollection<TblListQuota> TblListQuota { get; set; }
    }
}
