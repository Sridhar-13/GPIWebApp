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
    
    public partial class GPIL_THRESH_RECON_HDR_TEMP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GPIL_THRESH_RECON_HDR_TEMP()
        {
            this.GPIL_THRESH_RECON_DTLS_1_TEMP = new HashSet<GPIL_THRESH_RECON_DTLS_1_TEMP>();
            this.GPIL_THRESH_RECON_DTLS_2_TEMP = new HashSet<GPIL_THRESH_RECON_DTLS_2_TEMP>();
        }
    
        public int SNO { get; set; }
        public string BATCH_NO { get; set; }
        public string ORGN_CODE { get; set; }
        public string RECIPE_CODE { get; set; }
        public Nullable<int> REPORT_NO { get; set; }
        public string SHIFT { get; set; }
        public string SHIFT_INCHARGE { get; set; }
        public System.DateTime DATE_OF_OPERATION { get; set; }
        public string CROP { get; set; }
        public string VARIETY { get; set; }
        public Nullable<int> NO_OF_GRADES { get; set; }
        public Nullable<int> TOT_ISSUE_BALES { get; set; }
        public Nullable<double> TOT_ISSUE_MARKED_QTY { get; set; }
        public Nullable<double> TOT_ISSUE_ASCERTAIN_QTY { get; set; }
        public Nullable<int> TOT_ELIMINATE_BALES { get; set; }
        public Nullable<double> TOT_ELIMINATE_QTY { get; set; }
        public Nullable<int> TOT_GRADTRANS_BALES { get; set; }
        public Nullable<double> TOT_GRADTRANS_QTY { get; set; }
        public Nullable<int> TOT_BYPRODUCT_BALES { get; set; }
        public Nullable<double> TOT_BYPRODUCT_QTY { get; set; }
        public Nullable<int> TOT_PRODUCT_CASE { get; set; }
        public Nullable<double> TOT_PRODUCT_QTY { get; set; }
        public Nullable<double> TOT_INPUT_QTY { get; set; }
        public Nullable<double> TOT_OUTPUT_QTY { get; set; }
        public Nullable<double> THRESHING_CHARGES { get; set; }
        public Nullable<double> THRESHING_LOSS { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string FLAG { get; set; }
        public byte[] LASTUPDATE { get; set; }
        public string REMARKS { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }
    
        public virtual GPIL_CROP_MASTER GPIL_CROP_MASTER { get; set; }
        public virtual GPIL_OPERATION_RECIPE GPIL_OPERATION_RECIPE { get; set; }
        public virtual GPIL_ORGN_MASTER GPIL_ORGN_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPIL_THRESH_RECON_DTLS_1_TEMP> GPIL_THRESH_RECON_DTLS_1_TEMP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPIL_THRESH_RECON_DTLS_2_TEMP> GPIL_THRESH_RECON_DTLS_2_TEMP { get; set; }
        public virtual GPIL_USER_MASTER GPIL_USER_MASTER { get; set; }
        public virtual GPIL_USER_MASTER GPIL_USER_MASTER1 { get; set; }
        public virtual GPIL_VARIETY_MASTER GPIL_VARIETY_MASTER { get; set; }
    }
}
