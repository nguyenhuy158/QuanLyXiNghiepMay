using QuanLyXiNghiepMay.Form_Child;
using QuanLyXiNghiepMay.Form_Detail.Form_Phieu_Nhan;
using QuanLyXiNghiepMay.Form_Detail.Form_Phieu_Phan_Cong;
using QuanLyXiNghiepMay.Form_Parent;
using QuanLyXiNghiepMay.R;
using QuanLyXiNghiepMay.R.ControlerForForm;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormMainOld : Form
    {
        public FormMainOld()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormNguyenLieuOld());
        }


        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormSanPhamOld());
        }

        private void địnhMứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormDinhMucOld());
        }

        private void thôngTinTácGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ControlerMain.showFormNoAttactParent(this, new FormThongTinTacGia());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.exitForm(this);
        }

        private void phânXưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormPhanXuongOld());
        }

        private void côngĐoạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormCongDoanOld());
        }

        private void phiếuNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormPhieuNhanOld());
        }

        private void chiTiếtPhiếuNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormChiTietPhieuNhanOld());
        }

        private void phiếuPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormPhieuPhanCongOld());
        }

        private void chiTiếtPhiếuPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormChiTietPhieuPhanCongOld());
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlerMain.showForm(this, new FormReport());
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlerMain.exitForm(this);
        }

    }

}
