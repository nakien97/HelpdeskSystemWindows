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

        DataView dvSuco = new DataView();
        DataSet dsSuCo = new DataSet();

        //Form Load
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            User_lb.Text = "Welcome: " + MyPublic.USERNAME;
            Load_Profile();
            dgvFAQ.DataSource = Show_FAQ();
            dgvYC.DataSource = Show_YC();
            Load_cbProlem();
            ResetFields(false);
            cbProlem.Enabled = false;
            txtNamepro.Enabled = false;
            txtDescription.Enabled = false;
            btnUpload.Enabled = false;
        }

        //Profile
        private void Load_Profile()
        {
            MyPublic.ConnectDatabase();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE ND_USERNAME='" + MyPublic.USERNAME + "'", MyPublic.conn);
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

        //Change Avatar
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
            string query = "UPDATE NHANVIEN SET NV_AVATAR=@avatar WHERE ND_USERNAME=@username";
            sqlCmd = new SqlCommand(query, MyPublic.conn);
            sqlCmd.Parameters.AddWithValue("@avatar", newPath);
            sqlCmd.Parameters.AddWithValue("@username", MyPublic.USERNAME);
            sqlCmd.ExecuteNonQuery();
            picPhotoProfile.ImageLocation = newPath;

        }
        //Change Avatar


        String[] url = null;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                url = files;
                int x = 20;
                int y = 20;
                int i = 0;
                int maxHeight = -1;
                foreach (string imgUrl in files)
                {
                    i++;
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

        public DataTable Show_FAQ()
        {
            DataTable dt = new DataTable();
            if (MyPublic.conn.State == ConnectionState.Open)
            {
                string query = "SELECT FAQ_MA AS ID, FAQ_CAUHOI AS QUESTION , FAQ_TRALOI AS ANSWER FROM FAQ WHERE CHO_NHAN_VIEN = 'True'";
                SqlCommand sqlCmd = new SqlCommand(query, MyPublic.conn);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                sqlDa.Fill(dt);
                sqlDa.Dispose();
            }
            return dt;
        }
        public DataTable Show_YC()
        {
            MyPublic.ConnectDatabase();
            string query = "SELECT LSC.LSC_TEN AS TYPE,YC.YC_TENSUCO as NAME,YC.YC_NGAY AS DATE,YC.YC_THONGTINKEMTHEO AS CONTENT ,TT.TT_TEN AS STATE,XL.THOI_GIAN_HOAN_THANH AS FINISH FROM YEUCAU as YC inner join LOAI_SUCO as LSC on YC.LSC_MA = LSC.LSC_MA inner join TRANGTHAI as TT on YC.TT_MA = TT.TT_MA inner join XULY_SUCO as XL on YC.YC_STT = XL.YC_STT WHERE ND_USERNAME='" + MyPublic.USERNAME + "'";
            SqlCommand sqlCm = new SqlCommand(query, MyPublic.conn);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCm);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            MyPublic.conn.Close();
            sqlDa.Dispose();
            return dt;
        }

        void Load_cbProlem()
        {
            try
            {
                string Sql = "SELECT * from LOAI_SUCO";
                MyPublic.ConnectDatabase();
                SqlCommand cmd = new SqlCommand(Sql, MyPublic.conn);
                MyPublic.OpenData(Sql, dsSuCo, "LOAI_SUCO");
                dvSuco.Table = dsSuCo.Tables["LOAI_SUCO"];
                cbProlem.DisplayMember = "LSC_TEN";
                cbProlem.ValueMember = "LSC_MA";
                cbProlem.DataSource = dvSuco;
                SqlDataReader DR = null;
                if (MyPublic.conn.State == ConnectionState.Closed)
                {
                    MyPublic.conn.Open();
                    DR = cmd.ExecuteReader();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connect database failed! ");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbProlem.Enabled = true;
            txtDescription.Enabled = true;
            txtNamepro.Enabled = true;
            btnUpload.Enabled = true;
            pnImage.Enabled = true;
            ResetFields(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFields(false);
            cbProlem.Enabled = false;
            txtNamepro.Enabled = false;
            txtDescription.Enabled = false;
            btnUpload.Enabled = false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MyPublic.ConnectDatabase();
                if (MyPublic.conn.State == ConnectionState.Open)
                {
                    object a = cbProlem.SelectedValue;
                    string query = "INSERT INTO YEUCAU (ND_USERNAME,LSC_MA,TT_MA,YC_NGAY,YC_THONGTINKEMTHEO,YC_TENSUCO) VALUES(@username, @lsc_ma,@tt_ma, @date, @yc_tt,@ten_yc)"+"SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(query, MyPublic.conn))
                    {

                        cmd.Parameters.AddWithValue("@username", MyPublic.USERNAME);
                        cmd.Parameters.AddWithValue("@lsc_ma", cbProlem.SelectedValue);
                        cmd.Parameters.AddWithValue("@tt_ma", "TT001");
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@yc_tt", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@ten_yc", txtDescription.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        dgvYC.DataSource = Show_YC();
                        if (url != null)
                        {
                            MyPublic.ConnectDatabase();

                            for (int i = 0; i < url.Length; i++)
                            {
                                var insertedId = reader[0].ToString();
                                string newPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "HelpdeskSystem") + "\\Problem\\" + MyPublic.USERNAME + "YC"+ insertedId + i + ".jpg";
                                File.Copy(url[i], newPath, true);
                                string sql = "INSERT INTO HINHANH(YC_STT,HA_URL) VALUES (@yc_stt,@URL);";
                                SqlCommand sqlCmd = new SqlCommand(sql, MyPublic.conn);
                                sqlCmd.Parameters.AddWithValue("@yc_stt", insertedId);
                                sqlCmd.Parameters.AddWithValue("@URL", url[i]);
                                sqlCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }   
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Connect database failed!"); }

            MessageBox.Show("Your request has been sent to Admin");
                dgvYC.ReadOnly = true;
                ResetFields(false);
                cbProlem.Enabled = false;
                txtDescription.Enabled = false;
                btnUpload.Enabled = false;
            }
        

        private void cbProlem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string suco;
            if (cbProlem.SelectedIndex == -1) return;
            suco = cbProlem.Text;
        }

        void ResetFields(bool status)
        {
            txtDescription.Clear();
            txtNamepro.Clear();
            pnImage.Controls.Clear();
            cbProlem.SelectedIndex = -1;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
            btnAdd.Enabled = !status;
        }
        private void frmEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
                this.Close();
        }
        private void linkOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to sign out?", "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}


