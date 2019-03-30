using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HelpdeskSystem
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            dgvFAQ.DataSource = Show_FAQ();
            dgvYC.DataSource = Show_YC();
        }
        string suco;
        private void frmEmployee_Load(object sender, EventArgs e)
        {
               User_lb.Text = "Welcome: " + MyPublic.USERNAME;
               Load_Profile();
               Load_Avatar();
        }

        private void Load_Profile()
        {
            MyPublic.ConnectDatabase();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE NV_USERNAME='" + MyPublic.USERNAME + "'", MyPublic.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtPurview.Text = MyPublic.PURVIEW;
            txtName.Text = dt.Rows[0][3].ToString();
            txtPhone.Text = dt.Rows[0][4].ToString();
            txtEmail.Text = dt.Rows[0][5].ToString();
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if(open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    MyPublic.ConnectDatabase();
                    string CorrectFilename = System.IO.Path.GetFileName(open.FileName);
                    SqlCommand cmd = new SqlCommand("UPDATE NHANVIEN SET NV_AVATAR = '\\Images\\"+ CorrectFilename+ "' WHERE NV_USERNAME='" + MyPublic.USERNAME + "' ",MyPublic.conn);
                    cmd.ExecuteNonQuery();
                    MyPublic.conn.Close();
                    string patch = Application.StartupPath.Substring(0,(Application.StartupPath.Length -10));
                    System.IO.File.Copy(open.FileName,patch + "\\Images\\" + CorrectFilename);
                    MessageBox.Show("Succesfully");
                }
            }
        }
        private void Load_Avatar()
        {
            MyPublic.ConnectDatabase();
            SqlDataAdapter sda = new SqlDataAdapter("Select NV_AVATAR FROM NHANVIEN WHERE NV_USERNAME='" + MyPublic.USERNAME + "'",MyPublic.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            imageAvatar.Image = Image.FromFile(paths + dt.Rows[0]["NV_AVATAR"].ToString());
            picPhotoProfile.Image = Image.FromFile(paths + dt.Rows[0]["NV_AVATAR"].ToString());
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
                this.Close();
            }
        }
        private void linkOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to sign out?", "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        public DataTable Show_FAQ()
        {
            MyPublic.ConnectDatabase();
            string query = "SELECT * FROM FAQ";
            SqlCommand sqlCm = new SqlCommand(query, MyPublic.conn);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCm);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            MyPublic.conn.Close();
            sqlDa.Dispose();
            return dt;
        }
        public DataTable Show_YC()
        {
            MyPublic.ConnectDatabase();
            string query = "SELECT * FROM YEUCAU WHERE NV_USERNAME='" + MyPublic.USERNAME + "'";
            SqlCommand sqlCm = new SqlCommand(query, MyPublic.conn);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCm);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            MyPublic.conn.Close();
            sqlDa.Dispose();
            return dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbProlem.Items.Clear();
            try
            {
                      MyPublic.ConnectDatabase();
                      SqlDataAdapter sqlDa = new SqlDataAdapter("SELET * FROM LOAI_SUCO",MyPublic.conn);
                      DataTable dt = new DataTable();
                      sqlDa.Fill(dt);
                      cbProlem.ValueMember = "LSC_TEN";
                      cbProlem.DataSource = dt;
                      MyPublic.conn.Close();
            }  catch (Exception)
                {
                    MessageBox.Show("Connect database failed! ");
                }
            ResetFields(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFields(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void cbProlem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbProlem.SelectedIndex == -1) return;
           // suco = cbProlem.Text;
        }

        void ResetFields(bool status)
        {
            txtDescription.Clear();
            cbProlem.SelectedIndex = -1;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
            btnAdd.Enabled = !status;
        }

    }
}


