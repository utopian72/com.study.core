using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace com.study.core.model
{
    public partial class TblUser
    {
        [Display(Name="아이디")]
        public string MemId { get; set; }
        [Display(Name = "패스워드")]
        public string Pwd { get; set; }
        [Display(Name = "이름")]
        public string MemName { get; set; }
        [Display(Name = "등급")]
        public int? Grade { get; set; }
        [Display(Name = "삭제여부")]
        public bool? IsDel { get; set; }
        [Display(Name = "최종접속일")]
        public DateTime? LastDate { get; set; }
        [Display(Name = "등록일")]
        public DateTime? RegDate { get; set; }
    }
}
