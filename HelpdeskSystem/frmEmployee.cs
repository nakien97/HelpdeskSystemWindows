using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HelpdeskSystem
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
               User_lb.Text = "Welcome: " + MyPublic.USERNAME;
               Load_Profile();
               dgvFAQ.DataSource = Show_FAQ();
               dgvYC.DataSource = Show_YC();
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
            if (dt.Rows[0][6].ToString() != null)
            {
                imageAvatar.ImageLocation = dt.Rows[0][6].ToString();
                picPhotoProfile.ImageLocation = dt.Rows[0][6].ToString();
            }
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                imageAvatar.ImageLocation = imageLocation;
                changeAvatar(imageLocation);
            }
        }
        private void changeAvatar(string imageLocation)
        {
                MyPublic.ConnectDatabase();
                SqlCommand sqlCmd;
                string newPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "HelpdeskSystem") + "\\Avatar\\" + MyPublic.USERNAME + ".jpg";
                File.Copy(imageLocation, newPath, true);
                string query = "UPDATE NHANVIEN SET NV_AVATAR=@avatar WHERE NV_USERNAME=@username";
                sqlCmd = new SqlCommand(query, MyPublic.conn);
                sqlCmd.Parameters.AddWithValue("@avatar", newPath);
                sqlCmd.Parameters.AddWithValue("@username", MyPublic.USERNAME);
                sqlCmd.ExecuteNonQuery();
                picPhotoProfile.ImageLocation = newPath;

        }




        private void txtSearchFAQ_Enter(object sender, EventArgs e)
        {
            if (txtSearchFAQ.Text.Equals("ID or keyword"))
            {
                txtSearchFAQ.Text = "";
                txtSearchFAQ.ForeColor = Color.Black;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearchFAQ.Text;
            dgvFAQ.ClearSelection();
            foreach (DataGridViewRow row in dgvFAQ.Rows)
            {
                string data = (string)row.Cells[0].Value;
                if (id.Equals(data))
                {
                    row.Selected = true;
                }
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
                this.Close();
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
                string Sql = "select LSC_TEN from LOAI_SUCO";
                MyPublic.ConnectDatabase();
                SqlCommand cmd = new SqlCommand(Sql, MyPublic.conn);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    cbProlem.Items.Add(DR[0]);
                }
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


