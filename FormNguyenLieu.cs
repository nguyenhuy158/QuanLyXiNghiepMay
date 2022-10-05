using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {


        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.maNguyenLieu = textBoxMaNguyenLieu.Text.Trim();
            nguyenLieu.tenNguyenLieu = textBoxTenNguyenLieu.Text.Trim();
            nguyenLieu.ghiChu = textBoxGhiChu.Text.Trim();

            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowCount = dataGridView1.SelectedRows.Count;
            if (rowCount != 1)
            {
                MessageBox.Show("Vui lòng chỉ chọn duy nhất một dòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                int selectedrowindex = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string maNguyenLieu = Convert.ToString(selectedRow.Cells["maNguyenLieu"].Value);
                string tenNguyenLieu = Convert.ToString(selectedRow.Cells["tenNguyenLieu"].Value);
                string ghiChu = Convert.ToString(selectedRow.Cells["ghiChu"].Value);

                textBoxMaNguyenLieu.Text = maNguyenLieu;
                textBoxTenNguyenLieu.Text = tenNguyenLieu;
                textBoxGhiChu.Text = ghiChu;
            }
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMaNguyenLieu.Text.Trim())
                || String.IsNullOrEmpty(textBoxTenNguyenLieu.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ mã nguyên liệu và tên nguyên liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
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
                catch (Exception)
                {
                    MessageBox.Show("Mã nguyên liệu đã tồn tại vui lòng nhập mã chưa tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    textBoxMaNguyenLieu.Focus();
                    //throw;
                }

            }
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                string tempName = "";
                try
                {
                    QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                    int selectedrowindex = dataGridView1.SelectedRows[i].Index;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string maNguyenLieu = Convert.ToString(selectedRow.Cells["maNguyenLieu"].Value);
                    string tenNguyenLieu = Convert.ToString(selectedRow.Cells["tenNguyenLieu"].Value);
                    string ghiChu = Convert.ToString(selectedRow.Cells["ghiChu"].Value);
                    tempName = maNguyenLieu;

                    var nguyenLieu = new NguyenLieu
                    {
                        maNguyenLieu = maNguyenLieu,
                        tenNguyenLieu = tenNguyenLieu,
                        ghiChu = ghiChu
                    };

                    data.NguyenLieux.Attach(nguyenLieu);
                    data.Entry(nguyenLieu).State = EntityState.Deleted;
                    data.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa " + tempName + " thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    //throw;
                }
            }
            (new Precenter()).getData(dataGridView1, Precenter.KEY_NGUYEN_LIEU);
        }
    }
}
