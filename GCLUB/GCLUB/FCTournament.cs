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
    public partial class FCTournament : Form
    {
        public FCTournament()
        {
            InitializeComponent();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            FCTournamentDetails fctd = new FCTournamentDetails();
            fctd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
