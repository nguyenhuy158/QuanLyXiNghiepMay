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
    
    public partial class ChiTietPhieuNhan
    {
        public string soPhieuNhan { get; set; }
        public string maNguyenLieu { get; set; }
        public Nullable<int> soLuong { get; set; }
    
        public virtual NguyenLieu NguyenLieu { get; set; }
        public virtual PhieuNhanNguyenLieu PhieuNhanNguyenLieu { get; set; }
    }
}
