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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 1;
                if(rectangleShape2.Width >= 592)
                {
                    timer1.Stop();
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Hide();
                }
            }catch (Exception)
            {
                return;
            }
        }
    }
}
