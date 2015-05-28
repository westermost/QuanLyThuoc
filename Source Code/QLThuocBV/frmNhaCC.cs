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
    public partial class frmNhaCC : DevExpress.XtraEditors.XtraForm
    {
       
        public frmNhaCC()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            try
            {
                gridNhaCC.DataSource = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "Select_NhaCC").Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm Tra lại kết nối dữ liệu");
            }          
        }
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btThemNhaCC_Click(object sender, EventArgs e)
        {
            if ( txtmanhacc.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống Mã Nhà CC");
            }
            else
            {
                try
                {
                    string manhacc = txtmanhacc.Text.Trim();
                    string tennhacc = txttennhacc.Text.Trim();
                    string diachi = txtdiachianhacc.Text.Trim();
                    string sdt = txtsdtnhacc.Text.Trim();

                    SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "NhaCC_Them", manhacc, tennhacc, diachi, sdt);
                    loaddata();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btXoaNhaCC_Click(object sender, EventArgs e)
        {
            // Create an empty list.
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridViewNhaCCItem.SelectedRowsCount; i++)
            {
                if (gridViewNhaCCItem.GetSelectedRows()[i] >= 0)
                    rows.Add(gridViewNhaCCItem.GetDataRow(gridViewNhaCCItem.GetSelectedRows()[i]));
            }
            try
            {
                string manhacc = "";

                gridViewNhaCCItem.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    manhacc = row["MaNhacCC"].ToString();
                    SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "NhaCC_xoa", manhacc);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                gridViewNhaCCItem.EndUpdate();

            }
            loaddata();
        }

        private void btLuuNhaCC_Click(object sender, EventArgs e)
        {
            // Create an empty list.
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            for (int i = 0; i < gridViewNhaCCItem.SelectedRowsCount; i++)
            {
                if (gridViewNhaCCItem.GetSelectedRows()[i] >= 0)
                    rows.Add(gridViewNhaCCItem.GetDataRow(gridViewNhaCCItem.GetSelectedRows()[i]));
            }
            try
            {
                string manhacc = "";
                string tenhacc = "";
                string diachi = "";
                string sdt = "";
                gridViewNhaCCItem.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    manhacc = row["MaNhacCC"].ToString();
                    tenhacc = row["TenNhaCC"].ToString();
                    diachi = row["DiaChi"].ToString();
                    sdt = row["SoDT"].ToString();
                    
                    // namsx = row["NamSX"].ToString();
                    SqlHelper.ExecuteNonQuery(SQLStringConnect.strCon, "NhaCC_update", manhacc, tenhacc, diachi, sdt);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                gridViewNhaCCItem.EndUpdate();

            }
            loaddata();
        }

        // Kiểm Tra Xem Mã Nhà CC đã tồn tại hay chưa
        private void txtmanhacc_Leave(object sender, EventArgs e)
        {
            string x = txtmanhacc.Text.Trim();
            DataTable ds = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "NhaCC_KiemTraID", x).Tables[0];
            if (ds.Rows.Count > 0)
            {
                MessageBox.Show(" Mã Nhà Cung Cấp Đã Tồn Tại");
            }
        }

    }
}