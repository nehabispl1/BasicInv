//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagement.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Web_M_MenuMaster
    {
        public decimal AId { get; set; }
        public decimal MenuId { get; set; }
        public string Hierar { get; set; }
        public string MenuName { get; set; }
        public decimal ParentId { get; set; }
        public string OnSelect { get; set; }
        public string ShortKeys { get; set; }
        public string ImageName { get; set; }
        public decimal ManualSize { get; set; }
        public System.DateTime RecTimeStamp { get; set; }
        public string LastModified { get; set; }
        public string ActiveStatus { get; set; }
        public string GrpPermission { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<int> ChildSequence { get; set; }
    }
}