using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCLUB
{
    public partial class ManagerProfile : Form
    {
        public ManagerProfile()
        {
            InitializeComponent();
        }



        private void btnBuyPackage_Click(object sender, EventArgs e)
        {
            ManagePackagePage mpp = new ManagePackagePage();
            mpp.Show();
  
        }

        private void btnJoinTourney_Click(object sender, EventArgs e)
        {
            ManageTourneyPage mtp = new ManageTourneyPage();
            mtp.Show();
       
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            ManagerEditProfile mep = new ManagerEditProfile();
            mep.Show();
        }

        private void btnManagerManageBookings_Click(object sender, EventArgs e)
        {
            ManageSessionsPage msp = new ManageSessionsPage();
            msp.Show();
        }
    }
}
