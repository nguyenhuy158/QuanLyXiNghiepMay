using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraRichEdit.Commands;
using QuanLyXiNghiepMay.R;

namespace QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Phan_Cong
{
    public partial class RibbonFormPhieuPhanCong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonFormPhieuPhanCong()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            QuanLyXiNghiepMay.QuanLyVatTuCuaXiNghiepMayEntities dbContext = new QuanLyXiNghiepMay.QuanLyVatTuCuaXiNghiepMayEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.PhieuPhanCongs.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.PhieuPhanCongs.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Dispose();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Precenter.reloadDataSource(this, gridControl1);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            String ma = Precenter.getMaPhieuPhanCong();
            textEditSoPhieuPhanCong.Text = ma;
            dateEditNgayTao.EditValue = DateTime.Now;
        }

        private void updatePhanCong()
        {
            PhieuPhanCong phanCong = (from t in Precenter.data.PhieuPhanCongs
                               where t.so == textEditSoPhieuPhanCong.Text
                               select t).SingleOrDefault();

            phanCong.ngayTao = (DateTime)dateEditNgayTao.EditValue;
            Precenter.data.SaveChanges();
        }
        private void addPhanCong()
        {
            PhieuPhanCong phanCong = new PhieuPhanCong();
            phanCong.so = textEditSoPhieuPhanCong.Text;
            phanCong.maPhanXuong = comboBoxMaPhanXuong.SelectedValue.ToString();
            phanCong.ngayTao = (DateTime)dateEditNgayTao.EditValue;
            Precenter.data.PhieuPhanCongs.Add(phanCong);
            Precenter.data.SaveChanges();
        }

        private void removePhanCong()
        {
            var phanCong = (
                            from sp in Precenter.data.PhieuPhanCongs.ToList()
                            where sp.so == textEditSoPhieuPhanCong.Text
                            select sp
                                  ).SingleOrDefault();

            Precenter.data.PhieuPhanCongs.Remove(phanCong);
            Precenter.data.SaveChanges();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Controler.isMessageBox(MyTemplateString.MESSAGE_DELETE, MyTemplateString.TITLE_WARNING))
            {
                try
                {
                    removePhanCong();
                    Precenter.reloadDataSource(this, gridControl1);
                    clearForm();
                }
                catch (Exception)
                {
                    if (textEditSoPhieuPhanCong.Text == Precenter.getMaSanPham())
                    {
                        Controler.messageBoxShow(MyTemplateString.PICK_ONE_ROW, MyTemplateString.TITLE_WARNING);
                    }
                    else
                    {
                        Controler.messageBoxShow(MyTemplateString.MESSAGE_DELETE_ERROR, MyTemplateString.TITLE_WARNING);
                    }
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Controler.isTextInputValid(dateEditNgayTao.EditValue.ToString()))
            {
                Controler.messageBoxShow(MyTemplateString.MESSAGE_INPUT_ERROR, MyTemplateString.TITLE_WARNING);
            }
            else
            {
                try
                {
                    updatePhanCong();
                    Precenter.reloadDataSource(this, gridControl1);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(MyTemplateString.MESSAGE_UPDATE_ERROR, MyTemplateString.TITLE_WARNING);
                    dateEditNgayTao.Focus();
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Controler.isTextInputValid(dateEditNgayTao.EditValue.ToString()))
            {
                Controler.messageBoxShow(MyTemplateString.MESSAGE_INPUT_ERROR, MyTemplateString.TITLE_WARNING);
            }
            else
            {
                try
                {
                    addPhanCong();
                    Precenter.reloadDataSource(this, gridControl1);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(MyTemplateString.MESSAGE_INSERT_ERROR, MyTemplateString.TITLE_WARNING);
                    dateEditNgayTao.Focus();
                }
            }
        }

        private void gridView11_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int rowHandle = e.RowHandle;
            PhieuPhanCong phanCong = (PhieuPhanCong)gridView1.GetRow(e.RowHandle);


            textEditSoPhieuPhanCong.Text = phanCong.so;
            comboBoxMaPhanXuong.SelectedValue = phanCong.maPhanXuong;
            comboBoxTenPhanXuong.SelectedValue = phanCong.PhanXuong.ten;
            dateEditNgayTao.EditValue = phanCong.ngayTao;
        }

        private void RibbonFormPhieuPhanCong_Load(object sender, EventArgs e)
        {
            Precenter.loadDataSourceComboBox(comboBoxMaPhanXuong, Constance.KEY_MA_PHAN_XUONG);
            Precenter.loadDataSourceComboBox(comboBoxTenPhanXuong, Constance.KEY_TEN_PHAN_XUONG);
            clearForm();
        }

        private void comboBoxTenPhanXuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaPhanXuong.SelectedIndex = comboBoxTenPhanXuong.SelectedIndex;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}