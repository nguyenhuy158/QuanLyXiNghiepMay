//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyXiNghiepMay
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuPhanCong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuPhanCong()
        {
            this.ChiTietPhieuPhanCongs = new HashSet<ChiTietPhieuPhanCong>();
        }
    
        public string soPhieuPhanCong { get; set; }
        public string maPhanXuong { get; set; }
        public Nullable<System.DateTime> ngayLapPhieu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuPhanCong> ChiTietPhieuPhanCongs { get; set; }
        public virtual PhanXuong PhanXuong { get; set; }
    }
}