using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    internal class Precenter
    {
        public static string KEY_NGUYEN_LIEU = "KEY_NGUYEN_LIEU";
        public static string KEY_SAN_PHAM = "KEY_SAN_PHAM";
        public static string KEY_DINH_MUC = "KEY_DINH_MUC";
        public void getData(DataGridView dataGridView, string key)
        {
            if (key == KEY_NGUYEN_LIEU)
            {
                List<NguyenLieu> nguyenLieus = (new QuanLyVatTuCuaXiNghiepMayEntities()).NguyenLieux.ToList();
                int i = 0;
                dataGridView.DataSource = (from nguyenLieu in nguyenLieus
                                           select new
                                           {
                                               No = ++i,
                                               maNguyenLieu = nguyenLieu.maNguyenLieu,
                                               tenNguyenLieu = nguyenLieu.tenNguyenLieu,
                                               ghiChu = nguyenLieu.ghiChu
                                           }).ToList();
            }
            else if (key == KEY_SAN_PHAM)
            {
                List<SanPham> sanPhams = (new QuanLyVatTuCuaXiNghiepMayEntities()).SanPhams.ToList();
                int i = 0;
                dataGridView.DataSource = (from sanPham in sanPhams
                                           select new
                                           {
                                               No = ++i,
                                               maSanPham = sanPham.maSanPham,
                                               tenSanPham = sanPham.tenSanPham,
                                               ghiChu = sanPham.ghiChu
                                           }).ToList();
            }
            else if (key == KEY_DINH_MUC)
            {
                List<DinhMuc> dinhMucs = (new QuanLyVatTuCuaXiNghiepMayEntities()).DinhMucs.ToList();
                int i = 0;
                dataGridView.DataSource = (from dinhMuc in dinhMucs
                                           select new
                                           {
                                               No = ++i,
                                               maSanPham = dinhMuc.maSanPham,
                                               maNguyenLieu = dinhMuc.maNguyenLieu,
                                               donViTinh = dinhMuc.donViTinh,
                                               soLuong = dinhMuc.soLuong
                                           }).ToList();
            }
        }
    }
}
