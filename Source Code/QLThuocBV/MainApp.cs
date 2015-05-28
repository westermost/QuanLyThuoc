using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraGrid.Views.Base;
using System.Collections;

namespace QLThuocBV
{
    public partial class MainApp : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public MainApp()
        {
            InitializeComponent();
           
        }

        #region=================Phần xử lý dữ liệu==============================
        // Hàm Load Data từ SQL ra GridView
        private void loaddata()
        {
            try
            {
                gridItemThuoc.DataSource = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "Thuoc_Select").Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm Tra lại kết nối dữ liệu");
            }
        }


        // Sự kiện: App chạy thì Data được load lên luôn trên Gridview
        private void MainApp_Load(object sender, EventArgs e)
        {
            loaddata();
        }


        #endregion============================================
       
       


        #region==================Xử Lý Form Các Kiểu=====================
        // Gọi Form AddItem
        private void btAddItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAddItem additem = new frmAddItem();
            additem.Show();
        }
        // Gọi Form KH
        private void btKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.Show();
        }
        // Gọi form NhaCC
        private void btNhaCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhaCC nhacc = new frmNhaCC();
            nhacc.Show();
        }

        private void btBanThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBanThuoc sell = new frmBanThuoc();
            sell.Show();



        }

        private void btHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.Show();
        }
        #endregion=======================================================


        #region==================Xử Lý Sự Kiện Các Nút=====================
        // Xóa dữ liệu
        private void btRemoveItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Create an empty list.
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
            }
            try
            {
                string mathuoc = "";

                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    mathuoc = row["MaThuoc"].ToString();
                    SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "xoa", mathuoc);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                gridView1.EndUpdate();

            }
            loaddata();

        }


        // Lưu thay đổi
        private void btChangesData_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Create an empty list.
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
            }
            try
            {
                string mathuoc = "";
                string manhacc = "";
                string tenthuoc = "";
                string namsx = DateTime.Now.ToShortDateString();
                string hsd = DateTime.Now.ToShortDateString();
                
                string slthuoc = "";                
                string dongia = "";
                string donvi = "";
                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    mathuoc = row["MaThuoc"].ToString();
                    manhacc = row["MaNhaCC"].ToString();
                    tenthuoc = row["TenThuoc"].ToString();
                    namsx = row["NamSX"].ToString();
                    hsd = row["HSD"].ToString();              
                    slthuoc = row["SoLuongThuoc"].ToString();           
                    dongia = row["DonGiaThuoc"].ToString();
                    donvi = row["DonViThuoc"].ToString();

                    SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "Thuoc_Update", mathuoc, manhacc, tenthuoc, namsx, hsd, slthuoc, dongia, donvi);
                    // Update lại Hóa Đơn Nhập
                    SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "HoaDonNhap_Update", manhacc, mathuoc, tenthuoc, slthuoc, dongia);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                gridView1.EndUpdate();

            }
            loaddata();

        }
        //Refresh Data
        private void btRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            loaddata();
        }
        // Search Data
        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtSearch.Text;
                DataTable ds = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "Thuoc_TimKiem", a).Tables[0];
                if (ds.Rows.Count == 0)
                {
                    MessageBox.Show("Không tồn tại Thuốc");
                }
                else
                {
                    gridItemThuoc.DataSource = ds;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        // Nút Exit Cho Application
        private void backstageViewTabItem1_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Application.Exit();
        }
        #endregion==================End Xử Lý Nút=====================================

       

        

        

        

       

       



     

        
    }
}