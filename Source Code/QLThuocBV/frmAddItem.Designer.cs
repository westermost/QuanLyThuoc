namespace QLThuocBV
{
    partial class frmAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItem));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.dateNamSX = new DevExpress.XtraEditors.DateEdit();
            this.dateHSD = new DevExpress.XtraEditors.DateEdit();
            this.btThemItem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSLThuoc = new System.Windows.Forms.TextBox();
            this.txtDonGiaThuoc = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonViThuoc = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoPhieuNhap = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.dateNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.btThemMa = new DevExpress.XtraEditors.SimpleButton();
            this.cbMaNhaCC = new System.Windows.Forms.ComboBox();
            this.qLThuocDataDataSet = new QLThuocBV.QLThuocDataDataSet();
            this.nhacCCBindingSource = new System.Windows.Forms.BindingSource();
            this.nhacCCTableAdapter = new QLThuocBV.QLThuocDataDataSetTableAdapters.NhacCCTableAdapter();
            this.nhacCCBindingSource1 = new System.Windows.Forms.BindingSource();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btInHoaDonNhap = new DevExpress.XtraEditors.SimpleButton();
            this.checkBoxMaPhieuMua = new System.Windows.Forms.CheckBox();
            this.checkBoxMaThuoc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamSX.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHSD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuocDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacCCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Location = new System.Drawing.Point(9, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Thuốc:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Location = new System.Drawing.Point(9, 175);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Nhà CC:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Location = new System.Drawing.Point(9, 214);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 22);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên Thuốc:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl4.Location = new System.Drawing.Point(9, 253);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 22);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Năm Sản Xuất:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl5.Location = new System.Drawing.Point(9, 290);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 21);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "HSD:";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(164, 92);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.ReadOnly = true;
            this.txtMaThuoc.Size = new System.Drawing.Size(100, 21);
            this.txtMaThuoc.TabIndex = 1;
            this.txtMaThuoc.Leave += new System.EventHandler(this.txtMaThuoc_Leave);
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(164, 212);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(209, 21);
            this.txtTenThuoc.TabIndex = 1;
            // 
            // dateNamSX
            // 
            this.dateNamSX.EditValue = null;
            this.dateNamSX.Location = new System.Drawing.Point(164, 254);
            this.dateNamSX.Name = "dateNamSX";
            this.dateNamSX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNamSX.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNamSX.Size = new System.Drawing.Size(100, 20);
            this.dateNamSX.TabIndex = 2;
            // 
            // dateHSD
            // 
            this.dateHSD.EditValue = null;
            this.dateHSD.Location = new System.Drawing.Point(164, 289);
            this.dateHSD.Name = "dateHSD";
            this.dateHSD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHSD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHSD.Size = new System.Drawing.Size(100, 20);
            this.dateHSD.TabIndex = 2;
            // 
            // btThemItem
            // 
            this.btThemItem.Image = ((System.Drawing.Image)(resources.GetObject("btThemItem.Image")));
            this.btThemItem.Location = new System.Drawing.Point(192, 378);
            this.btThemItem.Name = "btThemItem";
            this.btThemItem.Size = new System.Drawing.Size(137, 42);
            this.btThemItem.TabIndex = 3;
            this.btThemItem.Text = "Thêm Thuốc ";
            this.btThemItem.Click += new System.EventHandler(this.btThemItem_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl6.Location = new System.Drawing.Point(286, 251);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 22);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Số Lượng:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl7.Location = new System.Drawing.Point(286, 286);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 21);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Đơn Giá:";
            // 
            // txtSLThuoc
            // 
            this.txtSLThuoc.Location = new System.Drawing.Point(379, 253);
            this.txtSLThuoc.Name = "txtSLThuoc";
            this.txtSLThuoc.Size = new System.Drawing.Size(159, 21);
            this.txtSLThuoc.TabIndex = 1;
            this.txtSLThuoc.TextChanged += new System.EventHandler(this.txtSLThuoc_TextChanged);
            // 
            // txtDonGiaThuoc
            // 
            this.txtDonGiaThuoc.Location = new System.Drawing.Point(379, 286);
            this.txtDonGiaThuoc.Name = "txtDonGiaThuoc";
            this.txtDonGiaThuoc.Size = new System.Drawing.Size(159, 21);
            this.txtDonGiaThuoc.TabIndex = 1;
            this.txtDonGiaThuoc.TextChanged += new System.EventHandler(this.txtDonGiaThuoc_TextChanged);
            this.txtDonGiaThuoc.Leave += new System.EventHandler(this.txtDonGiaThuoc_Leave);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl8.Location = new System.Drawing.Point(9, 326);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 22);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Đơn Vị:";
            // 
            // txtDonViThuoc
            // 
            this.txtDonViThuoc.Location = new System.Drawing.Point(164, 324);
            this.txtDonViThuoc.Name = "txtDonViThuoc";
            this.txtDonViThuoc.Size = new System.Drawing.Size(100, 21);
            this.txtDonViThuoc.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl9.Location = new System.Drawing.Point(286, 325);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(87, 22);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTongTien.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtTongTien.Location = new System.Drawing.Point(379, 324);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(159, 21);
            this.txtTongTien.TabIndex = 1;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl10.Location = new System.Drawing.Point(9, 52);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(117, 22);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Mã Phiếu Mua:";
            // 
            // txtSoPhieuNhap
            // 
            this.txtSoPhieuNhap.Location = new System.Drawing.Point(164, 55);
            this.txtSoPhieuNhap.Name = "txtSoPhieuNhap";
            this.txtSoPhieuNhap.ReadOnly = true;
            this.txtSoPhieuNhap.Size = new System.Drawing.Size(100, 21);
            this.txtSoPhieuNhap.TabIndex = 4;
            this.txtSoPhieuNhap.Leave += new System.EventHandler(this.txtSoPhieuNhap_Leave);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl11.Location = new System.Drawing.Point(10, 133);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(148, 22);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Ngày Nhập Thuốc:";
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.EditValue = null;
            this.dateNgayNhap.Location = new System.Drawing.Point(164, 133);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Size = new System.Drawing.Size(100, 20);
            this.dateNgayNhap.TabIndex = 5;
            // 
            // btThemMa
            // 
            this.btThemMa.Location = new System.Drawing.Point(12, 12);
            this.btThemMa.Name = "btThemMa";
            this.btThemMa.Size = new System.Drawing.Size(75, 23);
            this.btThemMa.TabIndex = 6;
            this.btThemMa.Text = "Thêm Mã";
            this.btThemMa.Click += new System.EventHandler(this.btThemMa_Click);
            // 
            // cbMaNhaCC
            // 
            this.cbMaNhaCC.FormattingEnabled = true;
            this.cbMaNhaCC.Location = new System.Drawing.Point(164, 173);
            this.cbMaNhaCC.Name = "cbMaNhaCC";
            this.cbMaNhaCC.Size = new System.Drawing.Size(100, 21);
            this.cbMaNhaCC.TabIndex = 7;
            // 
            // qLThuocDataDataSet
            // 
            this.qLThuocDataDataSet.DataSetName = "QLThuocDataDataSet";
            this.qLThuocDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhacCCBindingSource
            // 
            this.nhacCCBindingSource.DataMember = "NhacCC";
            this.nhacCCBindingSource.DataSource = this.qLThuocDataDataSet;
            // 
            // nhacCCTableAdapter
            // 
            this.nhacCCTableAdapter.ClearBeforeFill = true;
            // 
            // nhacCCBindingSource1
            // 
            this.nhacCCBindingSource1.DataMember = "NhacCC";
            this.nhacCCBindingSource1.DataSource = this.qLThuocDataDataSet;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(12, 430);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(329, 13);
            this.labelControl12.TabIndex = 8;
            this.labelControl12.Text = "Khi thêm 1 thuốc mới thì chương trình tự tạo hóa đơn cho phiếu nhập";
            // 
            // btInHoaDonNhap
            // 
            this.btInHoaDonNhap.Image = ((System.Drawing.Image)(resources.GetObject("btInHoaDonNhap.Image")));
            this.btInHoaDonNhap.Location = new System.Drawing.Point(350, 378);
            this.btInHoaDonNhap.Name = "btInHoaDonNhap";
            this.btInHoaDonNhap.Size = new System.Drawing.Size(137, 42);
            this.btInHoaDonNhap.TabIndex = 9;
            this.btInHoaDonNhap.Text = "In Hóa Đơn Nhập";
            this.btInHoaDonNhap.Visible = false;
            // 
            // checkBoxMaPhieuMua
            // 
            this.checkBoxMaPhieuMua.AutoSize = true;
            this.checkBoxMaPhieuMua.Location = new System.Drawing.Point(274, 57);
            this.checkBoxMaPhieuMua.Name = "checkBoxMaPhieuMua";
            this.checkBoxMaPhieuMua.Size = new System.Drawing.Size(72, 17);
            this.checkBoxMaPhieuMua.TabIndex = 10;
            this.checkBoxMaPhieuMua.Text = "Nhập Tay";
            this.checkBoxMaPhieuMua.UseVisualStyleBackColor = true;
            this.checkBoxMaPhieuMua.Click += new System.EventHandler(this.checkBoxMaPhieuMua_Click);
            // 
            // checkBoxMaThuoc
            // 
            this.checkBoxMaThuoc.AutoSize = true;
            this.checkBoxMaThuoc.Location = new System.Drawing.Point(274, 96);
            this.checkBoxMaThuoc.Name = "checkBoxMaThuoc";
            this.checkBoxMaThuoc.Size = new System.Drawing.Size(72, 17);
            this.checkBoxMaThuoc.TabIndex = 10;
            this.checkBoxMaThuoc.Text = "Nhập Tay";
            this.checkBoxMaThuoc.UseVisualStyleBackColor = true;
            this.checkBoxMaThuoc.Click += new System.EventHandler(this.checkBoxMaThuoc_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.checkBoxMaThuoc);
            this.Controls.Add(this.checkBoxMaPhieuMua);
            this.Controls.Add(this.btInHoaDonNhap);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.cbMaNhaCC);
            this.Controls.Add(this.btThemMa);
            this.Controls.Add(this.dateNgayNhap);
            this.Controls.Add(this.txtSoPhieuNhap);
            this.Controls.Add(this.btThemItem);
            this.Controls.Add(this.dateHSD);
            this.Controls.Add(this.dateNamSX);
            this.Controls.Add(this.txtDonViThuoc);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtDonGiaThuoc);
            this.Controls.Add(this.txtSLThuoc);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.txtMaThuoc);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmAddItem";
            this.Text = "frmAddItem";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateNamSX.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHSD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuocDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacCCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private DevExpress.XtraEditors.DateEdit dateNamSX;
        private DevExpress.XtraEditors.DateEdit dateHSD;
        private DevExpress.XtraEditors.SimpleButton btThemItem;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtSLThuoc;
        private System.Windows.Forms.TextBox txtDonGiaThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtDonViThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox txtSoPhieuNhap;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit dateNgayNhap;
        private DevExpress.XtraEditors.SimpleButton btThemMa;
        private QLThuocDataDataSet qLThuocDataDataSet;
        private System.Windows.Forms.BindingSource nhacCCBindingSource;
        private QLThuocDataDataSetTableAdapters.NhacCCTableAdapter nhacCCTableAdapter;
        private System.Windows.Forms.BindingSource nhacCCBindingSource1;
        private System.Windows.Forms.ComboBox cbMaNhaCC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton btInHoaDonNhap;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.CheckBox checkBoxMaThuoc;
        private System.Windows.Forms.CheckBox checkBoxMaPhieuMua;
    }
}