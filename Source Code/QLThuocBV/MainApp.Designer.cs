namespace QLThuocBV
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.MenuOption = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.btAddItem = new DevExpress.XtraBars.BarButtonItem();
            this.btRemoveItem = new DevExpress.XtraBars.BarButtonItem();
            this.btChangesData = new DevExpress.XtraBars.BarButtonItem();
            this.btRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btNhaCC = new DevExpress.XtraBars.BarButtonItem();
            this.btKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btBanThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridItemThuoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridNhaCC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.MenuOption.SuspendLayout();
            this.backstageViewClientControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.MenuOption;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btAddItem,
            this.btRemoveItem,
            this.btChangesData,
            this.btRefresh,
            this.barButtonItem3,
            this.btNhaCC,
            this.btKhachHang,
            this.btBanThuoc,
            this.btHoaDon,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barHeaderItem1,
            this.barButtonItem1,
            this.btThongKe});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(832, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // MenuOption
            // 
            this.MenuOption.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.MenuOption.Controls.Add(this.backstageViewClientControl1);
            this.MenuOption.Controls.Add(this.backstageViewClientControl2);
            this.MenuOption.Items.Add(this.backstageViewTabItem2);
            this.MenuOption.Items.Add(this.backstageViewItemSeparator1);
            this.MenuOption.Items.Add(this.backstageViewTabItem1);
            this.MenuOption.Location = new System.Drawing.Point(112, 150);
            this.MenuOption.Name = "MenuOption";
            this.MenuOption.Ribbon = this.ribbon;
            this.MenuOption.SelectedTab = this.backstageViewTabItem1;
            this.MenuOption.SelectedTabIndex = 2;
            this.MenuOption.Size = new System.Drawing.Size(627, 262);
            this.MenuOption.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013;
            this.MenuOption.TabIndex = 6;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(133, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(493, 198);
            this.backstageViewClientControl1.TabIndex = 0;
            // 
            // backstageViewClientControl2
            // 
            this.backstageViewClientControl2.Controls.Add(this.labelControl4);
            this.backstageViewClientControl2.Controls.Add(this.labelControl7);
            this.backstageViewClientControl2.Controls.Add(this.labelControl6);
            this.backstageViewClientControl2.Controls.Add(this.labelControl3);
            this.backstageViewClientControl2.Controls.Add(this.labelControl5);
            this.backstageViewClientControl2.Controls.Add(this.labelControl2);
            this.backstageViewClientControl2.Controls.Add(this.labelControl1);
            this.backstageViewClientControl2.Location = new System.Drawing.Point(133, 63);
            this.backstageViewClientControl2.Name = "backstageViewClientControl2";
            this.backstageViewClientControl2.Size = new System.Drawing.Size(493, 198);
            this.backstageViewClientControl2.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl4.Location = new System.Drawing.Point(71, 144);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 18);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "1.0.0.0";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl7.Location = new System.Drawing.Point(18, 246);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(106, 18);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Nguyễn Thái Hà";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl6.Location = new System.Drawing.Point(18, 222);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(98, 18);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Lê Hoàng Long";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Location = new System.Drawing.Point(71, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(199, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Chương Trình Quản Lý Thuốc ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 17F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl5.Location = new System.Drawing.Point(14, 188);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(164, 28);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Development by";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 17F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Location = new System.Drawing.Point(14, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(203, 28);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Product Information";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Location = new System.Drawing.Point(14, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "About";
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "Exit";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = true;
            this.backstageViewTabItem1.ItemPressed += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageViewTabItem1_ItemPressed);
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // backstageViewTabItem2
            // 
            this.backstageViewTabItem2.Caption = "About";
            this.backstageViewTabItem2.ContentControl = this.backstageViewClientControl2;
            this.backstageViewTabItem2.Name = "backstageViewTabItem2";
            this.backstageViewTabItem2.Selected = false;
            // 
            // btAddItem
            // 
            this.btAddItem.Caption = "Thêm";
            this.btAddItem.Glyph = ((System.Drawing.Image)(resources.GetObject("btAddItem.Glyph")));
            this.btAddItem.Id = 1;
            this.btAddItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btAddItem.LargeGlyph")));
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btAddItem_ItemClick);
            // 
            // btRemoveItem
            // 
            this.btRemoveItem.Caption = "Xóa";
            this.btRemoveItem.Glyph = ((System.Drawing.Image)(resources.GetObject("btRemoveItem.Glyph")));
            this.btRemoveItem.Id = 2;
            this.btRemoveItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btRemoveItem.LargeGlyph")));
            this.btRemoveItem.Name = "btRemoveItem";
            this.btRemoveItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btRemoveItem_ItemClick);
            // 
            // btChangesData
            // 
            this.btChangesData.Caption = "Lưu";
            this.btChangesData.Glyph = ((System.Drawing.Image)(resources.GetObject("btChangesData.Glyph")));
            this.btChangesData.Id = 3;
            this.btChangesData.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btChangesData.LargeGlyph")));
            this.btChangesData.Name = "btChangesData";
            this.btChangesData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btChangesData_ItemClick);
            // 
            // btRefresh
            // 
            this.btRefresh.Caption = "Làm Mới";
            this.btRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btRefresh.Glyph")));
            this.btRefresh.Id = 4;
            this.btRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btRefresh.LargeGlyph")));
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btRefresh_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Hiện Danh Sách";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btNhaCC
            // 
            this.btNhaCC.Caption = "Nhà Cung Cấp";
            this.btNhaCC.Glyph = ((System.Drawing.Image)(resources.GetObject("btNhaCC.Glyph")));
            this.btNhaCC.Id = 6;
            this.btNhaCC.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btNhaCC.LargeGlyph")));
            this.btNhaCC.Name = "btNhaCC";
            this.btNhaCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btNhaCC_ItemClick);
            // 
            // btKhachHang
            // 
            this.btKhachHang.Caption = "Khách Hàng";
            this.btKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btKhachHang.Glyph")));
            this.btKhachHang.Id = 7;
            this.btKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btKhachHang.LargeGlyph")));
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btKhachHang_ItemClick);
            // 
            // btBanThuoc
            // 
            this.btBanThuoc.Caption = "Bán Thuốc";
            this.btBanThuoc.Glyph = ((System.Drawing.Image)(resources.GetObject("btBanThuoc.Glyph")));
            this.btBanThuoc.Id = 8;
            this.btBanThuoc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btBanThuoc.LargeGlyph")));
            this.btBanThuoc.Name = "btBanThuoc";
            this.btBanThuoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btBanThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btBanThuoc_ItemClick);
            // 
            // btHoaDon
            // 
            this.btHoaDon.Caption = "Hóa Đơn";
            this.btHoaDon.Glyph = ((System.Drawing.Image)(resources.GetObject("btHoaDon.Glyph")));
            this.btHoaDon.Id = 9;
            this.btHoaDon.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btHoaDon.LargeGlyph")));
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btHoaDon_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 11;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "barStaticItem2";
            this.barStaticItem2.Id = 12;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "barStaticItem3";
            this.barStaticItem3.Id = 13;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 14;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btThongKe
            // 
            this.btThongKe.Caption = "Thống Kê";
            this.btThongKe.Glyph = ((System.Drawing.Image)(resources.GetObject("btThongKe.Glyph")));
            this.btThongKe.Id = 16;
            this.btThongKe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btThongKe.LargeGlyph")));
            this.btThongKe.Name = "btThongKe";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh Mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btAddItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btRemoveItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Add/Remove";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btChangesData);
            this.ribbonPageGroup2.ItemLinks.Add(this.btRefresh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Save / Refesh";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btNhaCC);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Supplier";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btKhachHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Customer";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btBanThuoc);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Sell";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btHoaDon);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Bill";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 490);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(832, 31);
            // 
            // gridItemThuoc
            // 
            this.gridItemThuoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridItemThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItemThuoc.Location = new System.Drawing.Point(0, 144);
            this.gridItemThuoc.MainView = this.gridView1;
            this.gridItemThuoc.MenuManager = this.ribbon;
            this.gridItemThuoc.Name = "gridItemThuoc";
            this.gridItemThuoc.Size = new System.Drawing.Size(832, 346);
            this.gridItemThuoc.TabIndex = 2;
            this.gridItemThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridNhaCC});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridItemThuoc;
            this.gridView1.Name = "gridView1";
            // 
            // gridNhaCC
            // 
            this.gridNhaCC.GridControl = this.gridItemThuoc;
            this.gridNhaCC.Name = "gridNhaCC";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(93, 31);
            this.txtSearch.MenuManager = this.ribbon;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(12, 29);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "Tìm Tên Thuốc";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSearch);
            this.groupControl1.Controls.Add(this.btSearch);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 426);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(832, 64);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Search";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 521);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridItemThuoc);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.MenuOption);
            this.Controls.Add(this.ribbon);
            this.Name = "MainApp";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Chương Trình Quản Lý Thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.MenuOption.ResumeLayout(false);
            this.backstageViewClientControl2.ResumeLayout(false);
            this.backstageViewClientControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridItemThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btAddItem;
        private DevExpress.XtraBars.BarButtonItem btRemoveItem;
        private DevExpress.XtraBars.BarButtonItem btChangesData;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridNhaCC;
        private DevExpress.XtraBars.BarButtonItem btNhaCC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl MenuOption;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.BarButtonItem btKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.BarButtonItem btBanThuoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btHoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btSearch;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem btThongKe;
    }
}