﻿using DevExpress.XtraBars;
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
                gridControl11.DataSource = dbContext.PhieuPhanCongs.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Dispose();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Precenter.reloadDataSource(this, gridControl11);
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

        private void updateSanPham()
        {
            SanPham sanPham = (from t in Precenter.data.SanPhams
                               where t.ma == textEditMaSanPham.Text
                               select t).SingleOrDefault();

            sanPham.ten = textEditTenSanPham.Text.Trim();
            sanPham.ghiChu = textEditGhiChu.Text.Trim();
            Precenter.data.SaveChanges();
        }
        private void addSanPham()
        {
            SanPham sanPham = new SanPham();
            sanPham.ma = textEditMaSanPham.Text.Trim();
            sanPham.ten = textEditTenSanPham.Text.Trim();
            sanPham.ghiChu = textEditGhiChu.Text.Trim();
            Precenter.data.SanPhams.Add(sanPham);
            Precenter.data.SaveChanges();
        }

        private void removeSanPham()
        {
            var sanPham = (
                            from sp in Precenter.data.SanPhams.ToList()
                            where sp.ma == textEditMaSanPham.Text
                            select sp
                                  ).SingleOrDefault();

            Precenter.data.SanPhams.Remove(sanPham);
            Precenter.data.SaveChanges();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Controler.isMessageBox(TemplateString.MESSAGE_DELETE, TemplateString.TITLE_WARNING))
            {
                try
                {
                    removeSanPham();
                    Precenter.reloadDataSource(this, gridControl11);
                    clearForm();
                }
                catch (Exception)
                {
                    if (textEditSoPhieuPhanCong.Text == Precenter.getMaSanPham())
                    {
                        Controler.messageBoxShow(TemplateString.PICK_ONE_ROW, TemplateString.TITLE_WARNING);
                    }
                    else
                    {
                        Controler.messageBoxShow(TemplateString.MESSAGE_DELETE_ERROR, TemplateString.TITLE_WARNING);
                    }
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Controler.isTextInputValid(dateEditNgayTao.EditValue.ToString()))
            {
                Controler.messageBoxShow(TemplateString.MESSAGE_INPUT_ERROR, TemplateString.TITLE_WARNING);
            }
            else
            {
                try
                {
                    updateSanPham();
                    Precenter.reloadDataSource(this, gridControl11);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(TemplateString.MESSAGE_UPDATE_ERROR, TemplateString.TITLE_WARNING);
                    dateEditNgayTao.Focus();
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Controler.isTextInputValid(dateEditNgayTao.EditValue.ToString()))
            {
                Controler.messageBoxShow(TemplateString.MESSAGE_INPUT_ERROR, TemplateString.TITLE_WARNING);
            }
            else
            {
                try
                {
                    addSanPham();
                    Precenter.reloadDataSource(this, gridControl11);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(TemplateString.MESSAGE_INSERT_ERROR, TemplateString.TITLE_WARNING);
                    dateEditNgayTao.Focus();
                }
            }
        }

        private void gridView11_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int rowHandle = e.RowHandle;
            SanPham sanPham = (SanPham)gridView11.GetRow(e.RowHandle);


            textEditSoPhieuPhanCong.Text= sanPham.ma;
            textEditTenSanPham.Text = sanPham.ten;
            textEditGhiChu.Text = sanPham.ghiChu;
        }
    }
}