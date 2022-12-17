namespace QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Phan_Cong
{
    partial class FormChiTietPhieuPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietPhieuPhanCong));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSoPhieuNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEditRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.textEditSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxSoPhieuPhanCong = new System.Windows.Forms.ComboBox();
            this.comboBoxMaSanPham = new System.Windows.Forms.ComboBox();
            this.comboBoxTenSanPham = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonImageOptions.Image = global::QuanLyXiNghiepMay.Properties.Resources.icon_logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.OnlyWhenMaximized;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(798, 203);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.floppy_disk;
            this.barButtonItem1.LargeWidth = 70;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.edit;
            this.barButtonItem2.LargeWidth = 70;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.delete_file;
            this.barButtonItem3.LargeWidth = 70;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tải lại";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.refresh;
            this.barButtonItem4.LargeWidth = 70;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.ActAsDropDown = true;
            this.barButtonItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = global::QuanLyXiNghiepMay.Properties.Resources.rubber;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Xóa dữ liệu";
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thoát";
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.exit;
            this.barButtonItem7.LargeWidth = 70;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chi Tiết Phiếu Phân Công";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thao tác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Nâng cao";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.textEditSoLuong);
            this.layoutControl1.Controls.Add(this.comboBoxSoPhieuPhanCong);
            this.layoutControl1.Controls.Add(this.comboBoxMaSanPham);
            this.layoutControl1.Controls.Add(this.comboBoxTenSanPham);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 203);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(527, 149, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(798, 396);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(QuanLyXiNghiepMay.ChiTietPhieuPhanCong);
            this.gridControl1.Location = new System.Drawing.Point(16, 155);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit11,
            this.repositoryItemButtonEditRemove});
            this.gridControl1.Size = new System.Drawing.Size(766, 225);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnSoPhieuNhan,
            this.gridColumnMaSanPham,
            this.gridColumnSoLuong});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView11_RowCellClick);
            // 
            // gridColumnSoPhieuNhan
            // 
            this.gridColumnSoPhieuNhan.Caption = "Số phiếu";
            this.gridColumnSoPhieuNhan.FieldName = "soPhieuPhanCong";
            this.gridColumnSoPhieuNhan.Name = "gridColumnSoPhieuNhan";
            this.gridColumnSoPhieuNhan.Visible = true;
            this.gridColumnSoPhieuNhan.VisibleIndex = 0;
            this.gridColumnSoPhieuNhan.Width = 89;
            // 
            // gridColumnMaSanPham
            // 
            this.gridColumnMaSanPham.Caption = "Mã sản phẩm";
            this.gridColumnMaSanPham.FieldName = "maSanPham";
            this.gridColumnMaSanPham.Name = "gridColumnMaSanPham";
            this.gridColumnMaSanPham.Visible = true;
            this.gridColumnMaSanPham.VisibleIndex = 1;
            this.gridColumnMaSanPham.Width = 89;
            // 
            // gridColumnSoLuong
            // 
            this.gridColumnSoLuong.Caption = "Số lượng";
            this.gridColumnSoLuong.DisplayFormat.FormatString = "N0";
            this.gridColumnSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSoLuong.FieldName = "soLuong";
            this.gridColumnSoLuong.Name = "gridColumnSoLuong";
            this.gridColumnSoLuong.Visible = true;
            this.gridColumnSoLuong.VisibleIndex = 2;
            this.gridColumnSoLuong.Width = 84;
            // 
            // repositoryItemButtonEdit11
            // 
            this.repositoryItemButtonEdit11.AutoHeight = false;
            this.repositoryItemButtonEdit11.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEdit11.Name = "repositoryItemButtonEdit11";
            this.repositoryItemButtonEdit11.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEditRemove
            // 
            this.repositoryItemButtonEditRemove.AutoHeight = false;
            this.repositoryItemButtonEditRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEditRemove.Name = "repositoryItemButtonEditRemove";
            this.repositoryItemButtonEditRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // textEditSoLuong
            // 
            this.textEditSoLuong.EditValue = "0";
            this.textEditSoLuong.Location = new System.Drawing.Point(111, 109);
            this.textEditSoLuong.Name = "textEditSoLuong";
            this.textEditSoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditSoLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditSoLuong.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEditSoLuong.Properties.MaskSettings.Set("mask", "N0");
            this.textEditSoLuong.Properties.UseMaskAsDisplayFormat = true;
            this.textEditSoLuong.Size = new System.Drawing.Size(659, 28);
            this.textEditSoLuong.StyleController = this.layoutControl1;
            this.textEditSoLuong.TabIndex = 4;
            // 
            // comboBoxSoPhieuPhanCong
            // 
            this.comboBoxSoPhieuPhanCong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoPhieuPhanCong.FormattingEnabled = true;
            this.comboBoxSoPhieuPhanCong.Location = new System.Drawing.Point(111, 55);
            this.comboBoxSoPhieuPhanCong.Name = "comboBoxSoPhieuPhanCong";
            this.comboBoxSoPhieuPhanCong.Size = new System.Drawing.Size(659, 21);
            this.comboBoxSoPhieuPhanCong.TabIndex = 6;
            // 
            // comboBoxMaSanPham
            // 
            this.comboBoxMaSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaSanPham.Enabled = false;
            this.comboBoxMaSanPham.FormattingEnabled = true;
            this.comboBoxMaSanPham.Location = new System.Drawing.Point(111, 82);
            this.comboBoxMaSanPham.Name = "comboBoxMaSanPham";
            this.comboBoxMaSanPham.Size = new System.Drawing.Size(285, 21);
            this.comboBoxMaSanPham.TabIndex = 6;
            // 
            // comboBoxTenSanPham
            // 
            this.comboBoxTenSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenSanPham.FormattingEnabled = true;
            this.comboBoxTenSanPham.Location = new System.Drawing.Point(485, 82);
            this.comboBoxTenSanPham.Name = "comboBoxTenSanPham";
            this.comboBoxTenSanPham.Size = new System.Drawing.Size(285, 21);
            this.comboBoxTenSanPham.TabIndex = 6;
            this.comboBoxTenSanPham.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenSanPham_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(798, 396);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 139);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(772, 231);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroup10.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlGroup10.Size = new System.Drawing.Size(772, 139);
            this.layoutControlGroup10.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup10.Text = "Nhập thông tin";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.comboBoxSoPhieuPhanCong;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "Số phiếu";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(748, 27);
            this.layoutControlItem7.Text = "Số phiếu";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.comboBoxMaSanPham;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem8.CustomizationFormText = "Mã sản phẩm";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(374, 27);
            this.layoutControlItem8.Text = "Mã sản phẩm";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEditSoLuong;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "Số lượng";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(748, 34);
            this.layoutControlItem5.Text = "Số lượng";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboBoxTenSanPham;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Tên sản phẩm";
            this.layoutControlItem2.Location = new System.Drawing.Point(374, 27);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(374, 27);
            this.layoutControlItem2.Text = "Tên sản phẩm";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // FormChiTietPhieuPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormChiTietPhieuPhanCong";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Chi Tiết Phiếu Phân Công";
            this.Load += new System.EventHandler(this.RibbonFormChiTietPhieuPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoPhieuNhan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit11;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditRemove;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit textEditSoLuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.ComboBox comboBoxSoPhieuPhanCong;
        private System.Windows.Forms.ComboBox comboBoxMaSanPham;
        private System.Windows.Forms.ComboBox comboBoxTenSanPham;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
    }
}