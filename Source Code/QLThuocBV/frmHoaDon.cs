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
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            try
            {
                
                gridConTrolItemHoaDon.DataSource = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "HoaDonNhap_Select").Tables[0];
                gridControlItemHoaDonBanLe.DataSource = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "HoaDonBanLe_Select").Tables[0];
                gridControlItemHoaDonKeToa.DataSource = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "HoaDonXuat_Select").Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm Tra lại kết nối dữ liệu");
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loaddata();
        }

    }
}