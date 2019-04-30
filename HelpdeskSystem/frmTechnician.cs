using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Collections;

namespace HelpdeskSystem
{
    public partial class frmTechnician : Form
    {
        public frmTechnician()
        {
            InitializeComponent();
        }

        private void txtSearchFAQ_Enter(object sender, EventArgs e)
        {
            if (txtSearchFAQ.Text.Equals("Type ID here"))
            {
                txtSearchFAQ.Text = "";
                txtSearchFAQ.ForeColor = Color.Black;
            }
        }

        private void linkOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to sign out?", "Notify", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }

        private void frmTechnician_Load(object sender, EventArgs e)
        {
            MyPublic.ConnectDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KYTHUATVIEN WHERE ND_USERNAME='" + MyPublic.USERNAME + "'", MyPublic.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            txtPurview.Text = MyPublic.PURVIEW;
            txtName.Text = dt.Rows[0][3].ToString();
            txtPhone.Text = dt.Rows[0][4].ToString();
            txtEmail.Text = dt.Rows[0][5].ToString();
            if (dt.Rows[0][6].ToString() != null)
            {
                imgAvatar.ImageLocation = dt.Rows[0][6].ToString();
                imgAvatarHeader.ImageLocation = dt.Rows[0][6].ToString();
            }
            dgvFaq.DataSource = showFaq();
            dgvOffer.DataSource = showOffer();
            dgvTask.DataSource = showTask();
        }

        public DataTable showFaq()
        {
            DataTable dt = new DataTable();
            if (MyPublic.conn.State == ConnectionState.Open)
            {
                string query = "SELECT FAQ_MA AS ID, FAQ_CAUHOI AS QUESTION , FAQ_TRALOI AS ANSWER FROM FAQ";
                SqlCommand sqlCmd = new SqlCommand(query, MyPublic.conn);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                sqlDa.Fill(dt);
                sqlDa.Dispose();
            }
            return dt;
        }


        public DataTable showOffer()
        {
            DataTable dt = new DataTable();
            if (MyPublic.conn.State == ConnectionState.Open)
            {
                string query = "SELECT DX_STT AS ID, DX_CAUHOI AS QUESTION, DX_TRALOI AS ANSWER, CHO_NHAN_VIEN AS FOR_EMPLOYEE, TT_DXUAT.TTDX_NOIDUNG AS STATUS FROM DXUAT_FAQ INNER JOIN TT_DXUAT ON DXUAT_FAQ.TTDX_MA = TT_DXUAT.TTDX_MA WHERE DXUAT_FAQ.KTV_USERNAME=@username";
                SqlCommand sqlCmd = new SqlCommand(query, MyPublic.conn);
                sqlCmd.Parameters.AddWithValue("@username", MyPublic.USERNAME);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                sqlDa.Fill(dt);
                sqlDa.Dispose();
            }
            return dt;
        }

        public DataTable showTask()
        {
            DataTable dt = new DataTable();
           if (MyPublic.conn.State == ConnectionState.Open)
            {
                string query = "select Y.YC_STT as ID, Y.YC_TENSUCO as 'Problem', LSC.LSC_TEN as 'Type', MD_TEN as 'Level', XL.THOI_GIAN_HOAN_THANH as 'Deadline', TT.TT_TEN as 'State'"
                                + " from YEUCAU Y, LOAI_SUCO LSC, MUCDO MD, XULY_SUCO XL, TRANGTHAI TT, PHANCONG PC"
                                + " where(y.YC_STT = XL.YC_STT) and(LSC.LSC_MA = y.LSC_MA) and(md.MD_MA = xl.MD_MA) and(tt.TT_MA = y.TT_MA)"
                                + " and(PC.YC_STT = Y.YC_STT) and(PC.KTV_USERNAME = @username) and (TT.TT_MA <> 'TT005') order by (THOI_GIAN_HOAN_THANH);";

                SqlCommand sqlCmd = new SqlCommand(query, MyPublic.conn);
                sqlCmd.Parameters.AddWithValue("@username", MyPublic.USERNAME);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                sqlDa.Fill(dt);
                sqlDa.Dispose();
            }
            return dt;
        }

        

