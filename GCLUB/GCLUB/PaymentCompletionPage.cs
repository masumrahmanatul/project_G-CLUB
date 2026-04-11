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
    public partial class PaymentCompletionPage : Form
    {
        public PaymentCompletionPage()
        {
            InitializeComponent();
        }

        private void PaymentCompletionPage_Load(object sender, EventArgs e)
        {

        }

        private void lblComplete_Click(object sender, EventArgs e)
        {

        }

        private void btnBHP_Click(object sender, EventArgs e)
        {
            User_MainMenu user_mainmenu = new User_MainMenu();
            user_mainmenu.Show();
        }
    }
}
