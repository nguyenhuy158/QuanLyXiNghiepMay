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
    public partial class FormDinhMuc : Form
    {
        public FormDinhMuc()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormDinhMuc_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Precenter.KEY_DINH_MUC);
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            comboBoxMaSanPham.DataSource = data.SanPhams.ToList();
            comboBoxMaSanPham.DisplayMember = "maSanPham";
            comboBoxMaSanPham.ValueMember = "maSanPham";

            comboBoxMaNguyenLieu.DataSource = data.NguyenLieux.ToList();
            comboBoxMaNguyenLieu.DisplayMember = "maNguyenLieu";
            comboBoxMaNguyenLieu.ValueMember = "maNguyenLieu";

            comboBoxDonViTinh.SelectedIndex = 0;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            DinhMuc dinhMuc = new DinhMuc();
            dinhMuc.maSanPham = comboBoxMaSanPham.Text.Trim();
            dinhMuc.maNguyenLieu = comboBoxMaNguyenLieu.Text.Trim();
            dinhMuc.donViTinh = comboBoxDonViTinh.Text.Trim();
            dinhMuc.soLuong = int.Parse(textBoxSoLuong.Text.Trim());
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            data.DinhMucs.Add(dinhMuc);
            data.SaveChanges();
            (new Precenter()).getData(dataGridView1, Precenter.KEY_DINH_MUC);
        }
    }
}
