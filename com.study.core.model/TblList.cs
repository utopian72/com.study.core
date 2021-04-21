using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Display(Name="조사번호")]
        public int SurveyNo { get; set; }
        [Display(Name = "리스트번호")]
        public int ListNo { get; set; }
        [Display(Name = "전화번호")]
        public string CellNum { get; set; }
        [Display(Name = "종료여부")]
        public bool FinishBl { get; set; }
        [Display(Name = "진행여부")]
        public bool IngBl { get; set; }
        [Display(Name = "거절여부")]
        public bool RefusalBl { get; set; }
        [Display(Name = "쿼터오버")]
        public bool QuotaOverBl { get; set; }
        [Display(Name = "중단여부")]
        public bool StopBl { get; set; }
        [Display(Name = "종료항목")]
        public int? EndCode { get; set; }
        [Display(Name = "상태코드")]
        public int? StateCode { get; set; }
        [Display(Name = "항목01")]
        public string Col01 { get; set; }
        [Display(Name = "항목02")]
        public string Col02 { get; set; }
        [Display(Name = "항목03")]
        public string Col03 { get; set; }
        [Display(Name = "항목04")]
        public string Col04 { get; set; }
        [Display(Name = "항목05")]
        public string Col05 { get; set; }
        [Display(Name = "항목06")]
        public string Col06 { get; set; }
        [Display(Name = "항목개수")]
        public int? QuestCount { get; set; }

        public virtual TblSurvey SurveyNoNavigation { get; set; }
        public virtual ICollection<TblListQuota> TblListQuota { get; set; }
        public virtual ICollection<TblQuestionHistory> TblQuestionHistory { get; set; }
        public virtual ICollection<TblReData> TblReData { get; set; }
        public virtual ICollection<TblSendLog> TblSendLog { get; set; }
    }
}
