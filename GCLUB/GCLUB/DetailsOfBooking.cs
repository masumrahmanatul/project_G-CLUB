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
    public partial class DetailsOfBooking : Form
    {
        public DetailsOfBooking()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            DisplayPaymentDetails displayPaymentDetails = new DisplayPaymentDetails();
            displayPaymentDetails.Show();
        }
    }
}
