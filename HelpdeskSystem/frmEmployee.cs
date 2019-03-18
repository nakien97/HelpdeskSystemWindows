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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void linkOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkOut_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to sign out?", "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                Close();
            }
            
            
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
            if(txtSearchFAQ.Text.Equals("ID or keyword"))
            {
                txtSearchFAQ.Text = "";
                txtSearchFAQ.ForeColor = Color.Black;
            }
        }
    }
}
