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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User_MainMenu u_mainmenu = new User_MainMenu();
            u_mainmenu.Show();
        }

        private void lblCreateAcc_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration();
            r.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            User_MainMenu um = new User_MainMenu();
            um.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            ml.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
        }
    }
}
