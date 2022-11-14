using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyXiNghiepMay
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

            

            // Load format 
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            int year = dateTimePicker.Value.Year;
            int month = dateTimePicker.Value.Month;
            int day = dateTimePicker.Value.Day;
            loadData(year, month, day);
        }

        private void loadData(int year, int month, int day)
        {
            QuanLyVatTuCuaXiNghiepMayEntities data = new QuanLyVatTuCuaXiNghiepMayEntities();
            this.reportViewer1.RefreshReport();

            reportViewer1.LocalReport.DataSources.Clear();

            //List<BaoCaoPhieuPhanCongTheoNgay_Result> baoCaoPhieuPhanCongTheoNgay_Results = data.BaoCaoPhieuPhanCongTheoNgay(new DateTime(year, month, day)).ToList();

            //ReportDataSource reportDataSource = new ReportDataSource("DataSet1", baoCaoPhieuPhanCongTheoNgay_Results);
            //reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();

        }
        //2022-02-22 00:00:00.000
        // menu tim kiem
        // in danh sach
    }
}
