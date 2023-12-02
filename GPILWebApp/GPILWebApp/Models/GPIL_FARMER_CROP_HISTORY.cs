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
    
    public class GPIL_FARMER_CROP_HISTORY
    {
        public int SNO { get; set; }
        public string HIS_CODE { get; set; }
        public string FARM_CODE { get; set; }
        public string CROP { get; set; }
        public string VARIETY { get; set; }
        public Nullable<double> LOAN_AMOUNT { get; set; }
        public Nullable<double> BALANCE_AMOUNT { get; set; }
        public string MOBILE_NO { get; set; }
        public string EMAIL_ID { get; set; }
        public string BANK_ACCOUNT_NO { get; set; }
        public string BANK_NAME { get; set; }
        public string BRANCH_NAME { get; set; }
        public string IFSC_CODE { get; set; }
        public string REMARKS { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string FLAG { get; set; }
        public byte[] LASTUPDATE { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }

        public virtual GPIL_FARMER_MASTER GPIL_FARMER_MASTER { get; set; }
    }
}
