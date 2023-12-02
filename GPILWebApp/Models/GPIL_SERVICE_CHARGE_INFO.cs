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
    
    public partial class GPIL_SERVICE_CHARGE_INFO
    {
        public int SNO { get; set; }
        public string HISTORY_ID { get; set; }
        public string SERVICE_CHARGE_ID { get; set; }
        public Nullable<double> SERVICE_CHARGE_RATE { get; set; }
        public string SERVICE_TAX_ID { get; set; }
        public Nullable<double> SERVICE_TAX_RATE { get; set; }
        public string SERVICE_TAX_EDUCATION_CESS_ID { get; set; }
        public Nullable<double> SERVICE_TAX_EDUCATION_CESS_RATE { get; set; }
        public string SERVICE_SH_EDUCATION_CESS_ID { get; set; }
        public Nullable<double> SERVICE_SH_EDUCATION_CESS_RATE { get; set; }
        public System.DateTime STARTING_DATE { get; set; }
        public Nullable<System.DateTime> ENDING_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string FLAG { get; set; }
        public byte[] LASTUPDATE { get; set; }
    
        public virtual GPIL_USER_MASTER GPIL_USER_MASTER { get; set; }
        public virtual GPIL_USER_MASTER GPIL_USER_MASTER1 { get; set; }
    }
}
