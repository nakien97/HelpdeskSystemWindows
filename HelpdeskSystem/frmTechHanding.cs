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
    public partial class frmTechHanding : Form
    {
        private int id;
        public frmTechHanding(int id)
        {
            InitializeComponent();
            this.id = id;
            
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

        private void frmTechHanding_Load(object sender, EventArgs e)
        {
            dgvFAQ.DataSource = showFaq();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int count = dgvFAQ.SelectedRows.Count;
            if (MyPublic.conn.State == ConnectionState.Open)
            {
                for(int i = 0; i < count; i++)
                {
                    string value = dgvFAQ.SelectedRows[i].Cells[0].Value.ToString();
                    SqlCommand sqlCmd;
                    string query = "INSERT INTO BIENPHAP VALUES(@faqId, @username, @id)";
                    sqlCmd = new SqlCommand(query, MyPublic.conn);
                    sqlCmd.Parameters.AddWithValue("@faqId", value);
                    sqlCmd.Parameters.AddWithValue("@username", MyPublic.USERNAME);
                    sqlCmd.Parameters.AddWithValue("@id", id);
                    sqlCmd.ExecuteNonQuery();
                }


                this.Close();
                
            }
        }
    }
}
