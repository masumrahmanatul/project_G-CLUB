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
    public partial class MKTournamentDetails : Form
    {
        public MKTournamentDetails()
        {
            InitializeComponent();
        }

        private void btnJoinfcTourney_Click(object sender, EventArgs e)
        {
            DisplayPaymentOptions dop = new DisplayPaymentOptions();
            dop.Show();
        }
    }
}
