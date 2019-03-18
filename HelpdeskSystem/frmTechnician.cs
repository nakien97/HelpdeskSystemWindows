using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (txtSearchFAQ.Text.Equals("ID or keyword"))
            {
                txtSearchFAQ.Text = "";
                txtSearchFAQ.ForeColor = Color.Black;
            }
        }

        private void linkOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to sign out?", "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                Close();
            }
        }
    }
}
