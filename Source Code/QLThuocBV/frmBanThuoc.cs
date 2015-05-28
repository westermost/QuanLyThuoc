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
    public partial class frmBanThuoc : DevExpress.XtraEditors.XtraForm
    {
       
        public frmBanThuoc()
        {
            InitializeComponent();
            groupControl3.Visible = false;
            loadlistbox();
        }
        // Khi mở chương trình Bán Thuốc lên thì tự động thêm MÃ HÓA ĐƠN  tiếp theo
        private void frmBanThuoc_Load(object sender, EventArgs e)
        {
            btTuSinhMaHD.PerformClick();
        }
        // Tự động tính tiền
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = (Double.Parse(txtDonGia.Text) * Double.Parse(txtSoLuong.Text)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #region=================Xử lý Load Data============
        private void loadlistbox()
        {
            try
            {
                DataTable ds = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "Thuoc_Select").Tables[0];
                lbItemThuoc.DataSource = ds;
                lbItemThuoc.DisplayMember = "TenThuoc";
                lbItemThuoc.ValueMember = "MaThuoc";
            }
            catch (Exception)
            {

                MessageBox.Show("Kiểm Tra lại kết nối dữ liệu");
            }
        }

       
        #endregion==============End Xử Lý Load Data=============================

        #region======================XỬ LÝ EVENT CLICK=====================

        // Xuất Hóa Đơn Bán Lẻ
        private void btXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(txtSoLuong.Text);
                if (x > 0)
                {
                    try
                    {
                        string a = txtMaThuoc.Text;
                        string b = txtSoLuong.Text;
                        SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "BanThuoc_UpdateSLThuoc", a, b);
                        // Them thông tin Hoa Don vao Database Hoa Don Ban Le
                        string maphieuban = txtMaHoaDon.Text.Trim();
                        string mathuoc = txtMaThuoc.Text.Trim();
                        string tenthuoc = txtTenThuoc.Text.Trim();
                        string slthuoc = txtSoLuong.Text.Trim();
                        string dgthuoc = txtDonGia.Text.Trim();
                        string tongtien = txtThanhTien.Text.Trim();
                        DateTime ngaynhap = DateTime.Now;
                        // Chạy SQL
                        SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "HoaDonBanLe_Them", maphieuban, mathuoc, tenthuoc, slthuoc, dgthuoc, tongtien, ngaynhap);
                        btTuSinhMaHD.PerformClick(); //Tự Sinh Mã HĐ Tiếp Theo
                        MessageBox.Show("Xuất Thuốc Thành Công");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    // end try catch
                }
                else
                {
                    MessageBox.Show("Số Lượng Không Được Bé Hơn 0");
                }
                // end try catch kiem tra so luong
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            // End Try Catch Tổng
        }

        // Xuất Hóa Đơn Theo Toa
        private void btHoaDonToa_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(txtSoLuong.Text);
                if (x > 0)
                {
                    try
                    {             
                        string a = txtMaThuoc.Text;
                        string b = txtSoLuong.Text;
                        SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "BanThuoc_UpdateSLThuoc", a, b); // Update lại SL thuốc trong Kho sau khi bán
                        // Them thông tin Hoa Don vao Database Hoa Don Theo Toa
                        string maphieuban = txtMaHDToa.Text.Trim();
                        string mathuoc = txtMaThuoc.Text.Trim();
                        string tenthuoc = txtTenThuoc.Text.Trim();
                        string makh = txtMaKH.Text.Trim();
                        string slthuoc = txtSoLuong.Text.Trim();
                        string dgthuoc = txtDonGia.Text.Trim();
                        string tongtien = txtThanhTien.Text.Trim();
                        DateTime ngaynhap = DateTime.Now;
                        // Chạy SQL
                        SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "HoaDonXuat_Them", maphieuban, mathuoc, tenthuoc, makh, slthuoc, dgthuoc, tongtien, ngaynhap);
                        btThemHDToa.PerformClick(); //Tự Sinh Mã HĐ Tiếp Theo
                        MessageBox.Show("Xuất Thuốc Thành Công");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    // end try catch
                }
                else
                {
                    MessageBox.Show("Số Lượng Không Được Bé Hơn 0");
                }
                // end try catch kiem tra so luong
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            // End Try Catch Tổng
        }
     

        private void lbItemThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                string a = lbItemThuoc.Text;
                DataTable ds1 = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "BanThuoc_Select", a).Tables[0];
                txtTenThuoc.Text = lbItemThuoc.Text;
                if (ds1.Rows.Count > 0)
                {
                    txtMaThuoc.Text = ds1.Rows[0]["MaThuoc"].ToString();
                    txtNhaCC.Text = ds1.Rows[0]["MaNhaCC"].ToString();
                    txtDonGia.Text = ds1.Rows[0]["DonGiaThuoc"].ToString();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        // Tự sinh HD Bán Lẻ
        private void btTuSinhMaHD_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = sinhmaHDLe();
        }


        // Tự Sinh HĐ Theo Toa
        private void btThemHDToa_Click(object sender, EventArgs e)
        {
            txtMaHDToa.Text = sinhmaHDTheoToa();
        }

        private void btLayThongTinKH_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtMaKH.Text.Trim();
                string b = DateTime.Now.ToShortDateString();
                DataTable ds = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "KH_TimTheoMaKH", a).Tables[0];
                if (ds.Rows.Count > 0)
                {
                    txtTenKH.Text = ds.Rows[0]["TenKH"].ToString();
                    b = ds.Rows[0]["NgaySinhKH"].ToString();
                    dateNgaySinhKH.DateTime = Convert.ToDateTime(b);
                    txtBenhAn.Text = ds.Rows[0]["BenhAnKH"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tồn tại Khách Hàng có mã KH: " + a);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        #endregion===================End Event Click======================
        
       



        #region========================Hàm Tự Sinh Mã=================
        private string sinhmaHDLe()
        {
            QLThuocDataDataSetTableAdapters.QueriesTableAdapter q = new QLThuocDataDataSetTableAdapters.QueriesTableAdapter();
            string somaHDLe = "00" + q.qTuMinhMaHoaDonBanLe().ToString();
            somaHDLe = somaHDLe.Substring(somaHDLe.Length - 3, 3);
            return somaHDLe;
        }
        private string sinhmaHDTheoToa()
        {
            QLThuocDataDataSetTableAdapters.QueriesTableAdapter q = new QLThuocDataDataSetTableAdapters.QueriesTableAdapter();
            string somaHDToa = "00" + q.qTuSinhMaHoaDonTheoToa().ToString();
            somaHDToa = somaHDToa.Substring(somaHDToa.Length - 3, 3);
            return somaHDToa;
        }
        #endregion==================End Hàm Tự Sinh Mã================

          
        #region===========================XỬ LÝ RADIO BUTTON===========================
        private void rbtCamCum_Click(object sender, EventArgs e)
        {
            try
            {
                 DataTable cc = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "BanThuoc_Toa_CamCum").Tables[0];
                    if (cc.Rows.Count > 0)
                    {
                        txtMaThuoc.Text = cc.Rows[0]["MaThuoc"].ToString();
                        txtTenThuoc.Text = cc.Rows[0]["TenThuoc"].ToString();
                        txtNhaCC.Text = cc.Rows[0]["MaNhaCC"].ToString();
                        txtDonGia.Text = cc.Rows[0]["DonGiaThuoc"].ToString();
                        
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu");
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rbtDauBung_Click(object sender, EventArgs e)
        {
            try
            {
                 DataTable db = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "BanThuoc_Toa_DauBung").Tables[0];
                 if (db.Rows.Count > 0)
                 {
                     txtMaThuoc.Text = db.Rows[0]["MaThuoc"].ToString();
                     txtTenThuoc.Text = db.Rows[0]["TenThuoc"].ToString();
                     txtNhaCC.Text = db.Rows[0]["MaNhaCC"].ToString();
                     txtDonGia.Text = db.Rows[0]["DonGiaThuoc"].ToString();

                 }
                 else
                 {
                     MessageBox.Show("Không có dữ liệu");
                 }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rbtNhucDau_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable nd = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "BanThuoc_Toa_NhucDau").Tables[0];
                if (nd.Rows.Count > 0)
                {
                    txtMaThuoc.Text = nd.Rows[0]["MaThuoc"].ToString();
                    txtTenThuoc.Text = nd.Rows[0]["TenThuoc"].ToString();
                    txtNhaCC.Text = nd.Rows[0]["MaNhaCC"].ToString();
                    txtDonGia.Text = nd.Rows[0]["DonGiaThuoc"].ToString();

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rbtTieuChay_Click(object sender, EventArgs e)
        {
            try
            {
                 DataTable tc = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "BanThuoc_Toa_TieuChay").Tables[0];
                 if (tc.Rows.Count > 0)
                 {
                     txtMaThuoc.Text = tc.Rows[0]["MaThuoc"].ToString();
                     txtTenThuoc.Text = tc.Rows[0]["TenThuoc"].ToString();
                     txtNhaCC.Text = tc.Rows[0]["MaNhaCC"].ToString();
                     txtDonGia.Text = tc.Rows[0]["DonGiaThuoc"].ToString();

                 }
                 else
                 {
                     MessageBox.Show("Không có dữ liệu");
                 }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rbtBanLe_Click(object sender, EventArgs e)
        {
            groupControl3.Visible = false;
            txtMaHoaDon.Visible = true;
            btXuatHoaDon.Visible = true;
            lbItemThuoc.Visible = true;
            labelControl7.Visible = true;
            btTuSinhMaHD.PerformClick();
        }

        private void rbtTheoToa_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Visible = false;
            btXuatHoaDon.Visible = false;
            groupControl3.Visible = true;
            lbItemThuoc.Visible = false;
            labelControl7.Visible = false;
            btThemHDToa.PerformClick();
        }

        #endregion

       

        

       

      

       

        
       
    }
}