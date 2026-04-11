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
    public partial class Number_and_pin : Form
    {
        public Number_and_pin()
        {
            InitializeComponent();
        }

        private void Number_and_pin_Load(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentCompletionPage pcp = new PaymentCompletionPage();
            pcp.Show();
        }
    }
}
