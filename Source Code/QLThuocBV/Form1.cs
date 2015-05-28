using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace QLThuocBV
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        MainApp formmain = new MainApp();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtPassword.Text.Trim();
                string pass = txtUsername.Text.Trim();
                DataTable dt = SqlHelper.ExecuteDataset(SQLStringConnect.strCon, "DangNhap_proc", user, pass).Tables[0];
                if (dt.Rows.Count > 0) // Dữ liệu trả về là 1 bảng nếu đúng thì bảng sẽ lớn hơn 0
                {

                    Hide();
                    formmain.Show();

                }
                else MessageBox.Show("Kiểm tra lại UserName/Password");
            }
            catch (Exception )
            {
                
            }
            
        }
    }
}
