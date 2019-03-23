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
                foreach(string imgUrl in files)
                {
                    PictureBox picture = new PictureBox();
                    picture.Image = Image.FromFile(imgUrl);
                    picture.Location = new Point(x, y);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    x += picture.Width + 10;
                    maxHeight = Math.Max(picture.Height, maxHeight);
                    if(x > this.ClientSize.Width - 100)
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
            Close();
        }
    }
}
