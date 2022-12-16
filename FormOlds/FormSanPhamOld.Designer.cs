namespace QuanLyXiNghiepMay
{
    partial class FormSanPhamOld
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.thêmToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.xóaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dữ liệu sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxTenSanPham);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxMaSanPham);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxGhiChu);
            this.groupBox2.Location = new System.Drawing.Point(11, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 174);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm dữ liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ghi chú";
            // 
            // textBoxTenSanPham
            // 
            this.textBoxTenSanPham.Location = new System.Drawing.Point(103, 47);
            this.textBoxTenSanPham.Name = "textBoxTenSanPham";
            this.textBoxTenSanPham.Size = new System.Drawing.Size(100, 22);
            this.textBoxTenSanPham.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // textBoxMaSanPham
            // 
            this.textBoxMaSanPham.Location = new System.Drawing.Point(103, 19);
            this.textBoxMaSanPham.Name = "textBoxMaSanPham";
            this.textBoxMaSanPham.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaSanPham.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Location = new System.Drawing.Point(103, 75);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(100, 40);
            this.textBoxGhiChu.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(329, 167);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripButton,
            this.xóaToolStripButton,
            this.toolStripSeparator1,
            this.resetToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(572, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // thêmToolStripButton
            // 
            this.thêmToolStripButton.Image = global::QuanLyXiNghiepMay.Properties.Resources.ic_save;
            this.thêmToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.thêmToolStripButton.Name = "thêmToolStripButton";
            this.thêmToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.thêmToolStripButton.Text = "Lưu";
            this.thêmToolStripButton.Click += new System.EventHandler(this.thêmToolStripButton_Click);
            // 
            // xóaToolStripButton
            // 
            this.xóaToolStripButton.Image = global::QuanLyXiNghiepMay.Properties.Resources.ic_remove;
            this.xóaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.xóaToolStripButton.Name = "xóaToolStripButton";
            this.xóaToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.xóaToolStripButton.Text = "Xóa";
            this.xóaToolStripButton.Click += new System.EventHandler(this.xóaToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // resetToolStripButton
            // 
            this.resetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetToolStripButton.Image = global::QuanLyXiNghiepMay.Properties.Resources.ic_refresh;
            this.resetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetToolStripButton.Name = "resetToolStripButton";
            this.resetToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.resetToolStripButton.Text = "Clear";
            this.resetToolStripButton.Click += new System.EventHandler(this.resetToolStripButton_Click);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.groupBox2);
            this.fluentDesignFormContainer1.Controls.Add(this.dataGridView1);
            this.fluentDesignFormContainer1.Controls.Add(this.label1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(572, 272);
            this.fluentDesignFormContainer1.TabIndex = 6;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(572, 0);
            this.fluentDesignFormControl1.TabIndex = 8;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 272);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton thêmToolStripButton;
        private System.Windows.Forms.ToolStripButton xóaToolStripButton;
        private System.Windows.Forms.ToolStripButton resetToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
    }
}