namespace QLThuocBV
{
    partial class frmNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCC));
            this.gridNhaCC = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhaCCItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmanhacc = new System.Windows.Forms.TextBox();
            this.txttennhacc = new System.Windows.Forms.TextBox();
            this.txtdiachianhacc = new System.Windows.Forms.TextBox();
            this.txtsdtnhacc = new System.Windows.Forms.TextBox();
            this.btThemNhaCC = new DevExpress.XtraEditors.SimpleButton();
            this.btXoaNhaCC = new DevExpress.XtraEditors.SimpleButton();
            this.btLuuNhaCC = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhaCCItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gridNhaCC
            // 
            this.gridNhaCC.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridNhaCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridNhaCC.Location = new System.Drawing.Point(0, 155);
            this.gridNhaCC.MainView = this.gridViewNhaCCItem;
            this.gridNhaCC.Name = "gridNhaCC";
            this.gridNhaCC.Size = new System.Drawing.Size(864, 233);
            this.gridNhaCC.TabIndex = 0;
            this.gridNhaCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhaCCItem});
            // 
            // gridViewNhaCCItem
            // 
            this.gridViewNhaCCItem.GridControl = this.gridNhaCC;
            this.gridViewNhaCCItem.Name = "gridViewNhaCCItem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhà CC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhà CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "SĐT:";
            // 
            // txtmanhacc
            // 
            this.txtmanhacc.Location = new System.Drawing.Point(132, 6);
            this.txtmanhacc.Name = "txtmanhacc";
            this.txtmanhacc.Size = new System.Drawing.Size(226, 21);
            this.txtmanhacc.TabIndex = 2;
            this.txtmanhacc.Leave += new System.EventHandler(this.txtmanhacc_Leave);
            // 
            // txttennhacc
            // 
            this.txttennhacc.Location = new System.Drawing.Point(132, 39);
            this.txttennhacc.Name = "txttennhacc";
            this.txttennhacc.Size = new System.Drawing.Size(226, 21);
            this.txttennhacc.TabIndex = 2;
            // 
            // txtdiachianhacc
            // 
            this.txtdiachianhacc.Location = new System.Drawing.Point(132, 76);
            this.txtdiachianhacc.Name = "txtdiachianhacc";
            this.txtdiachianhacc.Size = new System.Drawing.Size(226, 21);
            this.txtdiachianhacc.TabIndex = 2;
            // 
            // txtsdtnhacc
            // 
            this.txtsdtnhacc.Location = new System.Drawing.Point(132, 107);
            this.txtsdtnhacc.Name = "txtsdtnhacc";
            this.txtsdtnhacc.Size = new System.Drawing.Size(226, 21);
            this.txtsdtnhacc.TabIndex = 2;
            // 
            // btThemNhaCC
            // 
            this.btThemNhaCC.Image = ((System.Drawing.Image)(resources.GetObject("btThemNhaCC.Image")));
            this.btThemNhaCC.Location = new System.Drawing.Point(394, 9);
            this.btThemNhaCC.Name = "btThemNhaCC";
            this.btThemNhaCC.Size = new System.Drawing.Size(83, 48);
            this.btThemNhaCC.TabIndex = 3;
            this.btThemNhaCC.Text = "Thêm";
            this.btThemNhaCC.Click += new System.EventHandler(this.btThemNhaCC_Click);
            // 
            // btXoaNhaCC
            // 
            this.btXoaNhaCC.Image = ((System.Drawing.Image)(resources.GetObject("btXoaNhaCC.Image")));
            this.btXoaNhaCC.Location = new System.Drawing.Point(394, 76);
            this.btXoaNhaCC.Name = "btXoaNhaCC";
            this.btXoaNhaCC.Size = new System.Drawing.Size(83, 48);
            this.btXoaNhaCC.TabIndex = 4;
            this.btXoaNhaCC.Text = "Xóa";
            this.btXoaNhaCC.Click += new System.EventHandler(this.btXoaNhaCC_Click);
            // 
            // btLuuNhaCC
            // 
            this.btLuuNhaCC.Image = ((System.Drawing.Image)(resources.GetObject("btLuuNhaCC.Image")));
            this.btLuuNhaCC.Location = new System.Drawing.Point(502, 11);
            this.btLuuNhaCC.Name = "btLuuNhaCC";
            this.btLuuNhaCC.Size = new System.Drawing.Size(83, 49);
            this.btLuuNhaCC.TabIndex = 4;
            this.btLuuNhaCC.Text = "Lưu";
            this.btLuuNhaCC.Click += new System.EventHandler(this.btLuuNhaCC_Click);
            // 
            // frmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 388);
            this.Controls.Add(this.btLuuNhaCC);
            this.Controls.Add(this.btXoaNhaCC);
            this.Controls.Add(this.btThemNhaCC);
            this.Controls.Add(this.txtsdtnhacc);
            this.Controls.Add(this.txtdiachianhacc);
            this.Controls.Add(this.txttennhacc);
            this.Controls.Add(this.txtmanhacc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridNhaCC);
            this.Name = "frmNhaCC";
            this.Text = "frmNhaCC";
            this.Load += new System.EventHandler(this.frmNhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhaCCItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridNhaCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhaCCItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmanhacc;
        private System.Windows.Forms.TextBox txttennhacc;
        private System.Windows.Forms.TextBox txtdiachianhacc;
        private System.Windows.Forms.TextBox txtsdtnhacc;
        private DevExpress.XtraEditors.SimpleButton btThemNhaCC;
        private DevExpress.XtraEditors.SimpleButton btXoaNhaCC;
        private DevExpress.XtraEditors.SimpleButton btLuuNhaCC;
    }
}