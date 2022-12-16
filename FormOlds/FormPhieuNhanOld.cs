using QuanLyXiNghiepMay.R;
using System;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.Form_Detail.Form_Phieu_Nhan
{
    public partial class FormPhieuNhanOld : Form
    {
        private bool isUpdate = false;

        public FormPhieuNhanOld()
        {
            InitializeComponent();
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (string.IsNullOrEmpty(textBoxSoPhieuNhan.Text) ||
               string.IsNullOrEmpty(textBoxTenNguoiNhan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    try
                    {
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        PhieuNhan phieuNhanNguyenLieu = (from t in data.PhieuNhans
                                                                   where t.so == textBoxSoPhieuNhan.Text.Trim()
                                                                   select t).SingleOrDefault();
                        phieuNhanNguyenLieu.ngayTao = new DateTime(
                            dateTimePickerNgayLapPhieu.Value.Year,
                            dateTimePickerNgayLapPhieu.Value.Month,
                            dateTimePickerNgayLapPhieu.Value.Day);
                        phieuNhanNguyenLieu.tenNguoiNhan = textBoxTenNguoiNhan.Text.Trim();

                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_PHIEU_NHAN);
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
                if (string.IsNullOrEmpty(textBoxSoPhieuNhan.Text) ||
               string.IsNullOrEmpty(textBoxTenNguoiNhan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    try
                    {
                        PhieuNhan phieuNhanNguyenLieu = new PhieuNhan();
                        phieuNhanNguyenLieu.so = textBoxSoPhieuNhan.Text.Trim();
                        phieuNhanNguyenLieu.ngayTao = new DateTime(
                            dateTimePickerNgayLapPhieu.Value.Year,
                            dateTimePickerNgayLapPhieu.Value.Month,
                            dateTimePickerNgayLapPhieu.Value.Day);
                        phieuNhanNguyenLieu.tenNguoiNhan = textBoxTenNguoiNhan.Text.Trim();
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        data.PhieuNhans.Add(phieuNhanNguyenLieu);
                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_PHIEU_NHAN);
                        clearForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thông tin đã tồn tại chỉ có thể cập nhật hoặc xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void FormPhieuNhan_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Constance.KEY_PHIEU_NHAN);
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            dateTimePickerNgayLapPhieu.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayLapPhieu.CustomFormat = "dd/MM/yyyy";
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            isUpdate = false;
            textBoxSoPhieuNhan.Focus();

            textBoxSoPhieuNhan.Clear();
            textBoxTenNguoiNhan.Clear();
            dateTimePickerNgayLapPhieu.Value = DateTime.Now;

            textBoxSoPhieuNhan.ReadOnly = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                textBoxSoPhieuNhan.Text = dataGridViewRow.Cells[1].Value.ToString();
                dateTimePickerNgayLapPhieu.Value = DateTime.ParseExact(dataGridViewRow.Cells[2].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                textBoxTenNguoiNhan.Text = dataGridViewRow.Cells[3].Value.ToString();

                isUpdate = true;
                textBoxSoPhieuNhan.ReadOnly = true;
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
                        DateTime ngayLapPhieu = DateTime.ParseExact(selectedRow.Cells["ngayLapPhieu"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        string tenNguoiNhan = Convert.ToString(selectedRow.Cells["tenNguoiNhan"].Value);

                        var phieuNhanNguyenLieu = new PhieuNhan
                        {
                            so = soPhieuNhan,
                            ngayTao = ngayLapPhieu,
                            tenNguoiNhan = tenNguoiNhan,
                        };

                        data.PhieuNhans.Attach(phieuNhanNguyenLieu);
                        data.Entry(phieuNhanNguyenLieu).State = EntityState.Deleted;
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
            (new Precenter()).getData(dataGridView1, Constance.KEY_PHIEU_NHAN);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
