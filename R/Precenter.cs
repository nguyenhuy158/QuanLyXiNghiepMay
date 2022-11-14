using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyXiNghiepMay.R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    internal class Precenter
    {
        private static QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();

        internal static string getMaPhanXuong()
        {
            return data.Database.SqlQuery<String>("Select dbo.TaoMaPhanXuong();").FirstOrDefault();
        }

        internal static string getMaSanPham()
        {
            return data.Database.SqlQuery<String>("Select dbo.TaoMaSanPham();").FirstOrDefault();
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


    }
}
