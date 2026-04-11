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
    public partial class DisplayPaymentOptions : Form
    {
        public DisplayPaymentOptions()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Number_and_pin numandpin = new Number_and_pin();
            numandpin.Show();
        }
    }
}
