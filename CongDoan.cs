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
    
    public partial class CongDoan
    {
        public string maSanPham { get; set; }
        public string soCongDoan { get; set; }
        public string yeuCauKyThuat { get; set; }
        public Nullable<int> mucTienLuong { get; set; }
        public string ghiChu { get; set; }
    
        public virtual SanPham SanPham { get; set; }
    }
}
