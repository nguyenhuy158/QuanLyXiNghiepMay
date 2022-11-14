using QuanLyXiNghiepMay.R;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.Form_Child
{
    public partial class FormCongDoan : Form
    {
        private bool isUpdate = false;

        public FormCongDoan()
        {
            InitializeComponent();
        }

        private void FormCongDoan_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Constance.KEY_CONG_DOAN);
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            comboBoxMaSanPham.DataSource = data.SanPhams.ToList();
            comboBoxMaSanPham.DisplayMember = "tenSanPham";
            comboBoxMaSanPham.ValueMember = "maSanPham";

            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (numericUpDownSoThuTu.Value <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số thứ tự hợp lệ (> 0)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else if (string.IsNullOrEmpty(textBoxYeuCauKyThuat.Text.Trim())
                    || string.IsNullOrEmpty(textBoxDinhMucTienLuong.Text.Trim())
                    || string.IsNullOrEmpty(textBoxGhiChu.Text.Trim())
                    )
                {
                    MessageBox.Show("Vui lòng đầy đủ tất cả thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    try
                    {
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        String stt = Convert.ToString(Math.Round(numericUpDownSoThuTu.Value, 0));
                        CongDoan congDoan = (from t in data.CongDoans
                                             where t.maSanPham == comboBoxMaSanPham.SelectedValue.ToString() &&
                                             t.soCongDoan == stt
                                             select t).SingleOrDefault();
                        congDoan.yeuCauKyThuat = textBoxYeuCauKyThuat.Text.Trim();
                        congDoan.mucTienLuong = int.Parse(textBoxDinhMucTienLuong.Text.Trim());
                        congDoan.ghiChu = textBoxGhiChu.Text.Trim();

                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_CONG_DOAN);
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
                if (numericUpDownSoThuTu.Value <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số thứ tự hợp lệ (> 0)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else if (string.IsNullOrEmpty(textBoxYeuCauKyThuat.Text.Trim())
                    || string.IsNullOrEmpty(textBoxDinhMucTienLuong.Text.Trim())
                    || string.IsNullOrEmpty(textBoxGhiChu.Text.Trim())
                    )
                {
                    MessageBox.Show("Vui lòng đầy đủ tất cả thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    try
                    {
                        CongDoan congDoan = new CongDoan();
                        congDoan.maSanPham = comboBoxMaSanPham.SelectedValue.ToString();
                        //congDoan.soCongDoan = Convert.ToInt32(Math.Round(numericUpDownSoThuTu.Value, 0));
                        congDoan.yeuCauKyThuat = textBoxYeuCauKyThuat.Text.Trim();
                        congDoan.mucTienLuong = int.Parse(textBoxDinhMucTienLuong.Text.Trim());
                        congDoan.ghiChu = textBoxGhiChu.Text.Trim();
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        data.CongDoans.Add(congDoan);
                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_CONG_DOAN);
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
                        string maSanPham = Convert.ToString(selectedRow.Cells["maSanPham"].Value);
                        string sttCongDoan = Convert.ToString(selectedRow.Cells["sttCongDoan"].Value);
                        string yeuCauKyThuat = Convert.ToString(selectedRow.Cells["yeuCauKyThuat"].Value);
                        string dinhMucTienLuong = Convert.ToString(selectedRow.Cells["dinhMucTienLuong"].Value);
                        string ghiChu = Convert.ToString(selectedRow.Cells["ghiChu"].Value);

                        var congDoan = new CongDoan
                        {
                            maSanPham = maSanPham,
                            //soCongDoan = int.Parse(sttCongDoan),
                            yeuCauKyThuat = yeuCauKyThuat,
                            mucTienLuong = int.Parse(dinhMucTienLuong),
                            ghiChu = ghiChu
                        };

                        data.CongDoans.Attach(congDoan);
                        data.Entry(congDoan).State = EntityState.Deleted;
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
            (new Precenter()).getData(dataGridView1, Constance.KEY_CONG_DOAN);
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            isUpdate = false;
            textBoxYeuCauKyThuat.Focus();

            comboBoxMaSanPham.Enabled = true;
            numericUpDownSoThuTu.Enabled = true;
            textBoxYeuCauKyThuat.Clear();
            textBoxDinhMucTienLuong.Clear();
            textBoxGhiChu.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                comboBoxMaSanPham.SelectedValue = dataGridViewRow.Cells[1].Value.ToString();
                numericUpDownSoThuTu.Value = decimal.Parse(dataGridViewRow.Cells[2].Value.ToString());
                textBoxYeuCauKyThuat.Text = dataGridViewRow.Cells[3].Value.ToString();
                textBoxDinhMucTienLuong.Text = dataGridViewRow.Cells[4].Value.ToString();
                textBoxGhiChu.Text = dataGridViewRow.Cells[5].Value.ToString();


                comboBoxMaSanPham.Enabled = false;
                numericUpDownSoThuTu.Enabled = false;
                isUpdate = true;
            }
        }
    }
}
