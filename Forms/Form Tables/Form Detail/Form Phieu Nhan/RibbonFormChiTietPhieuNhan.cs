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
using QuanLyXiNghiepMay.R;

namespace QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Nhan
{
    public partial class RibbonFormChiTietPhieuNhan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonFormChiTietPhieuNhan()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            QuanLyXiNghiepMay.QuanLyVatTuCuaXiNghiepMayEntities dbContext = new QuanLyXiNghiepMay.QuanLyVatTuCuaXiNghiepMayEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.ChiTietPhieuNhans.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl11.DataSource = dbContext.ChiTietPhieuNhans.Local.ToBindingList();
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
            textEditSoLuong.Text = "";
            textEditSoLuong.Focus();
        }

        private void removeChiTietPhieuNhan()
        {
            var chiTietPhieuNhan = (
                            from sp in Precenter.data.ChiTietPhieuNhans.ToList()
                            where sp.soPhieuNhan == comboBoxSoPhieu.SelectedValue.ToString() && sp.maNguyenLieu == comboBoxMaNguyenLieu.SelectedValue.ToString()
                            select sp
                                  ).SingleOrDefault();

            Precenter.data.ChiTietPhieuNhans.Remove(chiTietPhieuNhan);
            Precenter.data.SaveChanges();
        }
        private void updateChiTietPhieuNhan()
        {
            ChiTietPhieuNhan chiTietPhieuNhan = (from sp in Precenter.data.ChiTietPhieuNhans
                                                 where sp.soPhieuNhan == comboBoxSoPhieu.SelectedValue.ToString() && sp.maNguyenLieu == comboBoxMaNguyenLieu.SelectedValue.ToString()
                                                 select sp).SingleOrDefault();

            chiTietPhieuNhan.soLuong = int.Parse(textEditSoLuong.Text.ToString());
            Precenter.data.SaveChanges();
        }
        private void addChiTietPhieuNhan()
        {
            ChiTietPhieuNhan chiTietPhieuNhan = new ChiTietPhieuNhan();
            chiTietPhieuNhan.soPhieuNhan = comboBoxSoPhieu.SelectedValue.ToString();
            chiTietPhieuNhan.maNguyenLieu = comboBoxMaNguyenLieu.SelectedValue.ToString();
            chiTietPhieuNhan.soLuong = int.Parse(textEditSoLuong.Text.ToString());
            Precenter.data.ChiTietPhieuNhans.Add(chiTietPhieuNhan);
            Precenter.data.SaveChanges();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Controler.isMessageBox(TemplateString.MESSAGE_DELETE, TemplateString.TITLE_WARNING))
            {
                try
                {
                    removeChiTietPhieuNhan();
                    Precenter.reloadDataSource(this, gridControl11);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(TemplateString.PICK_ONE_ROW, TemplateString.TITLE_WARNING);
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Controler.isTextInputValid(textEditSoLuong.Text.ToString()))
            {
                Controler.messageBoxShow(TemplateString.MESSAGE_INPUT_ERROR, TemplateString.TITLE_WARNING);
            }
            else
            {
                try
                {
                    updateChiTietPhieuNhan();
                    Precenter.reloadDataSource(this, gridControl11);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(TemplateString.MESSAGE_UPDATE_ERROR, TemplateString.TITLE_WARNING);
                    textEditSoLuong.Focus();
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Controler.isTextInputValid(textEditSoLuong.Text.ToString()))
            {
                Controler.messageBoxShow(TemplateString.MESSAGE_INPUT_ERROR, TemplateString.TITLE_WARNING);
            }
            else
            {
                try
                {
                    addChiTietPhieuNhan();
                    Precenter.reloadDataSource(this, gridControl11);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(TemplateString.MESSAGE_INSERT_ERROR, TemplateString.TITLE_WARNING);
                    textEditSoLuong.Focus();
                }
            }
        }

        private void gridView11_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int rowHandle = e.RowHandle;
            ChiTietPhieuNhan chiTietPhieuNhan = (ChiTietPhieuNhan)gridView11.GetRow(e.RowHandle);


            comboBoxSoPhieu.SelectedValue = chiTietPhieuNhan.soPhieuNhan;
            comboBoxMaNguyenLieu.SelectedValue = chiTietPhieuNhan.maNguyenLieu;
            comboBoxTenNguyenLieu.SelectedValue = chiTietPhieuNhan.NguyenLieu.ten;
            textEditSoLuong.Text = chiTietPhieuNhan.soLuong.ToString();
        }

        private void comboBoxTenNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaNguyenLieu.SelectedIndex = comboBoxTenNguyenLieu.SelectedIndex;
        }

        private void RibbonFormChiTietPhieuNhan_Load(object sender, EventArgs e)
        {
            Precenter.loadDataSourceComboBox(comboBoxSoPhieu, Constance.KEY_SO_PHIEU_NHAN);
            Precenter.loadDataSourceComboBox(comboBoxMaNguyenLieu, Constance.KEY_MA_NGUYEN_LIEU);
            Precenter.loadDataSourceComboBox(comboBoxTenNguyenLieu, Constance.KEY_TEN_NGUYEN_LIEU);
            clearForm();
        }
    }
}