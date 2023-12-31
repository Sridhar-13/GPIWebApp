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

    public partial class GPIL_FARMER_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GPIL_FARMER_MASTER()
        {
            this.GPIL_FARMER_LOAN_TRANSACTIONS = new HashSet<GPIL_FARMER_LOAN_TRANSACTIONS>();
            this.GPIL_FARMER_PURCHASE_TRANSACTIONS = new HashSet<GPIL_FARMER_PURCHASE_TRANSACTIONS>();
        }

        //public int SNO { get; set; }
        //public string FARM_CODE { get; set; }
        //public string FARM_CATEGORY { get; set; }
        //public string FARM_NAME { get; set; }
        //public string FARM_FATHER_NAME { get; set; }
        //public string VILLAGE_CODE { get; set; }
        //public string SOIL_TYPE { get; set; }
        //public string FARM_ADDRESS1 { get; set; }
        //public string FARM_ADDRESS2 { get; set; }
        //public string FARM_ADDRESS3 { get; set; }
        //public string FARM_ADDRESS4 { get; set; }
        //public string FARM_ADDRESS5 { get; set; }
        //public string FARM_ADDRESS6 { get; set; }
        //public string COUNTRY { get; set; }
        //public string PIN_CODE { get; set; }
        //public string TEL_NO { get; set; }
        //public string MOBILE_NO { get; set; }
        //public string EMAIL_ID { get; set; }
        //public string BANK_ACCOUNT_NO { get; set; }
        //public string BANK_NAME { get; set; }
        //public string BRANCH_NAME { get; set; }
        //public string IFSC_CODE { get; set; }
        //public string CREATED_BY { get; set; }
        //public System.DateTime CREATED_DATE { get; set; }
        //public string LAST_UPDATED_BY { get; set; }
        //public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        //public string STATUS { get; set; }
        //public string FLAG { get; set; }
        //public byte[] LASTUPDATE { get; set; }
        //public Nullable<double> LOAN_AMOUNT { get; set; }
        //public string ALERT_FLAG { get; set; }
        //public string ALERT_MSG { get; set; }
        //public string ATTRIBUTE1 { get; set; }
        //public string ATTRIBUTE2 { get; set; }
        //public string ATTRIBUTE3 { get; set; }
        //public string ATTRIBUTE4 { get; set; }
        //public string ATTRIBUTE5 { get; set; }

        public int SNO { get; set; }

        [Required(ErrorMessage = "Crop is required")]
        public string CROP { get; set; }
        [Required(ErrorMessage = "Variety is required")]
        public string VARIETY { get; set; }
        [Required(ErrorMessage = "Farmer Code is required")]
        public string FARM_CODE { get; set; }
        [Required(ErrorMessage = "Farmer Category is required")]
        public string FARM_CATEGORY { get; set; }
        [Required(ErrorMessage = "Farmer Name is required")]
        public string FARM_NAME { get; set; }
        [Required(ErrorMessage = "Farmer Father is required")]
        public string FARM_FATHER_NAME { get; set; }
        [Required(ErrorMessage = "Village Code is required")]
        public string VILLAGE_CODE { get; set; }
        [Required(ErrorMessage = "Soil Type is required")]
        public string SOIL_TYPE { get; set; }
        [Required(ErrorMessage = "Address 1 is required")]
        public string FARM_ADDRESS1 { get; set; }
        public string FARM_ADDRESS2 { get; set; }
        public string FARM_ADDRESS3 { get; set; }
        public string FARM_ADDRESS4 { get; set; }
        public string FARM_ADDRESS5 { get; set; }
        public string FARM_ADDRESS6 { get; set; }
        public string COUNTRY { get; set; }
        public string PIN_CODE { get; set; }
        public string TEL_NO { get; set; }
        // [Required(ErrorMessage = "Mobile Number is required")]
        public string MOBILE_NO { get; set; }
        public string EMAIL_ID { get; set; }
        [Required(ErrorMessage = "Bank Account Number is required")]
        public string BANK_ACCOUNT_NO { get; set; }
        [Required(ErrorMessage = "Bank Name is required")]
        public string BANK_NAME { get; set; }
        [Required(ErrorMessage = "Bank Branch Name is required")]
        public string BRANCH_NAME { get; set; }
        [Required(ErrorMessage = "Bank IFSC Code is required")]
        public string IFSC_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        [Required(ErrorMessage = "Status is required")]
        public string STATUS { get; set; }
        public string FLAG { get; set; }
        public byte[] LASTUPDATE { get; set; }
        public Nullable<double> LOAN_AMOUNT { get; set; }
        public string ALERT_FLAG { get; set; }
        public string ALERT_MSG { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        [Required(ErrorMessage = "Aadhaar Number is required")]
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }

        public string A1 { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public string A4 { get; set; }
        public string A5 { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPIL_FARMER_LOAN_TRANSACTIONS> GPIL_FARMER_LOAN_TRANSACTIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GPIL_FARMER_PURCHASE_TRANSACTIONS> GPIL_FARMER_PURCHASE_TRANSACTIONS { get; set; }
    }
    public class ListFarmerMaster
    {
        public List<GPIL_FARMER_MASTER> FarmerMasters { get; set; }
    }
}
