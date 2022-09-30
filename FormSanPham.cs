using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Precenter.KEY_SAN_PHAM);

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.maSanPham = textBoxMaSanPham.Text.Trim();
            sanPham.tenSanPham = textBoxTenSanPham.Text.Trim();
            sanPham.ghiChu = textBoxGhiChu.Text.Trim();
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            data.SanPhams.Add(sanPham);
            data.SaveChanges();
            (new Precenter()).getData(dataGridView1, Precenter.KEY_SAN_PHAM);
        }
    }
}
