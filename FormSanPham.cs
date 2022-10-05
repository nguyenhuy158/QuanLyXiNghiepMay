using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Precenter.KEY_SAN_PHAM);

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMaSanPham.Text.Trim())
                || String.IsNullOrEmpty(textBoxTenSanPham.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ mã sản phẩm và tên sản phẩm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    SanPham sanPham = new SanPham();
                    sanPham.maSanPham = textBoxMaSanPham.Text.Trim();
                    sanPham.tenSanPham = textBoxTenSanPham.Text.Trim();
                    sanPham.ghiChu = textBoxGhiChu.Text.Trim();
                    QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                    data.SanPhams.Add(sanPham);
                    data.SaveChanges();
                    (new Precenter()).getData(dataGridView1, Precenter.KEY_SAN_PHAM);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại vui lòng nhập mã chưa tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    textBoxMaSanPham.Focus();
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
                    string maSanPham = Convert.ToString(selectedRow.Cells["maSanPham"].Value);
                    string tenSanPham = Convert.ToString(selectedRow.Cells["tenSanPham"].Value);
                    string ghiChu = Convert.ToString(selectedRow.Cells["ghiChu"].Value);
                    tempName = maSanPham;

                    var sanPham = new SanPham
                    {
                        maSanPham = maSanPham,
                        tenSanPham = tenSanPham,
                        ghiChu = ghiChu
                    };

                    data.SanPhams.Attach(sanPham);
                    data.Entry(sanPham).State = EntityState.Deleted;
                    data.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa " + tempName + " thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    //throw;
                }
            }
            (new Precenter()).getData(dataGridView1, Precenter.KEY_SAN_PHAM);
        }
    }
}
