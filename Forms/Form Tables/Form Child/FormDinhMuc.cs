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
using DevExpress.XtraRichEdit.Import.Html;

namespace QuanLyXiNghiepMay.Forms.Form_Tables.Form_Child
{
    public partial class FormDinhMuc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormDinhMuc()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            QuanLyXiNghiepMay.QuanLyVatTuCuaXiNghiepMayEntities dbContext = new QuanLyXiNghiepMay.QuanLyVatTuCuaXiNghiepMayEntities();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.DinhMucs.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = dbContext.DinhMucs.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.DinhMucs.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.DinhMucs.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Controler.isTextInputValid(textEditSoLuong.Text))
            {
                Controler.messageBoxShow(MyTemplateString.MESSAGE_INPUT_ERROR, MyTemplateString.TITLE_WARNING);
            }
            else
            {
                try
                {
                    addDinhMuc();
                    Precenter.reloadDataSource(this, gridControl1);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(MyTemplateString.MESSAGE_INSERT_ERROR, MyTemplateString.TITLE_WARNING);
                    textEditSoLuong.Focus();
                }
            }
        }

        private void addDinhMuc()
        {
            DinhMuc dinhMuc = new DinhMuc();
            dinhMuc.maSanPham = comboBoxMaSanPham.SelectedValue.ToString();
            dinhMuc.maNguyenLieu = comboBoxMaNguyenLieu.SelectedValue.ToString();
            dinhMuc.donViTinh = comboBoxEditDonViTinh.SelectedText.Trim();
            dinhMuc.soLuong = int.Parse(textEditSoLuong.Text.Trim());
            Precenter.data.DinhMucs.Add(dinhMuc);
            Precenter.data.SaveChanges();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Controler.isTextInputValid(textEditSoLuong.Text))
            {
                Controler.messageBoxShow(MyTemplateString.MESSAGE_INPUT_ERROR, MyTemplateString.TITLE_WARNING);
            }
            else
            {
                try
                {
                    updateDinhMuc();
                    Precenter.reloadDataSource(this, gridControl1);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(MyTemplateString.MESSAGE_UPDATE_ERROR, MyTemplateString.TITLE_WARNING);
                    textEditSoLuong.Focus();
                }
            }
        }

        private void updateDinhMuc()
        {
            DinhMuc dinhMuc = (from temp in Precenter.data.DinhMucs
                               where temp.maSanPham == comboBoxMaSanPham.SelectedValue.ToString() && temp.maNguyenLieu == comboBoxMaNguyenLieu.SelectedValue.ToString()
                               select temp).SingleOrDefault();

            dinhMuc.donViTinh = comboBoxEditDonViTinh.SelectedText.Trim();
            dinhMuc.soLuong = int.Parse(textEditSoLuong.Text.Trim());
            Precenter.data.SaveChanges();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Controler.isMessageBox(MyTemplateString.MESSAGE_DELETE, MyTemplateString.TITLE_WARNING))
            {
                try
                {
                    removeDinhMuc();
                    Precenter.reloadDataSource(this, gridControl1);
                    clearForm();
                }
                catch (Exception)
                {
                    Controler.messageBoxShow(MyTemplateString.PICK_ONE_ROW, MyTemplateString.TITLE_WARNING);
                }
            }
        }

        private void removeDinhMuc()
        {
            var dinhMuc = (
                            from temp in Precenter.data.DinhMucs.ToList()
                            where temp.maSanPham == comboBoxMaSanPham.SelectedValue.ToString()
                            && temp.maNguyenLieu == comboBoxMaNguyenLieu.SelectedValue.ToString()
                            select temp
                                  ).SingleOrDefault();

            Precenter.data.DinhMucs.Remove(dinhMuc);
            Precenter.data.SaveChanges();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Precenter.reloadDataSource(this, gridControl1);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Dispose();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            comboBoxMaSanPham.SelectedIndex = 0;
            comboBoxTenSanPham.SelectedIndex = 0;
            comboBoxMaNguyenLieu.SelectedIndex = 0;
            comboBoxTenNguyenLieu.SelectedIndex = 0;
            textEditSoLuong.Text = "";
            textEditSoLuong.Focus();
        }

        private void comboBoxTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaSanPham.SelectedIndex = comboBoxTenSanPham.SelectedIndex;
        }

        private void comboBoxTenNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaNguyenLieu.SelectedIndex = comboBoxTenNguyenLieu.SelectedIndex;
        }

        private void RibbonFormDinhMuc_Load(object sender, EventArgs e)
        {
            Precenter.loadDataSourceComboBox(comboBoxMaSanPham, Constance.KEY_MA_SAN_PHAM);
            Precenter.loadDataSourceComboBox(comboBoxTenSanPham, Constance.KEY_TEN_SAN_PHAM);

            Precenter.loadDataSourceComboBox(comboBoxMaNguyenLieu, Constance.KEY_MA_NGUYEN_LIEU);
            Precenter.loadDataSourceComboBox(comboBoxTenNguyenLieu, Constance.KEY_TEN_NGUYEN_LIEU);
            clearForm();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int rowHandle = e.RowHandle;
            DinhMuc dinhMuc = (DinhMuc)gridView1.GetRow(e.RowHandle);


            comboBoxMaSanPham.SelectedValue = dinhMuc.SanPham.ma;
            comboBoxTenSanPham.SelectedValue = dinhMuc.SanPham.ten;
            comboBoxMaNguyenLieu.SelectedValue = dinhMuc.NguyenLieu.ma;
            comboBoxTenNguyenLieu.SelectedValue = dinhMuc.NguyenLieu.ten;

            String[] strings = { "Túi", "Cái", "Thùng", "Bao", "Chiếc" };
            int index = Array.IndexOf(strings, dinhMuc.donViTinh);
            comboBoxEditDonViTinh.SelectedIndex = index;

            textEditSoLuong.Text = dinhMuc.soLuong.ToString();
        }
    }
}