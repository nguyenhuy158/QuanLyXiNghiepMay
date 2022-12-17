namespace QuanLyXiNghiepMay.Forms.Form_Tables.Form_Detail.Form_Phieu_Phan_Cong
{
    partial class RibbonFormPhieuPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonFormPhieuPhanCong));
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
            this.comboBoxTenPhanXuong = new System.Windows.Forms.ComboBox();
            this.comboBoxMaPhanXuong = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSoPhieuPhanCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMaPhanXuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenPhanXuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEditRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.textEditSoPhieuPhanCong = new DevExpress.XtraEditors.TextEdit();
            this.dateEditNgayTao = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoPhieuPhanCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
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
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
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
            this.ribbonPage1.Text = "Phiếu Phân Công";
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
            this.layoutControl1.Controls.Add(this.comboBoxTenPhanXuong);
            this.layoutControl1.Controls.Add(this.comboBoxMaPhanXuong);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.textEditSoPhieuPhanCong);
            this.layoutControl1.Controls.Add(this.dateEditNgayTao);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 203);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(537, 132, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(798, 396);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboBoxTenPhanXuong
            // 
            this.comboBoxTenPhanXuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenPhanXuong.FormattingEnabled = true;
            this.comboBoxTenPhanXuong.Location = new System.Drawing.Point(497, 89);
            this.comboBoxTenPhanXuong.Name = "comboBoxTenPhanXuong";
            this.comboBoxTenPhanXuong.Size = new System.Drawing.Size(273, 21);
            this.comboBoxTenPhanXuong.TabIndex = 6;
            this.comboBoxTenPhanXuong.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenPhanXuong_SelectedIndexChanged);
            // 
            // comboBoxMaPhanXuong
            // 
            this.comboBoxMaPhanXuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaPhanXuong.Enabled = false;
            this.comboBoxMaPhanXuong.FormattingEnabled = true;
            this.comboBoxMaPhanXuong.Location = new System.Drawing.Point(123, 89);
            this.comboBoxMaPhanXuong.Name = "comboBoxMaPhanXuong";
            this.comboBoxMaPhanXuong.Size = new System.Drawing.Size(273, 21);
            this.comboBoxMaPhanXuong.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(QuanLyXiNghiepMay.PhieuPhanCong);
            this.gridControl1.Location = new System.Drawing.Point(16, 162);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit11,
            this.repositoryItemButtonEditRemove});
            this.gridControl1.Size = new System.Drawing.Size(766, 218);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnSoPhieuPhanCong,
            this.gridColumnMaPhanXuong,
            this.gridColumnTenPhanXuong,
            this.gridColumnNgayTao});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView11_RowCellClick);
            // 
            // gridColumnSoPhieuPhanCong
            // 
            this.gridColumnSoPhieuPhanCong.Caption = "Số phiếu phân công";
            this.gridColumnSoPhieuPhanCong.FieldName = "so";
            this.gridColumnSoPhieuPhanCong.Name = "gridColumnSoPhieuPhanCong";
            this.gridColumnSoPhieuPhanCong.Visible = true;
            this.gridColumnSoPhieuPhanCong.VisibleIndex = 0;
            // 
            // gridColumnMaPhanXuong
            // 
            this.gridColumnMaPhanXuong.Caption = "Mã phân xưởng";
            this.gridColumnMaPhanXuong.FieldName = "maPhanXuong";
            this.gridColumnMaPhanXuong.Name = "gridColumnMaPhanXuong";
            this.gridColumnMaPhanXuong.Visible = true;
            this.gridColumnMaPhanXuong.VisibleIndex = 1;
            // 
            // gridColumnTenPhanXuong
            // 
            this.gridColumnTenPhanXuong.Caption = "Tên phân xưởng";
            this.gridColumnTenPhanXuong.FieldName = "PhanXuong.ten";
            this.gridColumnTenPhanXuong.Name = "gridColumnTenPhanXuong";
            this.gridColumnTenPhanXuong.Visible = true;
            this.gridColumnTenPhanXuong.VisibleIndex = 2;
            // 
            // gridColumnNgayTao
            // 
            this.gridColumnNgayTao.Caption = "Ngày tạo";
            this.gridColumnNgayTao.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumnNgayTao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnNgayTao.FieldName = "ngayTao";
            this.gridColumnNgayTao.Name = "gridColumnNgayTao";
            this.gridColumnNgayTao.Visible = true;
            this.gridColumnNgayTao.VisibleIndex = 3;
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
            // textEditSoPhieuPhanCong
            // 
            this.textEditSoPhieuPhanCong.Enabled = false;
            this.textEditSoPhieuPhanCong.Location = new System.Drawing.Point(123, 55);
            this.textEditSoPhieuPhanCong.Name = "textEditSoPhieuPhanCong";
            this.textEditSoPhieuPhanCong.Size = new System.Drawing.Size(647, 28);
            this.textEditSoPhieuPhanCong.StyleController = this.layoutControl1;
            this.textEditSoPhieuPhanCong.TabIndex = 4;
            // 
            // dateEditNgayTao
            // 
            this.dateEditNgayTao.EditValue = new System.DateTime(2022, 11, 14, 15, 24, 29, 0);
            this.dateEditNgayTao.Location = new System.Drawing.Point(123, 116);
            this.dateEditNgayTao.Name = "dateEditNgayTao";
            this.dateEditNgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayTao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayTao.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.dateEditNgayTao.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditNgayTao.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditNgayTao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditNgayTao.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditNgayTao.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditNgayTao.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dateEditNgayTao.Properties.UseMaskAsDisplayFormat = true;
            this.dateEditNgayTao.Size = new System.Drawing.Size(647, 28);
            this.dateEditNgayTao.StyleController = this.layoutControl1;
            this.dateEditNgayTao.TabIndex = 4;
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
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 146);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(772, 224);
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
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem7});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroup10.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlGroup10.Size = new System.Drawing.Size(772, 146);
            this.layoutControlGroup10.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup10.Text = "Nhập thông tin";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEditSoPhieuPhanCong;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Số phiếu";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(748, 34);
            this.layoutControlItem2.Text = "Số phiếu";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.comboBoxMaPhanXuong;
            this.layoutControlItem6.CustomizationFormText = "Mã phân xưởng";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(374, 27);
            this.layoutControlItem6.Text = "Mã phân xưởng";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateEditNgayTao;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "Ngày tạo";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(748, 34);
            this.layoutControlItem3.Text = "Ngày tạo";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.comboBoxTenPhanXuong;
            this.layoutControlItem7.CustomizationFormText = "Tên phân xưởng";
            this.layoutControlItem7.Location = new System.Drawing.Point(374, 34);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(374, 27);
            this.layoutControlItem7.Text = "Tên phân xưởng";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(79, 13);
            // 
            // RibbonFormPhieuPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "RibbonFormPhieuPhanCong";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Phiếu Phân Công";
            this.Load += new System.EventHandler(this.RibbonFormPhieuPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoPhieuPhanCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit11;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditRemove;
        private DevExpress.XtraEditors.TextEdit textEditSoPhieuPhanCong;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit dateEditNgayTao;
        private System.Windows.Forms.ComboBox comboBoxTenPhanXuong;
        private System.Windows.Forms.ComboBox comboBoxMaPhanXuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoPhieuPhanCong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaPhanXuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenPhanXuong;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
    }
}