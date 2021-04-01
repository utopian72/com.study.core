using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblSendLog
    {
        public int SurveyNo { get; set; }
        public int ListNo { get; set; }
        public int SendNo { get; set; }
        public string CellNum { get; set; }
        public DateTime? RegDate { get; set; }
        public string EncryKey { get; set; }
        public int DurationDay { get; set; }

        public virtual TblList TblList { get; set; }
    }
}
