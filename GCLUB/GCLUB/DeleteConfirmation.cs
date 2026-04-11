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
    public partial class DeleteConfirmation : Form
    {
        public DeleteConfirmation()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            EditUSerProfile profile = new EditUSerProfile();
            profile.Show();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your account got deleted");
            Login u = new Login();
            u.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your Feedback!");
        }
    }
}
