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
    
    public partial class PhanXuong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhanXuong()
        {
            this.PhieuPhanCongs = new HashSet<PhieuPhanCong>();
        }
    
        public string ma { get; set; }
        public string ten { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuPhanCong> PhieuPhanCongs { get; set; }
    }
}
