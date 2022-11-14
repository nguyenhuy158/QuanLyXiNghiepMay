using QuanLyXiNghiepMay.R;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.Form_Parent
{
    public partial class FormPhanXuong : Form
    {
        private bool isUpdate = false;

        public FormPhanXuong()
        {
            InitializeComponent();
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa " + textBoxTenPhanXuong.Text, "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                var phanXuong = (
                            from px in data.PhanXuongs.ToList()
                            where px.ma == textBoxMaPhanXuong.Text
                            select px
                                  ).SingleOrDefault();

                data.PhanXuongs.Remove(phanXuong);
                data.SaveChanges();
                (new Precenter()).getData(dataGridView1, Constance.KEY_PHAN_XUONG);
                clearForm();
            }
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (String.IsNullOrEmpty(textBoxMaPhanXuong.Text.Trim()) ||
                String.IsNullOrEmpty(textBoxTenPhanXuong.Text.Trim()) ||
                String.IsNullOrEmpty(textBoxDiaChi.Text.Trim()) ||
                String.IsNullOrEmpty(textBoxSoDienThoai.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {

                    try
                    {
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        PhanXuong phanXuong = (from t in data.PhanXuongs
                                               where t.ma == textBoxMaPhanXuong.Text
                                               select t).SingleOrDefault();
                        phanXuong.ten = textBoxTenPhanXuong.Text.Trim();
                        phanXuong.diaChi = textBoxDiaChi.Text.Trim();
                        phanXuong.sdt = textBoxSoDienThoai.Text.Trim();

                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_PHAN_XUONG);
                        clearForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thông tin đã tồn tại chỉ có thể cập nhật hoặc xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(textBoxMaPhanXuong.Text.Trim()) ||
                String.IsNullOrEmpty(textBoxTenPhanXuong.Text.Trim()) ||
                String.IsNullOrEmpty(textBoxDiaChi.Text.Trim()) ||
                String.IsNullOrEmpty(textBoxSoDienThoai.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {

                    try
                    {
                        PhanXuong phanXuong = new PhanXuong();
                        phanXuong.ma = textBoxMaPhanXuong.Text.Trim();
                        phanXuong.ten = textBoxTenPhanXuong.Text.Trim();
                        phanXuong.diaChi = textBoxDiaChi.Text.Trim();
                        phanXuong.sdt = textBoxSoDienThoai.Text.Trim();
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        data.PhanXuongs.Add(phanXuong);
                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_PHAN_XUONG);
                        clearForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thông tin đã tồn tại chỉ có thể cập nhật hoặc xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void toolStripButtonCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void FormPhanXuong_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Constance.KEY_PHAN_XUONG);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                textBoxMaPhanXuong.Text = dataGridViewRow.Cells[1].Value.ToString();
                textBoxTenPhanXuong.Text = dataGridViewRow.Cells[2].Value.ToString();
                textBoxDiaChi.Text = dataGridViewRow.Cells[3].Value.ToString();
                textBoxSoDienThoai.Text = dataGridViewRow.Cells[4].Value.ToString();

                textBoxMaPhanXuong.ReadOnly = true;
                isUpdate = true;
            }
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
                string maPhanXuong = Convert.ToString(selectedRow.Cells["maPhanXuong"].Value);
                string tenPhanXuong = Convert.ToString(selectedRow.Cells["tenPhanXuong"].Value);
                string diaChi = Convert.ToString(selectedRow.Cells["diaChi"].Value);
                string soDienThoai = Convert.ToString(selectedRow.Cells["soDienThoai"].Value);

                textBoxMaPhanXuong.Text = maPhanXuong;
                textBoxTenPhanXuong.Text = tenPhanXuong;
                textBoxDiaChi.Text = diaChi;
                textBoxSoDienThoai.Text = soDienThoai;
            }
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            textBoxMaPhanXuong.ReadOnly = false;
            isUpdate = false;
            textBoxMaPhanXuong.Focus();
            textBoxMaPhanXuong.Clear();
            textBoxTenPhanXuong.Clear();
            textBoxDiaChi.Clear();
            textBoxSoDienThoai.Clear();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
