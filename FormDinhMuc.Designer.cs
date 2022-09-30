namespace QuanLyXiNghiepMay
{
    partial class FormDinhMuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.comboBoxMaNguyenLieu = new System.Windows.Forms.ComboBox();
            this.comboBoxMaSanPham = new System.Windows.Forms.ComboBox();
            this.comboBoxDonViTinh = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dữ liệu sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxDonViTinh);
            this.groupBox2.Controls.Add(this.comboBoxMaSanPham);
            this.groupBox2.Controls.Add(this.comboBoxMaNguyenLieu);
            this.groupBox2.Controls.Add(this.buttonThem);
            this.groupBox2.Controls.Add(this.textBoxSoLuong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 142);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm dữ liệu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(258, 18);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nguyên Liệu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(584, 163);
            this.dataGridView1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(109, 98);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(121, 20);
            this.textBoxSoLuong.TabIndex = 3;
            // 
            // comboBoxMaNguyenLieu
            // 
            this.comboBoxMaNguyenLieu.FormattingEnabled = true;
            this.comboBoxMaNguyenLieu.Location = new System.Drawing.Point(109, 20);
            this.comboBoxMaNguyenLieu.Name = "comboBoxMaNguyenLieu";
            this.comboBoxMaNguyenLieu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaNguyenLieu.TabIndex = 5;
            // 
            // comboBoxMaSanPham
            // 
            this.comboBoxMaSanPham.FormattingEnabled = true;
            this.comboBoxMaSanPham.Location = new System.Drawing.Point(109, 46);
            this.comboBoxMaSanPham.Name = "comboBoxMaSanPham";
            this.comboBoxMaSanPham.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaSanPham.TabIndex = 5;
            // 
            // comboBoxDonViTinh
            // 
            this.comboBoxDonViTinh.FormattingEnabled = true;
            this.comboBoxDonViTinh.Items.AddRange(new object[] {
            "Cái",
            "Thùng",
            "Bao"});
            this.comboBoxDonViTinh.Location = new System.Drawing.Point(109, 72);
            this.comboBoxDonViTinh.Name = "comboBoxDonViTinh";
            this.comboBoxDonViTinh.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDonViTinh.TabIndex = 6;
            // 
            // FormDinhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDinhMuc";
            this.Text = "FormDinhMuc";
            this.Load += new System.EventHandler(this.FormDinhMuc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxMaSanPham;
        private System.Windows.Forms.ComboBox comboBoxMaNguyenLieu;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDonViTinh;
    }
}