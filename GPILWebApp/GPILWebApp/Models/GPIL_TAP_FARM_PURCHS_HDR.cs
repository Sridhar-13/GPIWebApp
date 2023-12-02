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
    
    public partial class GPIL_TAP_FARM_PURCHS_HDR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GPIL_TAP_FARM_PURCHS_HDR()
        {
            this.GPIL_TAP_FARM_PURCHS_DTLS = new HashSet<GPIL_TAP_FARM_PURCHS_DTLS>();
        }
    
        public int SNO { get; set; }
        public string HEADER_ID { get; set; }
        public string ORGN_CODE { get; set; }
        public string PURCHASE_TYPE { get; set; }
        public string BUYER_CODE { get; set; }
        public string PURCH_DOC_NO { get; set; }
        public System.DateTime DATE_OF_PURCH { get; set; }
        public string CROP { get; set; }
        public string VARIETY { get; set; }
        public string INVOICE_NO { get; set; }
        public Nullable<System.DateTime> INVOICE_DATE { get; set; }
        public string CHEQUE_NO { get; set; }
        public Nullable<double> CHEQUE_AMT { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATION_DATE { get; set; }
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
    
        public virtual GPIL_CROP_MASTER GPIL_CROP_MASTER { get; set; }
        public virtual GPIL_ORGN_MASTER GPIL_ORGN_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPIL_TAP_FARM_PURCHS_DTLS> GPIL_TAP_FARM_PURCHS_DTLS { get; set; }
        public virtual GPIL_USER_MASTER GPIL_USER_MASTER { get; set; }
        public virtual GPIL_USER_MASTER GPIL_USER_MASTER1 { get; set; }
        public virtual GPIL_VARIETY_MASTER GPIL_VARIETY_MASTER { get; set; }
    }
}