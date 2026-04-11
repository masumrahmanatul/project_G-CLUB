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
    public partial class Admin_main_menu : Form
    {
        public Admin_main_menu()
        {
            InitializeComponent();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            AdminEditProfile aep = new AdminEditProfile();
            aep.Show();
        }

        private void btnAdminManageUsers_Click(object sender, EventArgs e)
        {
            AdminManageUsers amu = new AdminManageUsers();
            amu.Show();
        }

        private void btnAdminManageStaff_Click(object sender, EventArgs e)
        {
            AdminManageStaff ams = new AdminManageStaff();
            ams.Show();
        }

        private void btnAdminManageBookings_Click(object sender, EventArgs e)
        {
            ManageSessionsPage msp = new ManageSessionsPage();
            msp.Show();
        }

        private void btnAdminManagePackage_Click(object sender, EventArgs e)
        {
            ManagePackagePage mpp = new ManagePackagePage();
            mpp.Show();
        }

        private void btnAdminManageTournaments_Click(object sender, EventArgs e)
        {
            ManageTourneyPage mtp = new ManageTourneyPage();
            mtp.Show();
        }

        private void btnAdminFinance_Click(object sender, EventArgs e)
        {
            AdminFinancePage afp = new AdminFinancePage();
            afp.Show();
        }
    }
}