        private void btnChange_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                imgAvatar.ImageLocation = imageLocation;
                changeAvatar(imageLocation);
            }
        }

        private void changeAvatar(string imageLocation)
        {
            SqlCommand sqlCmd;
            string newPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "HelpdeskSystem") + "\\Avatar\\"+MyPublic.USERNAME+".jpg";
            File.Copy(imageLocation, newPath, true);
            string query = "UPDATE KYTHUATVIEN SET KTV_AVATAR=@avatar WHERE ND_USERNAME=@username";
            sqlCmd = new SqlCommand(query, MyPublic.conn);
            sqlCmd.Parameters.AddWithValue("@avatar", newPath);
            sqlCmd.Parameters.AddWithValue("@username", MyPublic.USERNAME);
            sqlCmd.ExecuteNonQuery();
            imgAvatarHeader.ImageLocation = newPath;
        }

        private void frmTechnician_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MyPublic.conn.State == ConnectionState.Open)
            {
                MyPublic.conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearchFAQ.Text;
            bool check = false;
            dgvFaq.ClearSelection();
            foreach (DataGridViewRow row in dgvFaq.Rows)
            {
                string data = (string)row.Cells[0].Value;
                if (id.Equals(data))
                {
                    row.Selected = true;
                    check = true;
                    break;
                }
            }
            if(!check)
            {
                MessageBox.Show("Not found!", "Notify");
            }

        }
        DataGridViewRow rows;
        private int index;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvOffer.AllowUserToAddRows = true;
            dgvOffer.Rows[dgvOffer.RowCount - 1].Selected = true;
            dgvOffer.ReadOnly = false;
            btnOK.Visible = true;
            btnCancel.Visible = true;
            dgvOffer.Columns[0].ReadOnly = true;
            dgvOffer.Columns[4].ReadOnly = true;
            DataGridViewRow lastRow = dgvOffer.Rows[dgvOffer.RowCount-1];
            index = lastRow.Index;
            foreach (DataGridViewRow row in dgvOffer.Rows)
            {
                if (row.Index < lastRow.Index)
                {
                    row.Cells[1].ReadOnly = true;
                    row.Cells[2].ReadOnly = true;
                    row.Cells[3].ReadOnly = true;
                }
            }
            btnAdd.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            rows = dgvOffer.Rows[dgvOffer.RowCount-2];
            if (MyPublic.conn.State == ConnectionState.Open)
            {
                SqlCommand sqlCmd;
                string query = "INSERT INTO DXUAT_FAQ (TTDX_MA, KTV_USERNAME, DX_CAUHOI, DX_TRALOI, CHO_NHAN_VIEN) VALUES(@stateId, @username, @question, @answer, @forEmployee)";
                sqlCmd = new SqlCommand(query, MyPublic.conn);
                sqlCmd.Parameters.AddWithValue("@stateId", "TT1");
                sqlCmd.Parameters.AddWithValue("@username", MyPublic.USERNAME);
                sqlCmd.Parameters.AddWithValue("@question", rows.Cells[1].Value);
                sqlCmd.Parameters.AddWithValue("@answer", rows.Cells[2].Value);
                if(rows.Cells[3].Value == null)
                    sqlCmd.Parameters.AddWithValue("@forEmployee", false);
                else
                    sqlCmd.Parameters.AddWithValue("@forEmployee", true);
                sqlCmd.ExecuteNonQuery();
                dgvOffer.DataSource = showOffer();
            }
            dgvOffer.AllowUserToAddRows = false;
            dgvOffer.ReadOnly = true;
            btnOK.Visible = false;
            btnCancel.Visible = false;
            btnAdd.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvOffer.DataSource = showOffer();
            dgvOffer.AllowUserToAddRows = false;
            dgvOffer.ReadOnly = true;
            btnOK.Visible = false;
            btnCancel.Visible = false;
            btnAdd.Visible = true;
        }

        private void txtSearchFAQ_Leave(object sender, EventArgs e)
        {
            if (txtSearchFAQ.Text.Equals(""))
            {
                txtSearchFAQ.Text = "Type ID here";
                txtSearchFAQ.ForeColor = Color.Gray;
            }
        }

        private int id;
        private void dgvTask_SelectionChanged(object sender, EventArgs e)
        {
            pnlPhoto.Controls.Clear();
            txtFAQ.Text = "";
            btnRefund.Enabled = true;
            try
            {
                id = Int32.Parse(dgvTask.SelectedRows[0].Cells[0].Value.ToString());
                string query = "select NV.NV_HOTEN, YC.YC_THONGTINKEMTHEO from NHANVIEN NV inner join YEUCAU YC on(NV.ND_USERNAME = YC.ND_USERNAME) AND YC_STT = @ID";
                SqlCommand sqlCmd = new SqlCommand(query, MyPublic.conn);
                sqlCmd.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                reader.Read();
                txtEmployee.Text = reader[0].ToString();
                txtBonus.Text = reader[1].ToString();
                reader.Close();
                SqlDataAdapter adapter = new SqlDataAdapter("select HA_URL from HINHANH where YC_STT = " + id, MyPublic.conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string imgUrl = dt.Rows[i][0].ToString();
                    PictureBox picture = new PictureBox();
                    picture.Image = Image.FromFile(imgUrl);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Size = new Size(100, 50);
                    this.pnlPhoto.Controls.Add(picture);
                }
                SqlDataAdapter adapter2 = new SqlDataAdapter("select FAQ_MA from THAMCHIEUFAQ where YC_STT =" + id, MyPublic.conn);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    txtFAQ.Text += dt2.Rows[i][0].ToString() + "\t";
                }
            }
            catch
            {

            }
            
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTask.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (MyPublic.conn.State == ConnectionState.Open)
            {
                SqlCommand sqlCmd;
                string query = "UPDATE YEUCAU SET TT_MA = 'TT005' WHERE YC_STT = @ID";
                sqlCmd = new SqlCommand(query, MyPublic.conn);
                sqlCmd.Parameters.AddWithValue("@ID", id);
                sqlCmd.ExecuteNonQuery();
            }
            reloadForm();
        }


        private void reloadForm()
        {
            btnRefund.Enabled = false;
            dgvTask.ClearSelection();
            dgvFaq.DataSource = showFaq();
            dgvOffer.DataSource = showOffer();
            dgvTask.DataSource = showTask();
        }

        private void btnHanding_Click(object sender, EventArgs e)
        {
            frmTechHanding fTechHanding = new frmTechHanding(id);
            this.Hide();
            fTechHanding.ShowDialog();
            this.Show();
        }
    }
}
