//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_MVC.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuNhapVatTu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhapVatTu()
        {
            this.CTPhieuNhapVatTus = new HashSet<CTPhieuNhapVatTu>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuNhapVatTu> CTPhieuNhapVatTus { get; set; }
    }
}