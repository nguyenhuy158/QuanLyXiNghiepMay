using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QuanLyXiNghiepMay.Forms.Features;
using QuanLyXiNghiepMay.Forms.Form_Tables;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Child;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Nhan;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Phan_Cong;
using QuanLyXiNghiepMay.Forms.Form_Tables.Form_Parent;
using QuanLyXiNghiepMay.R;
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
    public partial class FormMAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMAIN()
        {
            InitializeComponent();
        }

        private void RibbonFormMAIN_Load(object sender, EventArgs e)
        {
            //printPreviewControl1.
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(FormSanPham));
            //ControlerMain.showForm(this, new XtraFormSanPham());
        }

        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            if (XtraMessageBox.Show(MyTemplateString.MESSAGE_EXIT, MyTemplateString.TITLE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Dispose();
            }
            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(RibbonFormDinhMuc));
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

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
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlerMain.openForm(this, typeof(FormNguyenLieu));
        }

        private void ribbon_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            RibbonPage indexPage = ribbon.MergedPages[0];
            ribbon.SelectPage(indexPage);
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
            ControlerMain.openForm(this, typeof(FormPhanXuong));
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

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barListItem1_ListItemClick_1(object sender, ListItemClickEventArgs e)
        {
            //phân công theo ngày
            //phân xưởng ký nhận
            //sao kê sản phẩm theo phân xưởng

            switch (e.Index)
            {
                case 0:
                    ReportBaoCaoPhanCongTheoNgay xtraReportBaoCaoPhanCongTheoNgay = new ReportBaoCaoPhanCongTheoNgay();

                    xtraReportBaoCaoPhanCongTheoNgay.ShowPreview();
                    break;
                case 1:
                    ReportPhanXuongKyNhan xtraReportPhanXuongKyNhan = new ReportPhanXuongKyNhan();

                    xtraReportPhanXuongKyNhan.ShowPreview();
                    break;
                case 2:
                    ReportSanPhamSanXuatCuaTungPhanXuong xtraReportSanPhamSanXuatCuaTungPhanXuong = new ReportSanPhamSanXuatCuaTungPhanXuong();

                    xtraReportSanPhamSanXuatCuaTungPhanXuong.ShowPreview();
                    break;
                default:
                    break;
            }
        }

       
        private void backstageViewTabItem2_SelectedChanged(object sender, BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem4_SelectedChanged(object sender, BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewButtonItem4_ItemClick(object sender, BackstageViewItemEventArgs e)
        {
            // close current form and open new form
            this.Dispose();
            var form = new FormLogin();
            form.Show();
        }
    }
}