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

namespace HelpdeskSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private bool isLoginSuccess(string userName, string password)
        {
            bool check = false;
            SqlCommand sqlCmd;
            SqlDataReader sqlDr;
            string query; 
            try
            {
                MyPublic.ConnectDatabase();
                if(MyPublic.conn.State == ConnectionState.Open)
                {
                    query = "SELECT VT_MA FROM NGUOIDUNG WHERE ND_USERNAME=@USERNAME AND ND_PASSWORD=@PASSWORD";
                    sqlCmd = new SqlCommand(query, MyPublic.conn);
                    sqlCmd.Parameters.AddWithValue("@USERNAME", userName);
                    sqlCmd.Parameters.AddWithValue("@PASSWORD", password);
                    sqlDr = sqlCmd.ExecuteReader();
                    if (sqlDr.HasRows)
                    {
                        MyPublic.USERNAME = userName;
                        sqlDr.Read();
                        MyPublic.PURVIEW = sqlDr.GetString(0);
                        sqlDr.Close();
                        check = true;
                        MyPublic.conn.Close();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Connect failed! " + e.Message);
            }
            return check;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            if (userName.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Username and password can't be empty!");
            }
            else if (isLoginSuccess(userName, password)) 
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Login successful!");
                this.Hide();
                if (MyPublic.PURVIEW.Equals("NV"))
                {
                    frmEmployee f = new frmEmployee();
                    f.ShowDialog();
                }
                else if (MyPublic.PURVIEW.Equals("NVQL"))
                {
                    frmAdmin f = new frmAdmin();
                    f.ShowDialog();
                }
                else if (MyPublic.PURVIEW.Equals("KTV"))
                {
                    frmTechnician f = new frmTechnician();
                    f.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Username or password incorrect!");
            } 
        }
        
    }
}
