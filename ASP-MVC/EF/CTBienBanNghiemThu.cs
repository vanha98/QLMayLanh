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
    
    public partial class CTBienBanNghiemThu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTBienBanNghiemThu()
        {
            this.CTBBNT_MayLanh = new HashSet<CTBBNT_MayLanh>();
        }
    
        public int ID { get; set; }
        public int IDBBNT { get; set; }
        public int IDDichVu { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<double> Diem { get; set; }
        public string MayLanh { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<long> CPDauVao { get; set; }
        public string GhiChu { get; set; }
    
        public virtual BienBanNghiemThu BienBanNghiemThu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBBNT_MayLanh> CTBBNT_MayLanh { get; set; }
        public virtual DichVu_SanPham DichVu_SanPham { get; set; }
    }
}