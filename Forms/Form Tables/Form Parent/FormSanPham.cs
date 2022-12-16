using QuanLyXiNghiepMay.R;
using QuanLyXiNghiepMay.R.ControlerForForm;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class FormSanPham : DevExpress.XtraEditors.XtraForm
    {
        private bool isUpdate = false;
        QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();

        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            Controler.loadDataSource(dataGridView1, Constance.KEY_SAN_PHAM);
        }

        private void thêmToolStripButton_Click(object sender, EventArgs e)
        {

            if (!Controler.isTextInputValid(textBoxMaSanPham.Text)
                || !Controler.isTextInputValid(textBoxTenSanPham.Text))
            {
                Controler.messageBoxShow(MyTemplateString.MESSAGE_INPUT_ERROR, MyTemplateString.TITLE_WARNING);
            }
            else
            {
                try
                {
                    addOrUpdate();
                    Controler.loadDataSource(dataGridView1, Constance.KEY_SAN_PHAM);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(MyTemplateString.MESSAGE_INSERT_ERROR, MyTemplateString.TITLE_WARNING);
                    textBoxMaSanPham.Focus();
                }
            }
        }

        private void addOrUpdate()
        {
            if (isUpdate)
            {
                SanPham sanPham = (from t in data.SanPhams
                                   where t.ma == textBoxMaSanPham.Text
                                   select t).SingleOrDefault();

                sanPham.ten = textBoxTenSanPham.Text.Trim();
                sanPham.ghiChu = textBoxGhiChu.Text.Trim();
                data.SaveChanges();
            }
            else
            {
                SanPham sanPham = new SanPham();
                sanPham.ma = textBoxMaSanPham.Text.Trim();
                sanPham.ten = textBoxTenSanPham.Text.Trim();
                sanPham.ghiChu = textBoxGhiChu.Text.Trim();
                data.SanPhams.Add(sanPham);
                data.SaveChanges();
            }
        }

        private void xóaToolStripButton_Click(object sender, EventArgs e)
        {
            if (Controler.isMessageBox(MyTemplateString.MESSAGE_DELETE, MyTemplateString.TITLE_WARNING))
            {
                try
                {
                    var sanPham = (
                            from sp in data.SanPhams.ToList()
                            where sp.ten == textBoxMaSanPham.Text
                            select sp
                                  ).SingleOrDefault();

                    data.SanPhams.Remove(sanPham);
                    data.SaveChanges();
                    Controler.loadDataSource(dataGridView1, Constance.KEY_SAN_PHAM);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(MyTemplateString.MESSAGE_DELETE_ERROR, MyTemplateString.TITLE_WARNING);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = e.RowIndex;
            if (currentRow >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[currentRow];

                textBoxMaSanPham.Text = dataGridViewRow.Cells[1].Value.ToString();
                textBoxTenSanPham.Text = dataGridViewRow.Cells[2].Value.ToString();
                textBoxGhiChu.Text = dataGridViewRow.Cells[3].Value.ToString();

                textBoxMaSanPham.ReadOnly = true;
                isUpdate = true;
            }
        }

        private void resetToolStripButton_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            textBoxMaSanPham.ReadOnly = false;
            isUpdate = false;
            textBoxMaSanPham.Focus();
            textBoxMaSanPham.Clear();
            textBoxTenSanPham.Clear();
            textBoxGhiChu.Clear();
        }
    }
}
