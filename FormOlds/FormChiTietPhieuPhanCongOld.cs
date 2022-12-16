using QuanLyXiNghiepMay.R;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay.Form_Detail.Form_Phieu_Phan_Cong
{
    public partial class FormChiTietPhieuPhanCongOld : Form
    {
        private bool isUpdate = false;

        public FormChiTietPhieuPhanCongOld()
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

            comboBoxSoPhieuPhanCong.Enabled = true;
            comboBoxMaSanPham.Enabled = true;
            textBoxSoLuong.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                comboBoxSoPhieuPhanCong.SelectedValue = dataGridViewRow.Cells[1].Value.ToString();
                comboBoxMaSanPham.SelectedValue = dataGridViewRow.Cells[2].Value.ToString();
                textBoxSoLuong.Text = dataGridViewRow.Cells[3].Value.ToString();

                comboBoxSoPhieuPhanCong.Enabled = false;
                comboBoxMaSanPham.Enabled = false;
                isUpdate = true;
            }
        }

        private void FormChiTietPhieuPhanCong_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Constance.KEY_CHI_TIET_PHIEU_PHAN_CONG);
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            comboBoxMaSanPham.DataSource = data.SanPhams.ToList();
            comboBoxMaSanPham.DisplayMember = "maSanPham";
            comboBoxMaSanPham.ValueMember = "maSanPham";

            comboBoxSoPhieuPhanCong.DataSource = data.PhieuPhanCongs.ToList();
            comboBoxSoPhieuPhanCong.DisplayMember = "soPhieuPhanCong";
            comboBoxSoPhieuPhanCong.ValueMember = "soPhieuPhanCong";
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (int.Parse(textBoxSoLuong.Text.Trim()) < 0
                     )
                {
                    MessageBox.Show("Vui lòng đầy đủ tất cả thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        ChiTietPhieuPhanCong chiTietPhieuPhanCong = (from t in data.ChiTietPhieuPhanCongs
                                                                     where t.soPhieuPhanCong == comboBoxSoPhieuPhanCong.SelectedValue.ToString() && t.maSanPham == comboBoxMaSanPham.SelectedValue.ToString()
                                                                     select t).SingleOrDefault();
                        chiTietPhieuPhanCong.soLuong = int.Parse(textBoxSoLuong.Text.Trim());

                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_CHI_TIET_PHIEU_PHAN_CONG);
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
                if (int.Parse(textBoxSoLuong.Text.Trim()) < 0
                    )
                {
                    MessageBox.Show("Vui lòng đầy đủ tất cả thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    try
                    {
                        ChiTietPhieuPhanCong chiTietPhieuPhanCong = new ChiTietPhieuPhanCong();
                        chiTietPhieuPhanCong.soPhieuPhanCong = comboBoxSoPhieuPhanCong.SelectedValue.ToString();
                        chiTietPhieuPhanCong.maSanPham = comboBoxMaSanPham.SelectedValue.ToString();
                        chiTietPhieuPhanCong.soLuong = int.Parse(textBoxSoLuong.Text.Trim());

                        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                        data.ChiTietPhieuPhanCongs.Add(chiTietPhieuPhanCong);
                        data.SaveChanges();
                        (new Precenter()).getData(dataGridView1, Constance.KEY_CHI_TIET_PHIEU_PHAN_CONG);
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
                        string soPhieuPhanCong = Convert.ToString(selectedRow.Cells["soPhieuPhanCong"].Value);
                        string maSanPham = Convert.ToString(selectedRow.Cells["maSanPham"].Value);
                        string soLuong = Convert.ToString(selectedRow.Cells["soLuong"].Value);

                        var chiTietPhieuPhanCong = new ChiTietPhieuPhanCong
                        {
                            soPhieuPhanCong = soPhieuPhanCong,
                            maSanPham = maSanPham,
                            soLuong = int.Parse(soLuong)
                        };

                        data.ChiTietPhieuPhanCongs.Attach(chiTietPhieuPhanCong);
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
            (new Precenter()).getData(dataGridView1, Constance.KEY_CHI_TIET_PHIEU_PHAN_CONG);
        }
    }
}
