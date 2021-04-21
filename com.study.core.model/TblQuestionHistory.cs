using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblQuestionHistory
    {
        public TblQuestionHistory()
        {
            TblReData = new HashSet<TblReData>();
        }

        public int SurveyNo { get; set; }
        public int ListNo { get; set; }
        public int QhNo { get; set; }
        public string InQtCode { get; set; }
        public string OutQtCode { get; set; }
        public bool DelBl { get; set; }
        public DateTime? Regdate { get; set; }

        public virtual TblList TblList { get; set; }
        public virtual ICollection<TblReData> TblReData { get; set; }
    }
}
