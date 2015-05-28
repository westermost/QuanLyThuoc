namespace QLThuocBV
{
    partial class frmKhachHang
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridKhachHangItem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupboxEdit = new DevExpress.XtraEditors.GroupControl();
            this.rbtTimMaKH = new System.Windows.Forms.RadioButton();
            this.rbtTimTenKH = new System.Windows.Forms.RadioButton();
            this.btSearchKH = new System.Windows.Forms.Button();
            this.txtSearchKH = new DevExpress.XtraEditors.TextEdit();
            this.btTuSinhMaKH = new DevExpress.XtraEditors.SimpleButton();
            this.btChangesKH = new DevExpress.XtraEditors.SimpleButton();
            this.btXoaKH = new DevExpress.XtraEditors.SimpleButton();
            this.btThemKH = new DevExpress.XtraEditors.SimpleButton();
            this.txtBenhAn = new System.Windows.Forms.TextBox();
            this.dateNgaySinhKH = new DevExpress.XtraEditors.DateEdit();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHangItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupboxEdit)).BeginInit();
            this.groupboxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhKH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridKhachHangItem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(637, 232);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Khách Hàng";
            // 
            // gridKhachHangItem
            // 
            this.gridKhachHangItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridKhachHangItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridKhachHangItem.Location = new System.Drawing.Point(2, 21);
            this.gridKhachHangItem.MainView = this.gridView1;
            this.gridKhachHangItem.Name = "gridKhachHangItem";
            this.gridKhachHangItem.Size = new System.Drawing.Size(633, 206);
            this.gridKhachHangItem.TabIndex = 0;
            this.gridKhachHangItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridKhachHangItem;
            this.gridView1.Name = "gridView1";
            // 
            // groupboxEdit
            // 
            this.groupboxEdit.Controls.Add(this.rbtTimMaKH);
            this.groupboxEdit.Controls.Add(this.rbtTimTenKH);
            this.groupboxEdit.Controls.Add(this.btSearchKH);
            this.groupboxEdit.Controls.Add(this.txtSearchKH);
            this.groupboxEdit.Controls.Add(this.btTuSinhMaKH);
            this.groupboxEdit.Controls.Add(this.btChangesKH);
            this.groupboxEdit.Controls.Add(this.btXoaKH);
            this.groupboxEdit.Controls.Add(this.btThemKH);
            this.groupboxEdit.Controls.Add(this.txtBenhAn);
            this.groupboxEdit.Controls.Add(this.dateNgaySinhKH);
            this.groupboxEdit.Controls.Add(this.txtSDTKH);
            this.groupboxEdit.Controls.Add(this.txtDiaChiKH);
            this.groupboxEdit.Controls.Add(this.txtTenKH);
            this.groupboxEdit.Controls.Add(this.txtMaKH);
            this.groupboxEdit.Controls.Add(this.labelControl6);
            this.groupboxEdit.Controls.Add(this.labelControl5);
            this.groupboxEdit.Controls.Add(this.labelControl4);
            this.groupboxEdit.Controls.Add(this.labelControl3);
            this.groupboxEdit.Controls.Add(this.labelControl2);
            this.groupboxEdit.Controls.Add(this.labelControl1);
            this.groupboxEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupboxEdit.Location = new System.Drawing.Point(0, 247);
            this.groupboxEdit.Name = "groupboxEdit";
            this.groupboxEdit.Size = new System.Drawing.Size(637, 241);
            this.groupboxEdit.TabIndex = 1;
            this.groupboxEdit.Text = "Edit";
            // 
            // rbtTimMaKH
            // 
            this.rbtTimMaKH.AutoSize = true;
            this.rbtTimMaKH.Location = new System.Drawing.Point(524, 194);
            this.rbtTimMaKH.Name = "rbtTimMaKH";
            this.rbtTimMaKH.Size = new System.Drawing.Size(101, 17);
            this.rbtTimMaKH.TabIndex = 8;
            this.rbtTimMaKH.Text = "Tìm Theo Mã KH";
            this.rbtTimMaKH.UseVisualStyleBackColor = true;
            // 
            // rbtTimTenKH
            // 
            this.rbtTimTenKH.AutoSize = true;
            this.rbtTimTenKH.Checked = true;
            this.rbtTimTenKH.Location = new System.Drawing.Point(433, 194);
            this.rbtTimTenKH.Name = "rbtTimTenKH";
            this.rbtTimTenKH.Size = new System.Drawing.Size(89, 17);
            this.rbtTimTenKH.TabIndex = 8;
            this.rbtTimTenKH.TabStop = true;
            this.rbtTimTenKH.Text = "Tìm Theo Tên";
            this.rbtTimTenKH.UseVisualStyleBackColor = true;
            // 
            // btSearchKH
            // 
            this.btSearchKH.Location = new System.Drawing.Point(543, 156);
            this.btSearchKH.Name = "btSearchKH";
            this.btSearchKH.Size = new System.Drawing.Size(75, 23);
            this.btSearchKH.TabIndex = 7;
            this.btSearchKH.Text = "Tìm Kiếm";
            this.btSearchKH.UseVisualStyleBackColor = true;
            this.btSearchKH.Click += new System.EventHandler(this.btSearchKH_Click);
            // 
            // txtSearchKH
            // 
            this.txtSearchKH.Location = new System.Drawing.Point(433, 156);
            this.txtSearchKH.Name = "txtSearchKH";
            this.txtSearchKH.Size = new System.Drawing.Size(100, 20);
            this.txtSearchKH.TabIndex = 6;
            // 
            // btTuSinhMaKH
            // 
            this.btTuSinhMaKH.Location = new System.Drawing.Point(12, 31);
            this.btTuSinhMaKH.Name = "btTuSinhMaKH";
            this.btTuSinhMaKH.Size = new System.Drawing.Size(75, 23);
            this.btTuSinhMaKH.TabIndex = 5;
            this.btTuSinhMaKH.Text = "Sinh Mã KH";
            this.btTuSinhMaKH.Click += new System.EventHandler(this.btTuSinhMaKH_Click);
            // 
            // btChangesKH
            // 
            this.btChangesKH.Location = new System.Drawing.Point(543, 30);
            this.btChangesKH.Name = "btChangesKH";
            this.btChangesKH.Size = new System.Drawing.Size(81, 23);
            this.btChangesKH.TabIndex = 4;
            this.btChangesKH.Text = "Lưu Sửa Đổi";
            this.btChangesKH.Click += new System.EventHandler(this.btChangesKH_Click);
            // 
            // btXoaKH
            // 
            this.btXoaKH.Location = new System.Drawing.Point(536, 93);
            this.btXoaKH.Name = "btXoaKH";
            this.btXoaKH.Size = new System.Drawing.Size(88, 41);
            this.btXoaKH.TabIndex = 4;
            this.btXoaKH.Text = "Xóa";
            this.btXoaKH.Click += new System.EventHandler(this.btXoaKH_Click);
            // 
            // btThemKH
            // 
            this.btThemKH.Location = new System.Drawing.Point(442, 94);
            this.btThemKH.Name = "btThemKH";
            this.btThemKH.Size = new System.Drawing.Size(88, 41);
            this.btThemKH.TabIndex = 4;
            this.btThemKH.Text = "Thêm KH";
            this.btThemKH.Click += new System.EventHandler(this.btThemKH_Click);
            // 
            // txtBenhAn
            // 
            this.txtBenhAn.Location = new System.Drawing.Point(12, 156);
            this.txtBenhAn.MaxLength = 999999;
            this.txtBenhAn.Multiline = true;
            this.txtBenhAn.Name = "txtBenhAn";
            this.txtBenhAn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBenhAn.Size = new System.Drawing.Size(415, 73);
            this.txtBenhAn.TabIndex = 3;
            // 
            // dateNgaySinhKH
            // 
            this.dateNgaySinhKH.EditValue = null;
            this.dateNgaySinhKH.Location = new System.Drawing.Point(524, 59);
            this.dateNgaySinhKH.Name = "dateNgaySinhKH";
            this.dateNgaySinhKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinhKH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinhKH.Size = new System.Drawing.Size(100, 20);
            this.dateNgaySinhKH.TabIndex = 2;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(294, 105);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(133, 21);
            this.txtSDTKH.TabIndex = 1;
            this.txtSDTKH.TextChanged += new System.EventHandler(this.txtSDTKH_TextChanged);
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(74, 104);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(133, 21);
            this.txtDiaChiKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(294, 62);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(133, 21);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(74, 62);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(133, 21);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.Leave += new System.EventHandler(this.txtMaKH_Leave);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Location = new System.Drawing.Point(10, 104);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 17);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Địa Chỉ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(10, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 17);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Bệnh Án:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(228, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "SĐT:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(446, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày Sinh:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(228, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên KH:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(12, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã KH: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 488);
            this.Controls.Add(this.groupboxEdit);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHangItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupboxEdit)).EndInit();
            this.groupboxEdit.ResumeLayout(false);
            this.groupboxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhKH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridKhachHangItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupboxEdit;
        private System.Windows.Forms.TextBox txtBenhAn;
        private DevExpress.XtraEditors.DateEdit dateNgaySinhKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btChangesKH;
        private DevExpress.XtraEditors.SimpleButton btXoaKH;
        private DevExpress.XtraEditors.SimpleButton btThemKH;
        private DevExpress.XtraEditors.SimpleButton btTuSinhMaKH;
        private System.Windows.Forms.RadioButton rbtTimMaKH;
        private System.Windows.Forms.RadioButton rbtTimTenKH;
        private System.Windows.Forms.Button btSearchKH;
        private DevExpress.XtraEditors.TextEdit txtSearchKH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}