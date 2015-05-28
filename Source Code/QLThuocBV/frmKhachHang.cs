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
using System.Collections;
namespace QLThuocBV
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
       
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            try
            {
                gridKhachHangItem.DataSource = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "KH_Select").Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm Tra lại kết nối dữ liệu");
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private string sinhmakh()
        {
            QLThuocDataDataSetTableAdapters.QueriesTableAdapter q = new QLThuocDataDataSetTableAdapters.QueriesTableAdapter();
            string somakh = "00" + q.qTuSinhMa_KhachHang().ToString();
            somakh = somakh.Substring(somakh.Length - 3, 3);
            return somakh;
        }
        //=====================================Hàm Thêm====================================
        private void btThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = txtMaKH.Text.Trim();
                string tenkh = txtTenKH.Text.Trim();
                DateTime ngaysinh = dateNgaySinhKH.DateTime;
                string diachi = txtDiaChiKH.Text.Trim();
                string sdt = txtSDTKH.Text.Trim();
                string benhan = txtBenhAn.Text;
                SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "KH_Them", makh, tenkh, ngaysinh, diachi, sdt, benhan);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loaddata();
        }
        //======================Hàm Xóa Item===============================
        private void btXoaKH_Click(object sender, EventArgs e)
        {
            // Create an empty list.
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridView1.SelectedRowsCount; i++) // Hàm SelectedRowsCount có nhiệm vụ đếm số dòng hiện hành
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i])); 
            }
            try
            {
                string makh = "";

                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    makh = row["MaKH"].ToString();
                    SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "KH_Xoa", makh);
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
        // ===============Hàm Lưu Thay Đổi===================
        private void btChangesKH_Click(object sender, EventArgs e)
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
                string makh = "";
                string tenkh = "";
                string ngaysinh = DateTime.Now.ToShortDateString();
                string diachi = "";
                string sdt = "";
                string benhan = "";
                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    makh = row["MaKH"].ToString();
                    tenkh = row["TenKH"].ToString();
                    ngaysinh = row["NgaySinhKH"].ToString();
                    diachi = row["DiaChiKH"].ToString();
                    sdt = row["SoDTKH"].ToString();
                    benhan = row["BenhAnKH"].ToString();
                    // namsx = row["NamSX"].ToString();
                    SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "KH_CapNhat", makh, tenkh, ngaysinh, diachi, sdt, benhan);
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
        // Tự Sinh Mã KH Button Event
        private void btTuSinhMaKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = sinhmakh();
        }

        // ====================HÀM TÌM KIẾM==========================================================
        private void btSearchKH_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtSearchKH.Text;
                if (rbtTimMaKH.Checked == true && rbtTimTenKH.Checked == false)
                {
                    
                    DataTable ds1 = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "KH_TimTheoMaKH", a).Tables[0];
                    if (ds1.Rows.Count == 0)
                    {
                        MessageBox.Show("Không Tồn Tại Mã KH");
                    }
                    else
                    {
                        gridKhachHangItem.DataSource = ds1;
                    }
                }
                if (rbtTimTenKH.Checked == true && rbtTimMaKH.Checked == false)
                {
                    DataTable ds2 = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "KH_TimTheoTen", a).Tables[0];
                    if ( ds2.Rows.Count ==0)
                    {
                        MessageBox.Show("Không tồn tại KH tên:" +txtSearchKH.Text );
                    }
                    else
                    {
                        gridKhachHangItem.DataSource = ds2;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSDTKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                if (Char.IsLetter(control.Text[control.Text.Length - 1]))
                {
                    txtSDTKH.Clear();
                    this.errorProvider1.SetError(control, "Không Nhập Chuỗi");
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

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            string x = txtMaKH.Text.Trim();
            DataTable ds = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "KH_KiemTraID", x).Tables[0];
            if (ds.Rows.Count > 0)
            {
                MessageBox.Show(" Mã Khách Hàng Đã Tồn Tại");
            }
        }
    }
}