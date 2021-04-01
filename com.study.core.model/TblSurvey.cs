using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblSurvey
    {
        public TblSurvey()
        {
            TblList = new HashSet<TblList>();
            TblQuestion = new HashSet<TblQuestion>();
            TblQuotaLabel = new HashSet<TblQuotaLabel>();
            TblSurveyTemplete = new HashSet<TblSurveyTemplete>();
        }

        public int SurveyNo { get; set; }
        public string SName { get; set; }
        public bool? UseBl { get; set; }
        public string SmsMessage { get; set; }
        public bool IngQuotaBl { get; set; }
        public int LastDay { get; set; }
        public string Callback { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string LogoFile { get; set; }
        public bool? UseListCountBl { get; set; }
        public string CssStyleName { get; set; }
        public bool? UseQuotaAccessBl { get; set; }
        public int? LogoWidth { get; set; }
        public int? LogHeight { get; set; }
        public string SurveyYear { get; set; }

        public virtual ICollection<TblList> TblList { get; set; }
        public virtual ICollection<TblQuestion> TblQuestion { get; set; }
        public virtual ICollection<TblQuotaLabel> TblQuotaLabel { get; set; }
        public virtual ICollection<TblSurveyTemplete> TblSurveyTemplete { get; set; }
    }
}
