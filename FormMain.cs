using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
