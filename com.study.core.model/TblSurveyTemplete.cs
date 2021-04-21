using System;
using System.Collections.Generic;

namespace com.study.core.model
{
    public partial class TblSurveyTemplete
    {
        public int SurveyNo { get; set; }
        public string Type { get; set; }
        public string Contents { get; set; }
        public bool? UseBl { get; set; }

        public virtual TblSurvey SurveyNoNavigation { get; set; }
    }
}
