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
    
    public partial class tblFirmalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFirmalar()
        {
            this.tblFirmaDetaylar = new HashSet<tblFirmaDetaylar>();
            this.tblUrunKayitUst = new HashSet<tblUrunKayitUst>();
        }
    
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Adres { get; set; }
        public Nullable<int> SehirId { get; set; }
        public string FirmaTip { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
    
        public virtual Sehirler Sehirler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFirmaDetaylar> tblFirmaDetaylar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunKayitUst> tblUrunKayitUst { get; set; }
    }
}
