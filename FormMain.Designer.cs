namespace QuanLyXiNghiepMay
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyenLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânXưởngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhMứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.xemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.loadToolStripMenuItem.Text = "Pet project";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.form2ToolStripMenuItem.Text = "form 2";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyenLieuToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.địnhMứcToolStripMenuItem,
            this.phânXưởngToolStripMenuItem});
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.xemToolStripMenuItem.Text = "Thêm dữ liệu";
            this.xemToolStripMenuItem.Click += new System.EventHandler(this.xemToolStripMenuItem_Click);
            // 
            // nguyenLieuToolStripMenuItem
            // 
            this.nguyenLieuToolStripMenuItem.Name = "nguyenLieuToolStripMenuItem";
            this.nguyenLieuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nguyenLieuToolStripMenuItem.Text = "Nguyên Liệu";
            this.nguyenLieuToolStripMenuItem.Click += new System.EventHandler(this.nguyenLieuToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // phânXưởngToolStripMenuItem
            // 
            this.phânXưởngToolStripMenuItem.Name = "phânXưởngToolStripMenuItem";
            this.phânXưởngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phânXưởngToolStripMenuItem.Text = "Phân Xưởng";
            // 
            // địnhMứcToolStripMenuItem
            // 
            this.địnhMứcToolStripMenuItem.Name = "địnhMứcToolStripMenuItem";
            this.địnhMứcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.địnhMứcToolStripMenuItem.Text = "Định Mức";
            this.địnhMứcToolStripMenuItem.Click += new System.EventHandler(this.địnhMứcToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 353);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyenLieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânXưởngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhMứcToolStripMenuItem;
    }
}

