﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SawyerSight.Web.Models.ETL.Costpoint
{
    public class PSR_PY_SUM: ETLGeneric
    {
        public string PROJ_ID { get; set; }
        public string ORG_ID { get; set; }
        public string ACCT_ID { get; set; }
        public string FY_CD { get; set; }
        public decimal BURD_AMT { get; set; }
        public decimal TOT_REV_AMT { get; set; }
        public int ReportDataSetID { get; set; }
    }
}