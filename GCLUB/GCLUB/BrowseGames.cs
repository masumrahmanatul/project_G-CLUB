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
    public partial class BrowseGames : Form
    {
        public BrowseGames()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            DetailsOfBooking detailsOfBooking = new DetailsOfBooking();
            detailsOfBooking.Show();
        }

        private void cbmk1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
