using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblQuestion
    {
        public TblQuestion()
        {
            TblOption = new HashSet<TblOption>();
            TblQuestionAttribute = new HashSet<TblQuestionAttribute>();
        }

        public int SurveyNo { get; set; }
        public string QtCode { get; set; }
        public string QtType { get; set; }
        public string QtText { get; set; }
        public string QtBody { get; set; }
        public string QtScript { get; set; }
        public bool? UseQuotaBl { get; set; }
        public string NextQuestion { get; set; }
        public int? EndCode { get; set; }
        public string Exclude { get; set; }
        public string Include { get; set; }
        public int? Detailorder { get; set; }

        public virtual TblSurvey SurveyNoNavigation { get; set; }
        public virtual ICollection<TblOption> TblOption { get; set; }
        public virtual ICollection<TblQuestionAttribute> TblQuestionAttribute { get; set; }
    }
}
