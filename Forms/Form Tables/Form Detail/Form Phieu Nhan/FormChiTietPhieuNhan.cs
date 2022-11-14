using QuanLyXiNghiepMay.R;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.Form_Detail.Form_Phieu_Nhan
{
    public partial class FormChiTietPhieuNhan : Form
    {
        private bool isUpdate = false;

        public FormChiTietPhieuNhan()
        {
            InitializeComponent();
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            isUpdate = false;
            textBoxSoLuong.Focus();

            textBoxSoLuong.Clear();

            comboBoxSoPhieuNhan.Enabled = true;
            comboBoxMaNguyenLieu.Enabled = true;
        }

        private void FormChiTietPhieuNhan_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Constance.KEY_CHI_TIET_PHIEU_NHAN);
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            comboBoxSoPhieuNhan.DataSource = data.PhieuNhans.ToList();
            comboBoxSoPhieuNhan.DisplayMember = "soPhieuNhan";
            comboBoxSoPhieuNhan.ValueMember = "soPhieuNhan";

            comboBoxMaNguyenLieu.DataSource = data.NguyenLieux.ToList();
            comboBoxMaNguyenLieu.DisplayMember = "tenNguyenLieu";
            comboBoxMaNguyenLieu.ValueMember = "maNguyenLieu";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                comboBoxSoPhieuNhan.SelectedValue = dataGridViewRow.Cells[1].Value.ToString();
                comboBoxMaNguyenLieu.SelectedValue = dataGridViewRow.Cells[2].Value.ToString();
                textBoxSoLuong.Text = dataGridViewRow.Cells[3].Value.ToString();

                isUpdate = true;
                comboBoxSoPhieuNhan.Enabled = false;
                comboBoxSoPhieuNhan.Enabled = false;
            }
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (string.IsNullOrEmpty(textBoxSoLuong.Text.Trim())
                   || int.Parse(textBoxSoLuong.Text.Trim()) <= 0
                   )
                {
                    MessageBox.Show("Vui lòng đầy đủ tất cả thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        ChiTietPhieuNhan chiTietPhieuNhan = (from t in data.ChiTietPhieuNhans
                                                             where t.soPhieuNhan == comboBoxSoPhieuNhan.SelectedValue.ToString() &&
                                                             t.maNguyenLieu == comboBoxMaNguyenLieu.SelectedValue.ToString()
                                                             select t).SingleOrDefault();
                        chiTietPhieuNhan.soLuong = int.Parse(textBoxSoLuong.Text.Trim());

                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_CHI_TIET_PHIEU_NHAN);
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
                if (string.IsNullOrEmpty(textBoxSoLuong.Text.Trim())
                   || int.Parse(textBoxSoLuong.Text.Trim()) <= 0
                   )
                {
                    MessageBox.Show("Vui lòng đầy đủ tất cả thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        ChiTietPhieuNhan chiTietPhieuNhan = new ChiTietPhieuNhan();
                        chiTietPhieuNhan.soPhieuNhan = comboBoxSoPhieuNhan.SelectedValue.ToString();
                        chiTietPhieuNhan.maNguyenLieu = comboBoxMaNguyenLieu.SelectedValue.ToString();
                        chiTietPhieuNhan.soLuong = int.Parse(textBoxSoLuong.Text.Trim());

                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        data.ChiTietPhieuNhans.Add(chiTietPhieuNhan);
                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_CHI_TIET_PHIEU_NHAN);
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

                        string soPhieuNhan = Convert.ToString(selectedRow.Cells["soPhieuNhan"].Value);
                        string maNguyenLieu = Convert.ToString(selectedRow.Cells["maNguyenLieu"].Value);
                        int soLuong = Convert.ToInt32(selectedRow.Cells["soLuong"].Value);

                        var chiTietPhieuNhan = new ChiTietPhieuNhan
                        {
                            soPhieuNhan = soPhieuNhan,
                            maNguyenLieu = maNguyenLieu,
                            soLuong = soLuong
                        };

                        data.ChiTietPhieuNhans.Attach(chiTietPhieuNhan);
                        data.Entry(chiTietPhieuNhan).State = EntityState.Deleted;
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
            (new Precenter()).getData(dataGridView1, Constance.KEY_CHI_TIET_PHIEU_NHAN);
        }
    }
}
