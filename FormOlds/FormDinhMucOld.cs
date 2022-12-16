using QuanLyXiNghiepMay.R;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormDinhMucOld : Form
    {
        private bool isUpdate = false;

        public FormDinhMucOld()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormDinhMuc_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Constance.KEY_DINH_MUC);
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            comboBoxMaSanPham.DataSource = data.SanPhams.ToList();
            comboBoxMaSanPham.DisplayMember = "tenSanPham";
            comboBoxMaSanPham.ValueMember = "maSanPham";

            comboBoxMaNguyenLieu.DataSource = data.NguyenLieux.ToList();
            comboBoxMaNguyenLieu.DisplayMember = "tenNguyenLieu";
            comboBoxMaNguyenLieu.ValueMember = "maNguyenLieu";

            comboBoxDonViTinh.SelectedIndex = 0;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (string.IsNullOrEmpty(textBoxSoLuong.Text) || int.Parse(textBoxSoLuong.Text) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ (> 0)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    try
                    {
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        DinhMuc dinhMuc = (from t in data.DinhMucs
                                           where t.maSanPham == comboBoxMaSanPham.SelectedValue.ToString() &&
                                           t.maNguyenLieu == comboBoxMaNguyenLieu.SelectedValue.ToString()
                                           select t).SingleOrDefault();
                        dinhMuc.donViTinh = comboBoxDonViTinh.Text.Trim();
                        dinhMuc.soLuong = int.Parse(textBoxSoLuong.Text.Trim());

                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_DINH_MUC);
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
                if (string.IsNullOrEmpty(textBoxSoLuong.Text) || int.Parse(textBoxSoLuong.Text) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ (> 0)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    try
                    {
                        DinhMuc dinhMuc = new DinhMuc();
                        dinhMuc.maSanPham = comboBoxMaSanPham.SelectedValue.ToString();
                        dinhMuc.maNguyenLieu = comboBoxMaNguyenLieu.SelectedValue.ToString();
                        dinhMuc.donViTinh = comboBoxDonViTinh.Text.Trim();
                        dinhMuc.soLuong = int.Parse(textBoxSoLuong.Text.Trim());
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        data.DinhMucs.Add(dinhMuc);
                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_DINH_MUC);
                        clearForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thông tin đã tồn tại chỉ có thể cập nhật hoặc xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    try
                    {
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        int selectedrowindex = dataGridView1.SelectedRows[i].Index;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                        string maNguyenLieu = Convert.ToString(selectedRow.Cells["maNguyenLieu"].Value);
                        string maSanPham = Convert.ToString(selectedRow.Cells["maSanPham"].Value);
                        string donViTinh = Convert.ToString(selectedRow.Cells["donViTinh"].Value);
                        string soLuong = Convert.ToString(selectedRow.Cells["soLuong"].Value);

                        var dinhMuc = new DinhMuc
                        {
                            maNguyenLieu = maNguyenLieu,
                            maSanPham = maSanPham,
                            donViTinh = donViTinh,
                            soLuong = int.Parse(soLuong)
                        };

                        data.DinhMucs.Attach(dinhMuc);
                        data.Entry(dinhMuc).State = EntityState.Deleted;
                        data.SaveChanges();
                        clearForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        //throw;
                    }
                }
            }
            (new Precenter()).getData(dataGridView1, Constance.KEY_DINH_MUC);
        }

        private void textBoxSoLuong_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxSoLuong_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                comboBoxMaNguyenLieu.SelectedValue = dataGridViewRow.Cells[1].Value.ToString();
                comboBoxMaSanPham.SelectedValue = dataGridViewRow.Cells[2].Value.ToString();
                comboBoxDonViTinh.SelectedValue = dataGridViewRow.Cells[5].Value.ToString();

                textBoxSoLuong.Text = dataGridViewRow.Cells[6].Value.ToString();
                isUpdate = true;

                comboBoxMaNguyenLieu.Enabled = false;
                comboBoxMaSanPham.Enabled = false;
                //comboBoxDonViTinh.Enabled = false;
            }
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            isUpdate = false;
            comboBoxMaNguyenLieu.Enabled = true;
            comboBoxMaSanPham.Enabled = true;
            //comboBoxDonViTinh.Enabled = true;
            textBoxSoLuong.Focus();
            comboBoxMaNguyenLieu.SelectedIndex = 0;
            comboBoxMaSanPham.SelectedIndex = 0;
            comboBoxDonViTinh.SelectedIndex = 0;
            textBoxSoLuong.Clear();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
