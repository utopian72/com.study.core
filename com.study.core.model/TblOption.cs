using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblOption
    {
        public TblOption()
        {
            TblOptionAttribute = new HashSet<TblOptionAttribute>();
            TblReData = new HashSet<TblReData>();
        }

        public int SurveyNo { get; set; }
        public string QtCode { get; set; }
        public string OpCode { get; set; }
        public string InputType { get; set; }
        public string InputLabel { get; set; }
        public string InputValue { get; set; }
        public string NextQuestion { get; set; }
        public int? EndCode { get; set; }
        public bool? Open { get; set; }

        public virtual TblQuestion TblQuestion { get; set; }
        public virtual ICollection<TblOptionAttribute> TblOptionAttribute { get; set; }
        public virtual ICollection<TblReData> TblReData { get; set; }
    }
}
