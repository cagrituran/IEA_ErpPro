//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_ErpProject_CT.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUrunGirisUst
    {
        public int Id { get; set; }
        public Nullable<int> GirisId { get; set; }
        public string CariTip { get; set; }
        public string CariAdi { get; set; }
        public Nullable<int> CariId { get; set; }
        public string GirisTuru { get; set; }
        public string FaturaNo { get; set; }
        public string Aciklama { get; set; }
        public Nullable<System.DateTime> GirisTarih { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdateUser { get; set; }
    }
}