using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
namespace QLThuocBV
{
    public partial class frmAddItem : DevExpress.XtraEditors.XtraForm
    {
        
        public frmAddItem()
        {
            InitializeComponent();                       
        }
        // 
        private void frmAddItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuocDataDataSet.NhacCC' table. You can move, or remove it, as needed.
            //this.nhacCCTableAdapter.Fill(this.qLThuocDataDataSet.NhacCC);
            // Load Data cho Combox
            DataTable ds = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "NhaCC_SelectCombox").Tables[0];
            cbMaNhaCC.DataSource = ds;
            cbMaNhaCC.DisplayMember = "MaNhacCC";
            cbMaNhaCC.ValueMember = "MaNhacCC";
        }

        private void btThemItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(txtSLThuoc.Text); 
                int xx = DateTime.Compare(dateNamSX.DateTime, dateHSD.DateTime); // So sánh Năm SX vs HSD xem có đúng logic không (Năm SX < HSD)
                if (x > 0 ) // kiểm tra xem số lượng thuốc nhập vào có lớn hơn 0 ko. Lớn hơn mới cho phép nhập hàng
                {
                    if (xx == -1 && xx == 0) // Nếu Năm SX lớn hơn HSD ==> Sai Logic thì hàm xx trả về giá trị là 1 còn đúng Logic là -1
                    {
                        try
                        {
                            string sophieunhap = txtSoPhieuNhap.Text.Trim();
                            string mathuoc = txtMaThuoc.Text.Trim();
                            string manhacc = cbMaNhaCC.Text;
                            DateTime ngaynhap = dateNgayNhap.DateTime;
                            string tenthuoc = txtTenThuoc.Text.Trim();
                            DateTime namsx = dateNamSX.DateTime;
                            DateTime hsd = dateHSD.DateTime;
                            string slthuoc = txtSLThuoc.Text.Trim();
                            string dgthuoc = txtDonGiaThuoc.Text.Trim();
                            string dvthuoc = txtDonViThuoc.Text.Trim();
                            string tongtien = txtTongTien.Text.Trim();
                            SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "Thuoc_Them", mathuoc, manhacc, tenthuoc, namsx, hsd, slthuoc, dgthuoc, dvthuoc);
                            SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "HoaDonNhap_Them", sophieunhap, manhacc, ngaynhap, mathuoc, tenthuoc, slthuoc, dgthuoc, tongtien);
                            MessageBox.Show("Thêm Thành Công");
                            btInHoaDonNhap.Visible = true; // Hiện nút in hóa đơn
                            btThemMa.PerformClick(); // Tự động gọi hàm Thêm Mã
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        // End Try catch
                    }
                    else
                    {
                        MessageBox.Show("Năm SX không được nhỏ hơn HSD hoặc bằng nhau");
                    }
                    // End Kiểm Tra HSD

                }
                else
                {
                    MessageBox.Show("Số lượng không được ít hơn 0");
                }
                // End Kiểm Tra Logic Số Lượng 
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // End Try catch Tổng
         
           
        }
        private void btThemMa_Click(object sender, EventArgs e)
        {
           
            txtMaThuoc.Text = sinhmathuoc();
            txtSoPhieuNhap.Text = sinhmaHoaDon();
            dateNgayNhap.DateTime = DateTime.Now;
            // xóa Dữ liệu hiện hành trên TextBox
            txtTenThuoc.Clear();
            txtDonViThuoc.Clear();           
            txtTongTien.Clear();
        }
        


        #region=======Sử Lý Sự Kiện TextBox========================
        // Kiểm tra nhập liệu Đơn Giá
        private void txtDonGiaThuoc_TextChanged(object sender, EventArgs e)
        {

            try
            {
                Control control = (Control)sender;
                if (Char.IsLetter(control.Text[control.Text.Length - 1]))
                {

                    this.errorProvider1.SetError(control, "Không Nhập Chuỗi");
                    txtDonGiaThuoc.Clear();
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
       
        }

        // Tự tính tổng
        private void txtDonGiaThuoc_Leave(object sender, EventArgs e)
        {
            try
            {
                 txtTongTien.Text = (Double.Parse(txtSLThuoc.Text) * Double.Parse(txtDonGiaThuoc.Text)).ToString();
            }
            catch (Exception )
            {

                MessageBox.Show("Vui lòng không để trống đơn giá");
            }
        }
        // Cái này bỏ Update sau
        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            //double temp = Convert.ToDouble(txtTongTien.Text);
            //txtTongTien.Text = temp.ToString("#,###");
        }

        // Kiểm nhập nhập liệu SL Thuốc
        private void txtSLThuoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                 if (Char.IsLetter(control.Text[control.Text.Length -1]))
                 {
                     this.errorProvider1.SetError(control, "Không Nhập Chuỗi");
                     txtSLThuoc.Clear();
                 }
                else
                 {
                      this.errorProvider1.Clear();
                 }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       // Tự Sinh mã Thuốc
        private string sinhmathuoc()
        {
            QLThuocDataDataSetTableAdapters.QueriesTableAdapter q = new QLThuocDataDataSetTableAdapters.QueriesTableAdapter();
            string somathuoc = "00" + q.qTuSinhMaThuoc().ToString();
            somathuoc = somathuoc.Substring(somathuoc.Length - 3, 3);
            return somathuoc;
        }
        // Tự Sinh mã Hóa đơn
        private string sinhmaHoaDon()
        {
            QLThuocDataDataSetTableAdapters.QueriesTableAdapter q = new QLThuocDataDataSetTableAdapters.QueriesTableAdapter();
            string sohoadon = "00" + q.qTuSinhMaHoaDon().ToString();
            sohoadon = sohoadon.Substring(sohoadon.Length - 3, 3);
            return sohoadon;
        }
        #endregion===============End Event TextBox====================================



        #region=======================Event Check Box=================================
        private void checkBoxMaPhieuMua_Click(object sender, EventArgs e)
        {
            if (checkBoxMaPhieuMua.Checked == true)
            {
                txtSoPhieuNhap.ReadOnly = false;
            }
            else
            {
                txtSoPhieuNhap.ReadOnly = true;
            }
        }

        private void checkBoxMaThuoc_Click(object sender, EventArgs e)
        {
            if (checkBoxMaThuoc.Checked == true)
            {
                txtMaThuoc.ReadOnly = false;

            }
            else
            {
                txtMaThuoc.ReadOnly = true;
            }
        }
        #endregion====================End Event Check Box=========================

        // Check mã Phiếu Xem có tồn tại rồi hay chưa sau khi nhập xong Textbox
        private void txtSoPhieuNhap_Leave(object sender, EventArgs e)
        {
            string x = txtSoPhieuNhap.Text.Trim();
            DataTable ds = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "HoaDonNhap_KiemTraID", x).Tables[0];
            if (ds.Rows.Count > 0 )
            {
                MessageBox.Show("Số Phiếu Nhập Đã Tồn Tại");                
            }
       
        }

        // Check mã Thuốc Xem có tồn tại rồi hay chưa sau khi nhập xong Textbox
        private void txtMaThuoc_Leave(object sender, EventArgs e)
        {
            string x = txtMaThuoc.Text.Trim();
            DataTable ds = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "Thuoc_KiemTraID", x).Tables[0];
            if (ds.Rows.Count > 0)
            {
                MessageBox.Show(" Mã Thuốc Đã Tồn Tại");
            }
        }












    }
}