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
    public partial class DisplayPaymentDetails : Form
    {
        public DisplayPaymentDetails()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DisplayPaymentOptions options = new DisplayPaymentOptions();
            options.Show();
        }

        private void txtCoupon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
