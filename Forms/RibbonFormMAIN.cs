using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
using QuanLyXiNghiepMay.Forms.Form_Tables;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Child;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Nhan;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Phan_Cong;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Parent;
using QuanLyXiNghiepMay.R.ControlerForForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXiNghiepMay
{
    public partial class RibbonFormMAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonFormMAIN()
        {
            InitializeComponent();
        }

        private void RibbonFormMAIN_Load(object sender, EventArgs e)
        {
            //printPreviewControl1.
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(XtraFormSanPham));
            //ControlerMain.showForm(this, new XtraFormSanPham());
        }

        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Dispose();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(RibbonFormDinhMuc));
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraReport1 xtraReport1 = new XtraReport1();
            xtraReport1.ShowPreview();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(RibbonFormPhieuNhan)); 
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(XtraForm1));
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(RibbonFormNguyenLieu));
        }

        private void ribbon_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            //ribbon.SelectedPage = ribbon.MergedCategories[0].Pages[0];
            RibbonControl parentRibbonControl = sender as RibbonControl;
            RibbonControl childRibbonControl = e.MergedChild;
            parentRibbonControl.StatusBar.MergeStatusBar(childRibbonControl.StatusBar);
        }

        private void ribbon_UnMerge(object sender, RibbonMergeEventArgs e)
        {
            RibbonControl parentRibbonControl = sender as RibbonControl;
            parentRibbonControl.StatusBar.UnMergeStatusBar();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(RibbonFormCongDoan));
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(RibbonFormPhanXuong));
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(RibbonFormChiTietPhieuNhan));
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(RibbonFormPhieuPhanCong));
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(RibbonFormChiTietPhieuPhanCong));
        }
    }
}