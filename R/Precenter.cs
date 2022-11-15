using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraVerticalGrid;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Child;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Nhan;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Phan_Cong;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Parent;
using QuanLyXiNghiepMay.R;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace QuanLyXiNghiepMay
{
    internal class Precenter
    {
        public static QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();

        internal static string getMaPhieuPhanCong()
        {
            return data.Database.SqlQuery<String>("Select dbo.TaoMaPhieuPhanCong();").FirstOrDefault();
        }

        internal static string getMaPhieuNhan()
        {
            return data.Database.SqlQuery<String>("Select dbo.TaoMaPhieuNhan();").FirstOrDefault();
        }

        internal static string getMaNguyenLieu()
        {
            return data.Database.SqlQuery<String>("Select dbo.TaoMaNguyenLieu();").FirstOrDefault();
        }


        internal static string getMaCongDoan()
        {
            return data.Database.SqlQuery<String>("Select dbo.TaoMaCongDoan();").FirstOrDefault();
        }

        internal static string getMaPhanXuong()
        {
            return data.Database.SqlQuery<String>("Select dbo.TaoMaPhanXuong();").FirstOrDefault();
        }

        internal static string getMaSanPham()
        {
            return data.Database.SqlQuery<String>("Select dbo.TaoMaSanPham();").FirstOrDefault();
        }

        internal static void reloadDataSource(RibbonFormPhanXuong ribbonFormPhanXuong, GridControl gridControl1)
        {
            gridControl1.DataSource = data.PhanXuongs.ToList();
        }

        internal static void reloadDataSource(RibbonFormNguyenLieu ribbonFormNguyenLieu, GridControl gridControl1)
        {
            gridControl1.DataSource = data.NguyenLieux.ToList();
        }

        internal static void reloadDataSource(RibbonFormCongDoan ribbonFormCongDoan, GridControl gridControl1)
        {
            gridControl1.DataSource = data.CongDoans.ToList();
        }

        internal static void reloadDataSource(RibbonFormDinhMuc ribbonFormDinhMuc, GridControl gridControl1)
        {
            gridControl1.DataSource = data.DinhMucs.ToList();
        }

        internal static void reloadDataSource(RibbonFormPhieuNhan ribbonFormPhieuNhan, GridControl gridControl1)
        {
            gridControl1.DataSource = data.PhieuNhans.ToList();
        }

        internal static void reloadDataSource(RibbonFormChiTietPhieuNhan ribbonFormChiTietPhieuNhan, GridControl gridControl1)
        {
            gridControl1.DataSource = data.ChiTietPhieuNhans.ToList();
        }

        internal static void reloadDataSource(RibbonFormPhieuPhanCong ribbonFormPhieuPhanCong, GridControl gridControl1)
        {
            gridControl1.DataSource = data.PhieuPhanCongs.ToList();
        }

        internal static void reloadDataSource(RibbonFormChiTietPhieuPhanCong ribbonFormChiTietPhieuPhanCong, GridControl gridControl1)
        {
            gridControl1.DataSource = data.ChiTietPhieuPhanCongs.ToList();
        }

        internal static void reloadDataSource(XtraFormSanPham xtraFormSanPham, GridControl gridControl1)
        {
            gridControl1.DataSource = data.SanPhams.ToList();
        }

        public void getData(DataGridView dataGridView, string key)
        {
            if (key == Constance.KEY_NGUYEN_LIEU)
            {
                List<NguyenLieu> nguyenLieus = (new QuanLyVatTuCuaXiNghiepMayEntities()).NguyenLieux.ToList();
                int i = 0;
                dataGridView.DataSource = (from nguyenLieu in nguyenLieus
                                           select new
                                           {
                                               Stt = ++i,
                                               maNguyenLieu = nguyenLieu.ma,
                                               tenNguyenLieu = nguyenLieu.ten,
                                               ghiChu = nguyenLieu.ghiChu
                                           }).ToList();
            }
            else if (key == Constance.KEY_SAN_PHAM)
            {
                List<SanPham> sanPhams = (new QuanLyVatTuCuaXiNghiepMayEntities()).SanPhams.ToList();
                int i = 0;
                dataGridView.DataSource = (from sanPham in sanPhams
                                           select new
                                           {
                                               No = ++i,
                                               maSanPham = sanPham.ma,
                                               tenSanPham = sanPham.ten,
                                               ghiChu = sanPham.ghiChu
                                           }).ToList();
            }
            else if (key ==
                Constance.KEY_PHAN_XUONG)
            {
                List<PhanXuong> phanXuongs = (new QuanLyVatTuCuaXiNghiepMayEntities()).PhanXuongs.ToList();
                int i = 0;
                dataGridView.DataSource = (from phanXuong in phanXuongs
                                           select new
                                           {
                                               No = ++i,
                                               maPhanXuong = phanXuong.ma,
                                               tenPhanXuong = phanXuong.ten,
                                               diaChi = phanXuong.diaChi,
                                               soDienThoai = phanXuong.sdt
                                           }).ToList();
            }
            else if (key == Constance.KEY_DINH_MUC)
            {
                List<DinhMuc> dinhMucs = (new QuanLyVatTuCuaXiNghiepMayEntities()).DinhMucs.ToList();
                int i = 0;
                dataGridView.DataSource = (from dinhMuc in dinhMucs
                                           select new
                                           {
                                               No = ++i,
                                               maNguyenLieu = dinhMuc.maNguyenLieu,
                                               maSanPham = dinhMuc.maSanPham,
                                               tenNguyenLieu = dinhMuc.NguyenLieu.ten,
                                               tenSanPham = dinhMuc.SanPham.ten,
                                               donViTinh = dinhMuc.donViTinh,
                                               soLuong = dinhMuc.soLuong
                                           }).ToList();
            }
            else if (key == Constance.KEY_CONG_DOAN)
            {
                List<CongDoan> congDoans = (new QuanLyVatTuCuaXiNghiepMayEntities()).CongDoans.ToList();
                int i = 0;
                dataGridView.DataSource = (from congDoan in congDoans
                                           select new
                                           {
                                               No = ++i,
                                               maSanPham = congDoan.maSanPham,
                                               sttCongDoan = congDoan.soCongDoan,
                                               yeuCauKyThuat = congDoan.yeuCauKyThuat,
                                               dinhMucTienLuong = congDoan.mucTienLuong,
                                               ghiChu = congDoan.ghiChu
                                           }).ToList();
            }
            else if (key == Constance.KEY_PHIEU_NHAN)
            {
                List<PhieuNhan> phieuNhanNguyenLieus = (new QuanLyVatTuCuaXiNghiepMayEntities()).PhieuNhans.ToList();
                int i = 0;
                dataGridView.DataSource = (from phieuNhanNguyenLieu in phieuNhanNguyenLieus
                                           select new
                                           {
                                               No = ++i,
                                               soPhieuNhan = phieuNhanNguyenLieu.so,
                                               ngayLapPhieu = new DateTime(phieuNhanNguyenLieu.ngayTao.Year,
                            phieuNhanNguyenLieu.ngayTao.Month, phieuNhanNguyenLieu.ngayTao.Day).ToString("dd/MM/yyyy"),
                                               tenNguoiNhan = phieuNhanNguyenLieu.tenNguoiNhan
                                           }).ToList();
            }
            else if (key == Constance.KEY_CHI_TIET_PHIEU_NHAN)
            {
                List<ChiTietPhieuNhan> chiTietPhieuNhans = (new QuanLyVatTuCuaXiNghiepMayEntities()).ChiTietPhieuNhans.ToList();
                int i = 0;
                dataGridView.DataSource = (from chiTietPhieuNhan in chiTietPhieuNhans
                                           select new
                                           {
                                               No = ++i,
                                               soPhieuNhan = chiTietPhieuNhan.soPhieuNhan,
                                               maNguyenLieu = chiTietPhieuNhan.maNguyenLieu,
                                               soLuong = chiTietPhieuNhan.soLuong
                                           }).ToList();
            }
            else if (key == Constance.KEY_PHIEU_PHAN_CONG)
            {
                List<PhieuPhanCong> phieuPhanCongs = (new QuanLyVatTuCuaXiNghiepMayEntities()).PhieuPhanCongs.ToList();
                int i = 0;
                dataGridView.DataSource = (from phieuPhanCong in phieuPhanCongs
                                           select new
                                           {
                                               No = ++i,
                                               soPhieuPhanCong = phieuPhanCong.so,
                                               maPhanXuong = phieuPhanCong.maPhanXuong,
                                               ngayLapPhieu = new DateTime(phieuPhanCong.ngayTao.Year,
                            phieuPhanCong.ngayTao.Month, phieuPhanCong.ngayTao.Day).ToString("dd/MM/yyyy")
                                           }).ToList();
            }
            else if (key == Constance.KEY_CHI_TIET_PHIEU_PHAN_CONG)
            {
                List<ChiTietPhieuPhanCong> chiTietPhieuPhanCongs = (new QuanLyVatTuCuaXiNghiepMayEntities()).ChiTietPhieuPhanCongs.ToList();
                int i = 0;
                dataGridView.DataSource = (from chiTietPhieuPhanCong in chiTietPhieuPhanCongs
                                           select new
                                           {
                                               No = ++i,
                                               soPhieuPhanCong = chiTietPhieuPhanCong.soPhieuPhanCong,
                                               maSanPham = chiTietPhieuPhanCong.maSanPham,
                                               soLuong = chiTietPhieuPhanCong.soLuong
                                           }).ToList();
            }
            dataGridView.AutoResizeColumns();
        }

        internal static void loadDataSourceComboBox(ComboBox comboBoxEdit, string key)
        {
            if (key == Constance.KEY_MA_SAN_PHAM)
            {
                comboBoxEdit.DataSource = data.SanPhams.ToList();
                comboBoxEdit.DisplayMember = "ma";
                comboBoxEdit.ValueMember = "ma";
            }
            if (key == Constance.KEY_TEN_SAN_PHAM)
            {
                comboBoxEdit.DataSource = data.SanPhams.ToList();
                comboBoxEdit.DisplayMember = "ten";
                comboBoxEdit.ValueMember = "ten";
            }
            if (key == Constance.KEY_MA_NGUYEN_LIEU)
            {
                comboBoxEdit.DataSource = data.NguyenLieux.ToList();
                comboBoxEdit.DisplayMember = "ma";
                comboBoxEdit.ValueMember = "ma";
            }
            if (key == Constance.KEY_TEN_NGUYEN_LIEU)
            {
                comboBoxEdit.DataSource = data.NguyenLieux.ToList();
                comboBoxEdit.DisplayMember = "ten";
                comboBoxEdit.ValueMember = "ten";
            }

            if (key == Constance.KEY_MA_PHAN_XUONG)
            {
                comboBoxEdit.DataSource = data.PhanXuongs.ToList();
                comboBoxEdit.DisplayMember = "ma";
                comboBoxEdit.ValueMember = "ma";
            }
            if (key == Constance.KEY_TEN_PHAN_XUONG)
            {
                comboBoxEdit.DataSource = data.PhanXuongs.ToList();
                comboBoxEdit.DisplayMember = "ten";
                comboBoxEdit.ValueMember = "ten";
            }

            if (key == Constance.KEY_SO_PHIEU_NHAN)
            {
                comboBoxEdit.DataSource = data.PhieuNhans.ToList();
                comboBoxEdit.DisplayMember = "so";
                comboBoxEdit.ValueMember = "so";
            }
            if (key == Constance.KEY_SO_PHIEU_PHAN_CONG)
            {
                comboBoxEdit.DataSource = data.PhieuPhanCongs.ToList();
                comboBoxEdit.DisplayMember = "so";
                comboBoxEdit.ValueMember = "so";
            }
        }
    }
}
