using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlConnection = "";
            SqlConnection sqlConnection1 = new SqlConnection(sqlConnection);
        }

        private void nguyenLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNguyenLieu form3 = new FormNguyenLieu();
            form3.MdiParent = this;
            form3.Show();
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSanPham form = new FormSanPham();
            form.MdiParent = this;
            form.Show();
        }

        private void địnhMứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDinhMuc form = new FormDinhMuc();
            form.MdiParent = this;
            form.Show();
        }

        private void thôngTinTácGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormThongTinTacGia formThongTinTacGia = new FormThongTinTacGia();
            //formThongTinTacGia.MdiParent = this;
            formThongTinTacGia.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ứng dụng ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Dispose();
            }
        }
    }
}
