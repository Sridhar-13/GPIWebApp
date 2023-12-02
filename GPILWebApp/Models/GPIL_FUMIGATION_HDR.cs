//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GPILWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GPIL_FUMIGATION_HDR
    {
        public int SNO { get; set; }
        public string BATCH_NO { get; set; }
        public string ORGN_CODE { get; set; }
        public Nullable<System.DateTime> FUMIGATION_STARTING_DATE { get; set; }
        public Nullable<System.DateTime> FUMIGATION_ENDING_DATE { get; set; }
        public Nullable<int> TOT_FUN_IN_CASES { get; set; }
        public Nullable<int> TOT_FUN_OUT_CASES { get; set; }
        public Nullable<int> TOT_FUN_PARTIAL_CASES { get; set; }
        public Nullable<int> TOT_FUN_REMOVED_CASES { get; set; }
        public int FUMIGATION_DAYS_FOR_RUNPREIOD { get; set; }
        public int FUMIGATION_DAYS_FOR_EXPIRY { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public byte[] LASTUPDATE { get; set; }
        public string STATUS { get; set; }
        public string FLAG { get; set; }
        public string REMARKS { get; set; }
        public string TEMP_REF { get; set; }
        public string WMS_STATUS { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }
        public string WMS_FLAG1 { get; set; }
        public string WMS_FLAG2 { get; set; }
        public string WMS_ATTRIBUTE1 { get; set; }
        public string WMS_ATTRIBUTE2 { get; set; }
    }
}
