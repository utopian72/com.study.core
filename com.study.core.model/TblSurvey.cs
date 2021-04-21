using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name ="조사명")]
        public string SName { get; set; }

        [Display(Name = "진행")]
        public bool? UseBl { get; set; }

        
        public string SmsMessage { get; set; }
        [Display(Name = "쿼터")]
        public bool IngQuotaBl { get; set; }

        [Display(Name = "마감일")]
        public int LastDay { get; set; }
        public string Callback { get; set; }
        [Display(Name = "접속경로")]
        public string Url { get; set; }
        public string Description { get; set; }
        public string LogoFile { get; set; }
        public bool? UseListCountBl { get; set; }
        public string CssStyleName { get; set; }
        public bool? UseQuotaAccessBl { get; set; }
        public int? LogoWidth { get; set; }
        public int? LogHeight { get; set; }
        [Display(Name = "진행년도")]
        public string SurveyYear { get; set; }

        public virtual ICollection<TblList> TblList { get; set; }
        public virtual ICollection<TblQuestion> TblQuestion { get; set; }
        public virtual ICollection<TblQuotaLabel> TblQuotaLabel { get; set; }
        public virtual ICollection<TblSurveyTemplete> TblSurveyTemplete { get; set; }
    }
}
