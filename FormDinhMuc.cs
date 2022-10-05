using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormDinhMuc : Form
    {
        public FormDinhMuc()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormDinhMuc_Load(object sender, EventArgs e)
        {
            (new Precenter()).getData(dataGridView1, Precenter.KEY_DINH_MUC);
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            comboBoxMaSanPham.DataSource = data.SanPhams.ToList();
            comboBoxMaSanPham.DisplayMember = "tenSanPham";
            comboBoxMaSanPham.ValueMember = "maSanPham";

            comboBoxMaNguyenLieu.DataSource = data.NguyenLieux.ToList();
            comboBoxMaNguyenLieu.DisplayMember = "tenNguyenLieu";
            comboBoxMaNguyenLieu.ValueMember = "maNguyenLieu";

            comboBoxDonViTinh.SelectedIndex = 0;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
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
                    dinhMuc.maSanPham = comboBoxMaSanPham.Text.Trim();
                    dinhMuc.maNguyenLieu = comboBoxMaNguyenLieu.Text.Trim();
                    dinhMuc.donViTinh = comboBoxDonViTinh.Text.Trim();
                    dinhMuc.soLuong = int.Parse(textBoxSoLuong.Text.Trim());
                    QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
                    data.DinhMucs.Add(dinhMuc);
                    data.SaveChanges();
                    (new Precenter()).getData(dataGridView1, Precenter.KEY_DINH_MUC);
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông tin đã tồn tại chỉ có thể cập nhật hoặc xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
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
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    //throw;
                }
            }
            (new Precenter()).getData(dataGridView1, Precenter.KEY_DINH_MUC);
        }
    }
}
