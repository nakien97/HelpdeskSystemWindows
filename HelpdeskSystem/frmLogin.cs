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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

     


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //frmEmployee f = new frmEmployee();
            //frmAdmin f = new frmAdmin();
            frmTechnician f = new frmTechnician();
            this.Hide();
            f.ShowDialog();
            Close();
        }

   
    }
}
