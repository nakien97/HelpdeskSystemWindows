using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HelpdeskSystem
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            Show_YC(dgvYC);
        }
        string userName = MyPublic.USERNAME;
        SqlConnection con = new SqlConnection(@"server=DESKTOP-FS2GKEF; database = HelpdeskSystem; User Id=sa; Password=1234");
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            User_lb.Text = "Welcome: " + MyPublic.USERNAME;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE NV_USERNAME='" + MyPublic.USERNAME + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtPurview.Text = MyPublic.PURVIEW;
            txtName.Text = dt.Rows[0][3].ToString();
            txtPhone.Text = dt.Rows[0][4].ToString();
            txtEmail.Text = dt.Rows[0][5].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                imageAvatar.ImageLocation = imageLocation;
            }
        }

        private void txtSearchFAQ_Enter(object sender, EventArgs e)
        {
            if (txtSearchFAQ.Text.Equals("ID or keyword"))
            {
                txtSearchFAQ.Text = "";
                txtSearchFAQ.ForeColor = Color.Black;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                int x = 20;
                int y = 20;
                int maxHeight = -1;
                foreach (string imgUrl in files)
                {
                    PictureBox picture = new PictureBox();
                    picture.Image = Image.FromFile(imgUrl);
                    picture.Location = new Point(x, y);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    x += picture.Width + 10;
                    maxHeight = Math.Max(picture.Height, maxHeight);
                    if (x > this.ClientSize.Width - 100)
                    {
                        x = 20;
                        y += maxHeight + 10;
                    }
                    this.pnImage.Controls.Add(picture);
                }

            }
        }

        private void frmEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to sign out?", "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
               // frmLogin login = new frmLogin();
               // login.ShowDialog();
                this.Close();
            }
        }
        private void linkOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to sign out?", "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
               // frmLogin login = new frmLogin();
               // login.ShowDialog();
                this.Close();
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd;
            SqlDataReader sqlDr;
            string query;
            try
            {
                MyPublic.ConnectDatabase();
                if (MyPublic.conn.State == ConnectionState.Open)
                {
                    query = "INSERT INTO YEUCAU()";
                    sqlCmd = new SqlCommand(query, MyPublic.conn);
                    sqlCmd.Parameters.AddWithValue("",richtxtDescription);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect failed! " + ex.Message);
            }
        }
        private void Show_YC(DataGridView dgv)
        {     
        }

    }
 }


