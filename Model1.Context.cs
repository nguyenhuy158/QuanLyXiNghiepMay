﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyVatTuCuaXiNghiepMayEntities : DbContext
    {
        public QuanLyVatTuCuaXiNghiepMayEntities()
            : base("name=QuanLyVatTuCuaXiNghiepMayEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietPhieuNhan> ChiTietPhieuNhans { get; set; }
        public virtual DbSet<ChiTietPhieuPhanCong> ChiTietPhieuPhanCongs { get; set; }
        public virtual DbSet<CongDoan> CongDoans { get; set; }
        public virtual DbSet<DinhMuc> DinhMucs { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieux { get; set; }
        public virtual DbSet<PhanXuong> PhanXuongs { get; set; }
        public virtual DbSet<PhieuNhanNguyenLieu> PhieuNhanNguyenLieux { get; set; }
        public virtual DbSet<PhieuPhanCong> PhieuPhanCongs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}