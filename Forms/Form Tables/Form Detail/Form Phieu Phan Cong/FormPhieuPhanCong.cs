using QuanLyXiNghiepMay.R;
using System;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.Form_Detail.Form_Phieu_Phan_Cong
{
    public partial class FormPhieuPhanCong : Form
    {
        private bool isUpdate = false;

        public FormPhieuPhanCong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (int.Parse(textBoxSoPhieuPhanCong.Text.Trim()) < 0
                     )
                {
                    MessageBox.Show("Vui lòng đầy đủ tất cả thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        PhieuPhanCong phieuPhanCong = (from t in data.PhieuPhanCongs
                                                       where t.so == textBoxSoPhieuPhanCong.Text.ToString() && t.maPhanXuong == comboBoxMaPhanXuong.SelectedValue.ToString()
                                                       select t).SingleOrDefault();
                        phieuPhanCong.ngayTao = new DateTime(
                            dateTimePickerNgayLapPhieu.Value.Year,
                            dateTimePickerNgayLapPhieu.Value.Month,
                            dateTimePickerNgayLapPhieu.Value.Day);

                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_PHIEU_PHAN_CONG);
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
                if (int.Parse(textBoxSoPhieuPhanCong.Text.Trim()) < 0
                    )
                {
                    MessageBox.Show("Vui lòng đầy đủ tất cả thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        PhieuPhanCong phieuPhanCong = new PhieuPhanCong();
                        phieuPhanCong.so = textBoxSoPhieuPhanCong.Text.Trim();
                        phieuPhanCong.maPhanXuong = comboBoxMaPhanXuong.SelectedValue.ToString();
                        phieuPhanCong.ngayTao = new DateTime(
                            dateTimePickerNgayLapPhieu.Value.Year,
                            dateTimePickerNgayLapPhieu.Value.Month,
                            dateTimePickerNgayLapPhieu.Value.Day);

                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        data.PhieuPhanCongs.Add(phieuPhanCong);
                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_PHIEU_PHAN_CONG);
                        clearForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thông tin đã tồn tại chỉ có thể cập nhật hoặc xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void clearForm()
        {
            isUpdate = false;
            textBoxSoPhieuPhanCong.Focus();

            textBoxSoPhieuPhanCong.Enabled = true;
            comboBoxMaPhanXuong.Enabled = true;
            textBoxSoPhieuPhanCong.Clear();
            dateTimePickerNgayLapPhieu.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                textBoxSoPhieuPhanCong.Text = dataGridViewRow.Cells[1].Value.ToString();
                comboBoxMaPhanXuong.SelectedValue = dataGridViewRow.Cells[2].Value.ToString();
                dateTimePickerNgayLapPhieu.Value = DateTime.ParseExact(dataGridViewRow.Cells[3].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                textBoxSoPhieuPhanCong.Enabled = false;
                comboBoxMaPhanXuong.Enabled = false;
                isUpdate = true;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPhieuPhanCong_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Constance.KEY_PHIEU_PHAN_CONG);
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            comboBoxMaPhanXuong.DataSource = data.PhanXuongs.ToList();
            comboBoxMaPhanXuong.DisplayMember = "tenPhanXuong";
            comboBoxMaPhanXuong.ValueMember = "maPhanXuong";

            dateTimePickerNgayLapPhieu.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayLapPhieu.CustomFormat = "dd/MM/yyyy";
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
                        string soPhieuPhanCong = Convert.ToString(selectedRow.Cells["soPhieuPhanCong"].Value);
                        string maPhanXuong = Convert.ToString(selectedRow.Cells["maPhanXuong"].Value);
                        DateTime ngayLapPhieu =
                        DateTime.ParseExact(selectedRow.Cells["ngayLapPhieu"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);


                        var chiTietPhieuPhanCong = new PhieuPhanCong
                        {
                            so = soPhieuPhanCong,
                            maPhanXuong = maPhanXuong,
                            ngayTao = ngayLapPhieu
                        };

                        data.PhieuPhanCongs.Attach(chiTietPhieuPhanCong);
                        data.Entry(chiTietPhieuPhanCong).State = EntityState.Deleted;
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
            (new Precenter()).getData(dataGridView1, Constance.KEY_PHIEU_PHAN_CONG);
        }
    }
}
