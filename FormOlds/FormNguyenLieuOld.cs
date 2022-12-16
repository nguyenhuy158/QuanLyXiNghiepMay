using QuanLyXiNghiepMay.R;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormNguyenLieuOld : Form
    {

        bool isUpdate = false;
        public FormNguyenLieuOld()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            (new Precenter()).getData(dataGridView1, Constance.KEY_NGUYEN_LIEU);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {


        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.ma = textBoxMaNguyenLieu.Text.Trim();
            nguyenLieu.ten = textBoxTenNguyenLieu.Text.Trim();
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
            if (isUpdate)
            {
                if (String.IsNullOrEmpty(textBoxMaNguyenLieu.Text.Trim())
                    || String.IsNullOrEmpty(textBoxTenNguyenLieu.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        NguyenLieu nguyenLieu = (from t in data.NguyenLieux
                                                 where t.ma == textBoxMaNguyenLieu.Text
                                                 select t).SingleOrDefault();
                        //nguyenLieu = data.NguyenLieux.FirstOrDefault(x => x.maNguyenLieu.Contains(textBoxMaNguyenLieu.Text));

                        nguyenLieu.ten = textBoxTenNguyenLieu.Text.Trim();
                        nguyenLieu.ghiChu = textBoxGhiChu.Text.Trim();

                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_NGUYEN_LIEU);

                        clearForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã nguyên liệu đã tồn tại vui lòng nhập mã chưa tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        textBoxMaNguyenLieu.Focus();
                        //throw;
                    }

                }
            }
            else
            {
                if (String.IsNullOrEmpty(textBoxMaNguyenLieu.Text.Trim())
                    || String.IsNullOrEmpty(textBoxTenNguyenLieu.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        NguyenLieu nguyenLieu = new NguyenLieu();
                        nguyenLieu.ma = textBoxMaNguyenLieu.Text.Trim();
                        nguyenLieu.ten = textBoxTenNguyenLieu.Text.Trim();
                        nguyenLieu.ghiChu = textBoxGhiChu.Text.Trim();

                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        data.NguyenLieux.Add(nguyenLieu);
                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_NGUYEN_LIEU);

                        clearForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã nguyên liệu đã tồn tại vui lòng nhập mã chưa tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        textBoxMaNguyenLieu.Focus();
                        //throw;
                    }

                }
            }
        }

        private void clearForm()
        {
            isUpdate = false;
            textBoxTenNguyenLieu.Clear();
            textBoxMaNguyenLieu.Clear();
            textBoxGhiChu.Clear();
            textBoxMaNguyenLieu.Focus();
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                var nguyenLieu = (
                            from nl in data.NguyenLieux.ToList()
                            where nl.ma == textBoxMaNguyenLieu.Text
                            select nl
                                  ).SingleOrDefault();

                data.NguyenLieux.Remove(nguyenLieu);
                data.SaveChanges();
                (new Precenter()).getData(dataGridView1, Constance.KEY_NGUYEN_LIEU);
                clearForm();
            }
            //for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            //{
            //    string tempName = "";
            //    try
            //    {
            //        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            //        int selectedrowindex = dataGridView1.SelectedRows[i].Index;
            //        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            //        string maNguyenLieu = Convert.ToString(selectedRow.Cells["maNguyenLieu"].Value);
            //        string tenNguyenLieu = Convert.ToString(selectedRow.Cells["tenNguyenLieu"].Value);
            //        string ghiChu = Convert.ToString(selectedRow.Cells["ghiChu"].Value);
            //        tempName = maNguyenLieu;

            //        var nguyenLieu = new NguyenLieu
            //        {
            //            maNguyenLieu = maNguyenLieu,
            //            tenNguyenLieu = tenNguyenLieu,
            //            ghiChu = ghiChu
            //        };

            //        data.NguyenLieux.Attach(nguyenLieu);
            //        data.Entry(nguyenLieu).State = EntityState.Deleted;
            //        data.SaveChanges();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Xóa " + tempName + " thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //        //throw;
            //    }
            //}
            //(new Precenter()).getData(dataGridView1, Constance.KEY_NGUYEN_LIEU);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                textBoxMaNguyenLieu.Text = dataGridViewRow.Cells[1].Value.ToString();
                textBoxTenNguyenLieu.Text = dataGridViewRow.Cells[2].Value.ToString();
                textBoxGhiChu.Text = dataGridViewRow.Cells[3].Value.ToString();
                toolStripButtonCapNhat.Enabled = true;

                textBoxMaNguyenLieu.ReadOnly = true;
                isUpdate = true;
            }
        }

        void clearData()
        {
            textBoxMaNguyenLieu.Clear();
            textBoxTenNguyenLieu.Clear();
            textBoxGhiChu.Clear();
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            textBoxMaNguyenLieu.ReadOnly = false;
            clearForm();
        }
    }
}
