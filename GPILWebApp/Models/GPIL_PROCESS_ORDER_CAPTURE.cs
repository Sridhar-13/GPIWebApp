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
    
    public partial class GPIL_PROCESS_ORDER_CAPTURE
    {
        public int SNO { get; set; }
        public string PROCESS_ID { get; set; }
        public string GPIL_BALE_NUMBER { get; set; }
        public string PROCESS_NAME { get; set; }
        public string PROCESS_REF_ID { get; set; }
        public string ORGN_CODE { get; set; }
        public double WEIGHT { get; set; }
        public System.DateTime PROCESS_DATE { get; set; }
        public string WEIGHMENT_TRACE { get; set; }
        public byte[] LASTUPDATE { get; set; }
    
        public virtual GPIL_ORGN_MASTER GPIL_ORGN_MASTER { get; set; }
        public virtual GPIL_ORGN_MASTER GPIL_ORGN_MASTER1 { get; set; }
        public virtual GPIL_STOCK GPIL_STOCK { get; set; }
        public virtual GPIL_STOCK GPIL_STOCK1 { get; set; }
    }
}
