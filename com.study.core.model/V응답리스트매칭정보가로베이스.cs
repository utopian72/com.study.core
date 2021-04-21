using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class V응답리스트매칭정보가로베이스
    {
        public int SurveyNo { get; set; }
        public int ListNo { get; set; }
        public string QtCode { get; set; }
        public string QtText { get; set; }
        public string OpCode { get; set; }
        public string InputLabel { get; set; }
        public bool? Open { get; set; }
        public int QhNo { get; set; }
        public string Value { get; set; }
        public DateTime? Regdate { get; set; }
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
    }
}
