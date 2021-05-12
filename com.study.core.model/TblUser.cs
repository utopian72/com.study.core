using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblUser
    {
        public string MemId { get; set; }
        public string Pwd { get; set; }
        public string MemName { get; set; }
        public int? Grade { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? LastDate { get; set; }
        public DateTime? RegDate { get; set; }
    }
}
