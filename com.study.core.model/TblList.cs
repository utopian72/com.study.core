using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblList
    {
        public TblList()
        {
            TblListQuota = new HashSet<TblListQuota>();
            TblQuestionHistory = new HashSet<TblQuestionHistory>();
            TblReData = new HashSet<TblReData>();
            TblSendLog = new HashSet<TblSendLog>();
        }

        public int SurveyNo { get; set; }
        public int ListNo { get; set; }
        public string CellNum { get; set; }
        public bool FinishBl { get; set; }
        public bool IngBl { get; set; }
        public bool RefusalBl { get; set; }
        public bool QuotaOverBl { get; set; }
        public bool StopBl { get; set; }
        public int? EndCode { get; set; }
        public int? StateCode { get; set; }
        public string Col01 { get; set; }
        public string Col02 { get; set; }
        public string Col03 { get; set; }
        public string Col04 { get; set; }
        public string Col05 { get; set; }
        public string Col06 { get; set; }
        public int? QuestCount { get; set; }

        public virtual TblSurvey SurveyNoNavigation { get; set; }
        public virtual ICollection<TblListQuota> TblListQuota { get; set; }
        public virtual ICollection<TblQuestionHistory> TblQuestionHistory { get; set; }
        public virtual ICollection<TblReData> TblReData { get; set; }
        public virtual ICollection<TblSendLog> TblSendLog { get; set; }
    }
}
