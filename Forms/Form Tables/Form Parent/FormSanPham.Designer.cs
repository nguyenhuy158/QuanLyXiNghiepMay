namespace QuanLyXiNghiepMay.Forms.Form_Tables.Form_Parent
{
    partial class FormSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEditRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEditGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.textEditTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.textEditMaSanPham = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItemWindown = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemHighlightEvenRow = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(QuanLyXiNghiepMay.SanPham);
            this.gridControl1.Location = new System.Drawing.Point(16, 169);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEditRemove});
            this.gridControl1.Size = new System.Drawing.Size(766, 211);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaSanPham,
            this.gridColumnTenSanPham,
            this.gridColumnGhiChu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumnMaSanPham
            // 
            this.gridColumnMaSanPham.Caption = "Mã sản phẩm";
            this.gridColumnMaSanPham.FieldName = "ma";
            this.gridColumnMaSanPham.Name = "gridColumnMaSanPham";
            this.gridColumnMaSanPham.Visible = true;
            this.gridColumnMaSanPham.VisibleIndex = 0;
            this.gridColumnMaSanPham.Width = 89;
            // 
            // gridColumnTenSanPham
            // 
            this.gridColumnTenSanPham.Caption = "Tên sản phẩm";
            this.gridColumnTenSanPham.FieldName = "ten";
            this.gridColumnTenSanPham.Name = "gridColumnTenSanPham";
            this.gridColumnTenSanPham.Visible = true;
            this.gridColumnTenSanPham.VisibleIndex = 1;
            this.gridColumnTenSanPham.Width = 89;
            // 
            // gridColumnGhiChu
            // 
            this.gridColumnGhiChu.Caption = "Ghi chú";
            this.gridColumnGhiChu.FieldName = "ghiChu";
            this.gridColumnGhiChu.Name = "gridColumnGhiChu";
            this.gridColumnGhiChu.Visible = true;
            this.gridColumnGhiChu.VisibleIndex = 2;
            this.gridColumnGhiChu.Width = 84;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEditRemove
            // 
            this.repositoryItemButtonEditRemove.AutoHeight = false;
            this.repositoryItemButtonEditRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEditRemove.Name = "repositoryItemButtonEditRemove";
            this.repositoryItemButtonEditRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEditGhiChu);
            this.layoutControl1.Controls.Add(this.textEditTenSanPham);
            this.layoutControl1.Controls.Add(this.textEditMaSanPham);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 203);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(798, 396);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEditGhiChu
            // 
            this.textEditGhiChu.Location = new System.Drawing.Point(111, 123);
            this.textEditGhiChu.Name = "textEditGhiChu";
            this.textEditGhiChu.Size = new System.Drawing.Size(659, 28);
            this.textEditGhiChu.StyleController = this.layoutControl1;
            this.textEditGhiChu.TabIndex = 6;
            // 
            // textEditTenSanPham
            // 
            this.textEditTenSanPham.Location = new System.Drawing.Point(111, 89);
            this.textEditTenSanPham.Name = "textEditTenSanPham";
            this.textEditTenSanPham.Size = new System.Drawing.Size(659, 28);
            this.textEditTenSanPham.StyleController = this.layoutControl1;
            this.textEditTenSanPham.TabIndex = 5;
            // 
            // textEditMaSanPham
            // 
            this.textEditMaSanPham.Enabled = false;
            this.textEditMaSanPham.Location = new System.Drawing.Point(111, 55);
            this.textEditMaSanPham.Name = "textEditMaSanPham";
            this.textEditMaSanPham.Size = new System.Drawing.Size(659, 28);
            this.textEditMaSanPham.StyleController = this.layoutControl1;
            this.textEditMaSanPham.TabIndex = 4;
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
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 153);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(772, 217);
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
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroup10.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlGroup10.Size = new System.Drawing.Size(772, 153);
            this.layoutControlGroup10.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup10.Text = "Nhập thông tin";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEditMaSanPham;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(748, 34);
            this.layoutControlItem2.Text = "Mã sản phẩm";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEditTenSanPham;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(748, 34);
            this.layoutControlItem3.Text = "Tên sản phẩm";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEditGhiChu;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(748, 34);
            this.layoutControlItem4.Text = "Ghi chú";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 13);
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
            this.barButtonItem7,
            this.barButtonItemPrint,
            this.barCheckItemWindown,
            this.barCheckItemHighlightEvenRow});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
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
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.edit;
            this.barButtonItem2.LargeWidth = 70;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.delete_file;
            this.barButtonItem3.LargeWidth = 70;
            this.barButtonItem3.Name = "barButtonItem3";
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
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thoát";
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.ImageOptions.LargeImage = global::QuanLyXiNghiepMay.Properties.Resources.exit;
            this.barButtonItem7.LargeWidth = 70;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItemPrint
            // 
            this.barButtonItemPrint.Caption = "In danh sách";
            this.barButtonItemPrint.Id = 10;
            this.barButtonItemPrint.ImageOptions.Image = global::QuanLyXiNghiepMay.Properties.Resources.ic_print_table;
            this.barButtonItemPrint.Name = "barButtonItemPrint";
            this.barButtonItemPrint.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.barButtonItemPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barCheckItemWindown
            // 
            this.barCheckItemWindown.BindableChecked = true;
            this.barCheckItemWindown.Caption = "Hiển thị dạng cửa sổ";
            this.barCheckItemWindown.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItemWindown.Checked = true;
            this.barCheckItemWindown.Id = 14;
            this.barCheckItemWindown.Name = "barCheckItemWindown";
            this.barCheckItemWindown.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barCheckItemHighlightEvenRow
            // 
            this.barCheckItemHighlightEvenRow.BindableChecked = true;
            this.barCheckItemHighlightEvenRow.Caption = "Hightlight dòng chẳn";
            this.barCheckItemHighlightEvenRow.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItemHighlightEvenRow.Checked = true;
            this.barCheckItemHighlightEvenRow.Id = 15;
            this.barCheckItemHighlightEvenRow.Name = "barCheckItemHighlightEvenRow";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Sản phẩm";
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
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemPrint, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItemWindown);
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItemHighlightEvenRow);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Nâng cao";
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormSanPham";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.XtraFormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditRemove;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEditMaSanPham;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit textEditGhiChu;
        private DevExpress.XtraEditors.TextEdit textEditTenSanPham;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarCheckItem barCheckItemWindown;
        private DevExpress.XtraBars.BarCheckItem barCheckItemHighlightEvenRow;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
    }
}