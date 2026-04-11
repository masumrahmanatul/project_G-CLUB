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
    public partial class BuyPackage : Form
    {
        public BuyPackage()
        {
            InitializeComponent();
        }

        private void PackagePage_Load(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            DisplayPaymentOptions displayPaymentOptions = new DisplayPaymentOptions();
            displayPaymentOptions.Show();
        }

        private void lbl4Person_Click(object sender, EventArgs e)
        {

        }

        private void lbl2Person_Click(object sender, EventArgs e)
        {

        }

        private void lblSingleplayer_Click(object sender, EventArgs e)
        {

        }

        private void panelps4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl40tk_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
