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
    
    public partial class sp_tCaseDetails_Ins_Result
    {
        public string LocCode { get; set; }
        public string CaseBarCode { get; set; }
        public string RecvLocCode { get; set; }
        public string VoidBarCode { get; set; }
        public string ToLocCode { get; set; }
        public string StackID { get; set; }
        public Nullable<int> PickListNo { get; set; }
        public Nullable<int> LP5No { get; set; }
        public string NIC { get; set; }
        public string TRS { get; set; }
        public string CL { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<int> TempPickListNo { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<System.DateTime> PutawayOn { get; set; }
        public string PutawayBy { get; set; }
        public Nullable<System.DateTime> FumStartOn { get; set; }
        public Nullable<System.DateTime> FumEndOn { get; set; }
        public Nullable<System.DateTime> FumExpiredOn { get; set; }
        public string FumigatedBy { get; set; }
        public Nullable<int> PrevPickListNo { get; set; }
        public Nullable<int> PrevLP5No { get; set; }
        public string PrevNIC { get; set; }
        public string PrevTRS { get; set; }
        public string PrevCL { get; set; }
        public Nullable<System.DateTime> PrevInTime { get; set; }
        public Nullable<System.DateTime> PrevOutTime { get; set; }
        public Nullable<bool> IsExistingStock { get; set; }
        public Nullable<byte> D_Stts { get; set; }
        public System.Guid rowguid { get; set; }
    }
}
