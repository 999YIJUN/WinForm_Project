using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace POS_system
{
    public partial class FrmLogin : Form
    {
        SqlConnectionStringBuilder scsb;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";           // 伺服器名稱 (ipAddress, 網域名稱(db), localhost, cr機器名稱
            scsb.InitialCatalog = "POS_DB";  // 資料庫名稱
            scsb.IntegratedSecurity = true; // Windows 驗證

            GlobalVar.strMyDBConnectionString = scsb.ConnectionString;
            GlobalVar.image_dir = @"D:\Desktop\repos\POS_system\TestPicture\";

            txtName.Text = "ROLEX";
            txtPassword.Text = "ROLEX2000";
            txtPassword.UseSystemPasswordChar = true;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                string strName = txtName.Text.Trim();
                string strPassword = txtPassword.Text.Trim();
                using (SqlConnection con = new SqlConnection(GlobalVar.strMyDBConnectionString))
                {
                    try
                    {
                        con.Open();
                        string strSQL = "select EmployeeID, EmployeeName, e_password from EMPLOYEE where EmployeeName = @NewName and e_password = @NewPassword;";
                        //string strSQL = "SELECT EmployeeID, EmployeeName, e_password FROM EMPLOYEE WHERE EmployeeName = @NewName COLLATE SQL_Latin1_General_CP1_CS_AS AND e_password = @NewPassword COLLATE SQL_Latin1_General_CP1_CS_AS";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("NewName", strName);
                        cmd.Parameters.AddWithValue("NewPassword", strPassword);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int employeeID = reader.GetInt32(0);
                                string employeeName = reader.GetString(1);

                                GlobalVar.isLoginSuccess = true;
                                GlobalVar.strName = employeeName;

                                this.Hide();
                                FrmStartMenu.GetInstance().ShowDialog();
                            }
                            else
                            {
                                GlobalVar.isLoginSuccess = false;
                                MessageBox.Show("用戶名或密碼錯誤");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } 
            }
            else
            {
                MessageBox.Show("請輸入用戶名和密碼");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= true;
            }
        }
    }
}
