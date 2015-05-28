namespace QLThuocBV
{
    partial class frmBanThuoc
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
            this.lbItemThuoc = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btXuatHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rbtTheoToa = new System.Windows.Forms.RadioButton();
            this.rbtBanLe = new System.Windows.Forms.RadioButton();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.btTuSinhMaHD = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btThemHDToa = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaHDToa = new System.Windows.Forms.TextBox();
            this.btHoaDonToa = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgaySinhKH = new DevExpress.XtraEditors.DateEdit();
            this.btLayThongTinKH = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.rbtTieuChay = new System.Windows.Forms.RadioButton();
            this.rbtDauBung = new System.Windows.Forms.RadioButton();
            this.rbtNhucDau = new System.Windows.Forms.RadioButton();
            this.rbtCamCum = new System.Windows.Forms.RadioButton();
            this.txtBenhAn = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lbItemThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhKH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbItemThuoc
            // 
            this.lbItemThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItemThuoc.Location = new System.Drawing.Point(2, 21);
            this.lbItemThuoc.Name = "lbItemThuoc";
            this.lbItemThuoc.Size = new System.Drawing.Size(176, 487);
            this.lbItemThuoc.TabIndex = 1;
            this.lbItemThuoc.Click += new System.EventHandler(this.lbItemThuoc_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbItemThuoc);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(180, 510);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh Sách Thuốc";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(6, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã Thuốc:";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(110, 82);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.ReadOnly = true;
            this.txtMaThuoc.Size = new System.Drawing.Size(100, 21);
            this.txtMaThuoc.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(6, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Thuốc:";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(110, 109);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.ReadOnly = true;
            this.txtTenThuoc.Size = new System.Drawing.Size(100, 21);
            this.txtTenThuoc.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(6, 140);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Nhà Cung Cấp:";
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Location = new System.Drawing.Point(110, 136);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.ReadOnly = true;
            this.txtNhaCC.Size = new System.Drawing.Size(100, 21);
            this.txtNhaCC.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(231, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 16);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Đơn Giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(335, 55);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(100, 21);
            this.txtDonGia.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(231, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 17);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(335, 82);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 21);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Location = new System.Drawing.Point(231, 115);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 17);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Thành Tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.Lavender;
            this.txtThanhTien.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Italic);
            this.txtThanhTien.ForeColor = System.Drawing.Color.Red;
            this.txtThanhTien.Location = new System.Drawing.Point(335, 114);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(100, 28);
            this.txtThanhTien.TabIndex = 2;
            // 
            // btXuatHoaDon
            // 
            this.btXuatHoaDon.Location = new System.Drawing.Point(335, 176);
            this.btXuatHoaDon.Name = "btXuatHoaDon";
            this.btXuatHoaDon.Size = new System.Drawing.Size(85, 44);
            this.btXuatHoaDon.TabIndex = 3;
            this.btXuatHoaDon.Text = "Xuất Hóa Đơn";
            this.btXuatHoaDon.Click += new System.EventHandler(this.btXuatHoaDon_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rbtTheoToa);
            this.groupControl2.Controls.Add(this.rbtBanLe);
            this.groupControl2.Controls.Add(this.txtMaHoaDon);
            this.groupControl2.Controls.Add(this.btTuSinhMaHD);
            this.groupControl2.Controls.Add(this.btXuatHoaDon);
            this.groupControl2.Controls.Add(this.txtThanhTien);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtSoLuong);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtDonGia);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtNhaCC);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtTenThuoc);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtMaThuoc);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(180, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(456, 226);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chi Tiết Thuốc";
            // 
            // rbtTheoToa
            // 
            this.rbtTheoToa.AutoSize = true;
            this.rbtTheoToa.Location = new System.Drawing.Point(99, 203);
            this.rbtTheoToa.Name = "rbtTheoToa";
            this.rbtTheoToa.Size = new System.Drawing.Size(91, 17);
            this.rbtTheoToa.TabIndex = 6;
            this.rbtTheoToa.Text = "Bán Theo Toa";
            this.rbtTheoToa.UseVisualStyleBackColor = true;
            this.rbtTheoToa.Click += new System.EventHandler(this.rbtTheoToa_Click);
            // 
            // rbtBanLe
            // 
            this.rbtBanLe.AutoSize = true;
            this.rbtBanLe.Checked = true;
            this.rbtBanLe.Location = new System.Drawing.Point(11, 203);
            this.rbtBanLe.Name = "rbtBanLe";
            this.rbtBanLe.Size = new System.Drawing.Size(57, 17);
            this.rbtBanLe.TabIndex = 6;
            this.rbtBanLe.TabStop = true;
            this.rbtBanLe.Text = "Bán Lẻ";
            this.rbtBanLe.UseVisualStyleBackColor = true;
            this.rbtBanLe.Click += new System.EventHandler(this.rbtBanLe_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(110, 55);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(100, 21);
            this.txtMaHoaDon.TabIndex = 5;
            // 
            // btTuSinhMaHD
            // 
            this.btTuSinhMaHD.Location = new System.Drawing.Point(6, 24);
            this.btTuSinhMaHD.Name = "btTuSinhMaHD";
            this.btTuSinhMaHD.Size = new System.Drawing.Size(75, 23);
            this.btTuSinhMaHD.TabIndex = 4;
            this.btTuSinhMaHD.Text = "Thêm Mã HĐ";
            this.btTuSinhMaHD.Click += new System.EventHandler(this.btTuSinhMaHD_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Location = new System.Drawing.Point(6, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 16);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Mã Hóa Đơn:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btThemHDToa);
            this.groupControl3.Controls.Add(this.txtMaHDToa);
            this.groupControl3.Controls.Add(this.btHoaDonToa);
            this.groupControl3.Controls.Add(this.dateNgaySinhKH);
            this.groupControl3.Controls.Add(this.btLayThongTinKH);
            this.groupControl3.Controls.Add(this.txtTenKH);
            this.groupControl3.Controls.Add(this.rbtTieuChay);
            this.groupControl3.Controls.Add(this.rbtDauBung);
            this.groupControl3.Controls.Add(this.rbtNhucDau);
            this.groupControl3.Controls.Add(this.rbtCamCum);
            this.groupControl3.Controls.Add(this.txtBenhAn);
            this.groupControl3.Controls.Add(this.txtMaKH);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.labelControl12);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(180, 226);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(456, 284);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Bán Theo Toa";
            // 
            // btThemHDToa
            // 
            this.btThemHDToa.Location = new System.Drawing.Point(206, 57);
            this.btThemHDToa.Name = "btThemHDToa";
            this.btThemHDToa.Size = new System.Drawing.Size(75, 23);
            this.btThemHDToa.TabIndex = 9;
            this.btThemHDToa.Text = "Thêm Mã HĐ";
            this.btThemHDToa.Click += new System.EventHandler(this.btThemHDToa_Click);
            // 
            // txtMaHDToa
            // 
            this.txtMaHDToa.Location = new System.Drawing.Point(90, 59);
            this.txtMaHDToa.Name = "txtMaHDToa";
            this.txtMaHDToa.Size = new System.Drawing.Size(100, 21);
            this.txtMaHDToa.TabIndex = 8;
            // 
            // btHoaDonToa
            // 
            this.btHoaDonToa.Location = new System.Drawing.Point(344, 217);
            this.btHoaDonToa.Name = "btHoaDonToa";
            this.btHoaDonToa.Size = new System.Drawing.Size(76, 55);
            this.btHoaDonToa.TabIndex = 7;
            this.btHoaDonToa.Text = "Xuất Hóa Đơn";
            this.btHoaDonToa.Click += new System.EventHandler(this.btHoaDonToa_Click);
            // 
            // dateNgaySinhKH
            // 
            this.dateNgaySinhKH.EditValue = null;
            this.dateNgaySinhKH.Location = new System.Drawing.Point(90, 118);
            this.dateNgaySinhKH.Name = "dateNgaySinhKH";
            this.dateNgaySinhKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinhKH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinhKH.Size = new System.Drawing.Size(100, 20);
            this.dateNgaySinhKH.TabIndex = 6;
            // 
            // btLayThongTinKH
            // 
            this.btLayThongTinKH.Location = new System.Drawing.Point(206, 30);
            this.btLayThongTinKH.Name = "btLayThongTinKH";
            this.btLayThongTinKH.Size = new System.Drawing.Size(75, 23);
            this.btLayThongTinKH.TabIndex = 5;
            this.btLayThongTinKH.Text = "Lấy Thông Tin";
            this.btLayThongTinKH.Click += new System.EventHandler(this.btLayThongTinKH_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(90, 90);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(100, 21);
            this.txtTenKH.TabIndex = 4;
            // 
            // rbtTieuChay
            // 
            this.rbtTieuChay.AutoSize = true;
            this.rbtTieuChay.Location = new System.Drawing.Point(118, 224);
            this.rbtTieuChay.Name = "rbtTieuChay";
            this.rbtTieuChay.Size = new System.Drawing.Size(73, 17);
            this.rbtTieuChay.TabIndex = 3;
            this.rbtTieuChay.TabStop = true;
            this.rbtTieuChay.Text = "Tiêu Chảy";
            this.rbtTieuChay.UseVisualStyleBackColor = true;
            this.rbtTieuChay.Click += new System.EventHandler(this.rbtTieuChay_Click);
            // 
            // rbtDauBung
            // 
            this.rbtDauBung.AutoSize = true;
            this.rbtDauBung.Location = new System.Drawing.Point(118, 194);
            this.rbtDauBung.Name = "rbtDauBung";
            this.rbtDauBung.Size = new System.Drawing.Size(72, 17);
            this.rbtDauBung.TabIndex = 3;
            this.rbtDauBung.TabStop = true;
            this.rbtDauBung.Text = "Đau Bụng";
            this.rbtDauBung.UseVisualStyleBackColor = true;
            this.rbtDauBung.Click += new System.EventHandler(this.rbtDauBung_Click);
            // 
            // rbtNhucDau
            // 
            this.rbtNhucDau.AutoSize = true;
            this.rbtNhucDau.Location = new System.Drawing.Point(7, 224);
            this.rbtNhucDau.Name = "rbtNhucDau";
            this.rbtNhucDau.Size = new System.Drawing.Size(73, 17);
            this.rbtNhucDau.TabIndex = 3;
            this.rbtNhucDau.TabStop = true;
            this.rbtNhucDau.Text = "Nhức Đầu";
            this.rbtNhucDau.UseVisualStyleBackColor = true;
            this.rbtNhucDau.Click += new System.EventHandler(this.rbtNhucDau_Click);
            // 
            // rbtCamCum
            // 
            this.rbtCamCum.AutoSize = true;
            this.rbtCamCum.Location = new System.Drawing.Point(7, 193);
            this.rbtCamCum.Name = "rbtCamCum";
            this.rbtCamCum.Size = new System.Drawing.Size(70, 17);
            this.rbtCamCum.TabIndex = 3;
            this.rbtCamCum.TabStop = true;
            this.rbtCamCum.Text = "Cảm Cúm";
            this.rbtCamCum.UseVisualStyleBackColor = true;
            this.rbtCamCum.Click += new System.EventHandler(this.rbtCamCum_Click);
            // 
            // txtBenhAn
            // 
            this.txtBenhAn.Location = new System.Drawing.Point(90, 144);
            this.txtBenhAn.Name = "txtBenhAn";
            this.txtBenhAn.ReadOnly = true;
            this.txtBenhAn.Size = new System.Drawing.Size(100, 21);
            this.txtBenhAn.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(90, 32);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 21);
            this.txtMaKH.TabIndex = 2;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Location = new System.Drawing.Point(6, 120);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(62, 16);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "Ngày Sinh:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Location = new System.Drawing.Point(4, 147);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(56, 17);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "Bệnh Án:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Location = new System.Drawing.Point(6, 93);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 16);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Tên KH:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl12.Location = new System.Drawing.Point(6, 62);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(75, 16);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "Mã Hóa Đơn:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Location = new System.Drawing.Point(6, 36);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 16);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Mã KH:";
            // 
            // frmBanThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 510);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmBanThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình Bán Thuốc";
            this.Load += new System.EventHandler(this.frmBanThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbItemThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhKH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinhKH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl lbItemThuoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtNhaCC;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtThanhTien;
        private DevExpress.XtraEditors.SimpleButton btXuatHoaDon;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private DevExpress.XtraEditors.SimpleButton btTuSinhMaHD;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.RadioButton rbtTieuChay;
        private System.Windows.Forms.RadioButton rbtDauBung;
        private System.Windows.Forms.RadioButton rbtNhucDau;
        private System.Windows.Forms.RadioButton rbtCamCum;
        private System.Windows.Forms.TextBox txtBenhAn;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dateNgaySinhKH;
        private DevExpress.XtraEditors.SimpleButton btLayThongTinKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btHoaDonToa;
        private DevExpress.XtraEditors.SimpleButton btThemHDToa;
        private System.Windows.Forms.TextBox txtMaHDToa;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.RadioButton rbtTheoToa;
        private System.Windows.Forms.RadioButton rbtBanLe;


    }
}