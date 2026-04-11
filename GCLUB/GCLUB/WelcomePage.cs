using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCLUB
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login u = new Login();
            u.Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnGetStart_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
           
        }

    }
}
