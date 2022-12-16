namespace QuanLyXiNghiepMay
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baoCaoPhieuPhanCongTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoPhieuPhanCongTheoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // baoCaoPhieuPhanCongTheoNgayBindingSource
            // 
            this.baoCaoPhieuPhanCongTheoNgayBindingSource.DataMember = "BaoCaoPhieuPhanCongTheoNgay";
            // 
            // quanLyVatTuCuaXiNghiepMayDataSet1
            // 
            // 
            // baoCaoPhieuPhanCongTheoNgayTableAdapter
            // 
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyXiNghiepMay.Forms.Features.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(813, 286);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 7);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(133, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(488, 6);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 319);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoPhieuPhanCongTheoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource baoCaoPhieuPhanCongTheoNgayBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonLoad;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}