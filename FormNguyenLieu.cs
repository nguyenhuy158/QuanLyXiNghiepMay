using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormNguyenLieu : Form
    {
        public FormNguyenLieu()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            (new Precenter()).getData(dataGridView1, Precenter.KEY_NGUYEN_LIEU);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.maNguyenLieu = textBoxMaNguyenLieu.Text.Trim();
            nguyenLieu.tenNguyenLieu = textBoxTenNguyenLieu.Text.Trim();
            nguyenLieu.ghiChu = textBoxGhiChu.Text.Trim();

            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            data.NguyenLieux.Add(nguyenLieu);
            data.SaveChanges();
            (new Precenter()).getData(dataGridView1, Precenter.KEY_NGUYEN_LIEU);
        }
       
    }
}
