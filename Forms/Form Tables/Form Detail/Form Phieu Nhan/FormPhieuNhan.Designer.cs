namespace QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Nhan
{
    partial class FormPhieuNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuNhan));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSoPhieuNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenNguoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNgayTaoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dateEditNgayTao = new DevExpress.XtraEditors.DateEdit();
            this.textEditTenNguoiNhan = new DevExpress.XtraEditors.TextEdit();
            this.textEditSoPhieuNhan = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNguoiNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoPhieuNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dateEditNgayTao);
            this.layoutControl1.Controls.Add(this.textEditTenNguoiNhan);
            this.layoutControl1.Controls.Add(this.textEditSoPhieuNhan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 203);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 135, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(798, 396);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(QuanLyXiNghiepMay.PhieuNhan);
            this.gridControl1.Location = new System.Drawing.Point(16, 169);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(766, 211);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnSoPhieuNhan,
            this.gridColumnTenNguoiNhan,
            this.gridColumnNgayTaoPhieu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumnSoPhieuNhan
            // 
            this.gridColumnSoPhieuNhan.Caption = "Số phiếu nhận";
            this.gridColumnSoPhieuNhan.FieldName = "so";
            this.gridColumnSoPhieuNhan.Name = "gridColumnSoPhieuNhan";
            this.gridColumnSoPhieuNhan.OptionsColumn.AllowEdit = false;
            this.gridColumnSoPhieuNhan.Visible = true;
            this.gridColumnSoPhieuNhan.VisibleIndex = 0;
            // 
            // gridColumnTenNguoiNhan
            // 
            this.gridColumnTenNguoiNhan.Caption = "Tên người nhận";
            this.gridColumnTenNguoiNhan.FieldName = "tenNguoiNhan";
            this.gridColumnTenNguoiNhan.Name = "gridColumnTenNguoiNhan";
            this.gridColumnTenNguoiNhan.OptionsColumn.AllowEdit = false;
            this.gridColumnTenNguoiNhan.Visible = true;
            this.gridColumnTenNguoiNhan.VisibleIndex = 2;
            // 
            // gridColumnNgayTaoPhieu
            // 
            this.gridColumnNgayTaoPhieu.Caption = "Ngày tạo phiếu";
            this.gridColumnNgayTaoPhieu.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumnNgayTaoPhieu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnNgayTaoPhieu.FieldName = "ngayTao";
            this.gridColumnNgayTaoPhieu.Name = "gridColumnNgayTaoPhieu";
            this.gridColumnNgayTaoPhieu.OptionsColumn.AllowEdit = false;
            this.gridColumnNgayTaoPhieu.Visible = true;
            this.gridColumnNgayTaoPhieu.VisibleIndex = 1;
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonImageOptions.Image = global::QuanLyXiNghiepMay.Properties.Resources.icon_logo;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(798, 203);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm ";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.floppy_disk;
            this.barButtonItem1.LargeWidth = 70;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.edit;
            this.barButtonItem2.LargeWidth = 70;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.delete_file;
            this.barButtonItem3.LargeWidth = 70;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.ActAsDropDown = true;
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.ImageOptions.Image = global::QuanLyXiNghiepMay.Properties.Resources.rubber;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Tải lại";
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.refresh;
            this.barButtonItem6.LargeWidth = 70;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thoát";
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.exit;
            this.barButtonItem7.LargeWidth = 70;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Phiếu nhận";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thao tác";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Nâng cao";
            // 
            // dateEditNgayTao
            // 
            this.dateEditNgayTao.EditValue = new System.DateTime(2022, 11, 14, 14, 14, 23, 0);
            this.dateEditNgayTao.Location = new System.Drawing.Point(119, 89);
            this.dateEditNgayTao.MenuManager = this.ribbon;
            this.dateEditNgayTao.Name = "dateEditNgayTao";
            this.dateEditNgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayTao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayTao.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditNgayTao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditNgayTao.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditNgayTao.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditNgayTao.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dateEditNgayTao.Properties.UseMaskAsDisplayFormat = true;
            this.dateEditNgayTao.Size = new System.Drawing.Size(651, 28);
            this.dateEditNgayTao.StyleController = this.layoutControl1;
            this.dateEditNgayTao.TabIndex = 6;
            // 
            // textEditTenNguoiNhan
            // 
            this.textEditTenNguoiNhan.Location = new System.Drawing.Point(119, 123);
            this.textEditTenNguoiNhan.MenuManager = this.ribbon;
            this.textEditTenNguoiNhan.Name = "textEditTenNguoiNhan";
            this.textEditTenNguoiNhan.Size = new System.Drawing.Size(651, 28);
            this.textEditTenNguoiNhan.StyleController = this.layoutControl1;
            this.textEditTenNguoiNhan.TabIndex = 5;
            // 
            // textEditSoPhieuNhan
            // 
            this.textEditSoPhieuNhan.Enabled = false;
            this.textEditSoPhieuNhan.Location = new System.Drawing.Point(119, 55);
            this.textEditSoPhieuNhan.MenuManager = this.ribbon;
            this.textEditSoPhieuNhan.Name = "textEditSoPhieuNhan";
            this.textEditSoPhieuNhan.Size = new System.Drawing.Size(651, 28);
            this.textEditSoPhieuNhan.StyleController = this.layoutControl1;
            this.textEditSoPhieuNhan.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlGroup10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(798, 396);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 153);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(772, 217);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup10
            // 
            this.layoutControlGroup10.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlGroup10.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup10.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlGroup10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup10.AppearanceTabPage.Header.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlGroup10.AppearanceTabPage.Header.Options.UseFont = true;
            this.layoutControlGroup10.AppearanceTabPage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlGroup10.AppearanceTabPage.HeaderActive.Options.UseFont = true;
            this.layoutControlGroup10.AppearanceTabPage.HeaderDisabled.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlGroup10.AppearanceTabPage.HeaderDisabled.Options.UseFont = true;
            this.layoutControlGroup10.AppearanceTabPage.HeaderHotTracked.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlGroup10.AppearanceTabPage.HeaderHotTracked.Options.UseFont = true;
            this.layoutControlGroup10.AppearanceTabPage.PageClient.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlGroup10.AppearanceTabPage.PageClient.Options.UseFont = true;
            this.layoutControlGroup10.CustomizationFormText = "layoutControlGroup10";
            this.layoutControlGroup10.ExpandButtonVisible = true;
            this.layoutControlGroup10.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroup10.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlGroup10.Size = new System.Drawing.Size(772, 153);
            this.layoutControlGroup10.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup10.Text = "Nhập thông tin";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEditSoPhieuNhan;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(748, 34);
            this.layoutControlItem1.Text = "Số phiếu nhận";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateEditNgayTao;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(748, 34);
            this.layoutControlItem3.Text = "Ngày lập phiếu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEditTenNguoiNhan;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(748, 34);
            this.layoutControlItem2.Text = "Tên người nhận";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thêm";
            this.barButtonItem4.Id = 1;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.LargeWidth = 70;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thao tác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thao tác";
            // 
            // FormPhieuNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "FormPhieuNhan";
            this.Ribbon = this.ribbon;
            this.Text = "Phiếu Nhận";
            this.Load += new System.EventHandler(this.RibbonFormPhieuNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNguoiNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoPhieuNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEditSoPhieuNhan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dateEditNgayTao;
        private DevExpress.XtraEditors.TextEdit textEditTenNguoiNhan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoPhieuNhan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNgayTaoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNguoiNhan;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
    }
}