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
    using System.ComponentModel.DataAnnotations;

    public partial class GPIL_VILLAGE_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GPIL_VILLAGE_MASTER()
        {
            this.GPIL_FARMER_FREIGHT_CHARGE_MASTER = new HashSet<GPIL_FARMER_FREIGHT_CHARGE_MASTER>();
        }

        //public int SNO { get; set; }
        //public string VILLAGE_CODE { get; set; }
        //public string VILLAGE_NAME { get; set; }
        //public string CLUSTER_CODE { get; set; }
        //public string CREATED_BY { get; set; }
        //public System.DateTime CREATED_DATE { get; set; }
        //public string LAST_UPDATED_BY { get; set; }
        //public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        //public string STATUS { get; set; }
        //public string FLAG { get; set; }
        //public byte[] LASTUPDATE { get; set; }
        //public string ATTRIBUTE1 { get; set; }
        //public string ATTRIBUTE2 { get; set; }
        //public string ATTRIBUTE3 { get; set; }
        //public string ATTRIBUTE4 { get; set; }
        //public string ATTRIBUTE5 { get; set; }


        public int SNO { get; set; }
        [Required(ErrorMessage = "VILLAGE CODE IS REQUIRED")]
        [StringLength(8, MinimumLength = 6)]
        public string VILLAGE_CODE { get; set; }
        [Required(ErrorMessage = "VILLAGE NAME IS REQUIRED")]
        [StringLength(50, MinimumLength = 6)]
        public string VILLAGE_NAME { get; set; }
        [Required(ErrorMessage = "PLEASE SELECT CLUSTER CODE")]
        [StringLength(3, MinimumLength = 3)]
        public string CLUSTER_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }

        [Required(ErrorMessage = "PLEASE SELECT STATUS")]
        public string STATUS { get; set; }
        public string FLAG { get; set; }
        public byte[] LASTUPDATE { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }


        public virtual GPIL_CLUSTER_MASTER GPIL_CLUSTER_MASTER { get; set; }
        public virtual GPIL_CLUSTER_MASTER GPIL_CLUSTER_MASTER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPIL_FARMER_FREIGHT_CHARGE_MASTER> GPIL_FARMER_FREIGHT_CHARGE_MASTER { get; set; }
        public virtual GPIL_USER_MASTER GPIL_USER_MASTER { get; set; }
        public virtual GPIL_USER_MASTER GPIL_USER_MASTER1 { get; set; }
    }
    public class ListVillageMaster
    {
        public List<GPIL_VILLAGE_MASTER> VillageMasters { get; set; }
    }
}
