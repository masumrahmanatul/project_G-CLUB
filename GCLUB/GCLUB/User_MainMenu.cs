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
    public partial class User_MainMenu : Form
    {
        public User_MainMenu()
        {
            InitializeComponent();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditUSerProfile profile = new EditUSerProfile();
            profile.Show();
        }

        private void btnBrowseGames_Click(object sender, EventArgs e)
        {
            BrowseGames gPage = new BrowseGames();
            gPage.Show();
        }

        private void btnBuyPackage_Click(object sender, EventArgs e)
        {
            BuyPackage packagePage = new BuyPackage();
            packagePage.Show();
        }

        private void btnJoinTourney_Click(object sender, EventArgs e)
        {
            TournamentPage tournamentPage = new TournamentPage();
            tournamentPage.Show();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            Gallery gallery = new Gallery();
            gallery.Show();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseGames_Click_1(object sender, EventArgs e)
        {
            BrowseGames bg = new BrowseGames();
            bg.Show();
        }

        private void btnBuyPackage_Click_1(object sender, EventArgs e)
        {
            BuyPackage bp = new BuyPackage();
            bp.Show();
        }

        private void btnGallery_Click_1(object sender, EventArgs e)
        {
            Gallery g = new Gallery();
            g.Show();
        }

        private void btnJoinTourney_Click_1(object sender, EventArgs e)
        {
            TournamentPage tp = new TournamentPage();
            tp.Show();
        }

        private void btnEditProfile_Click_1(object sender, EventArgs e)
        {
            EditUSerProfile eup = new EditUSerProfile();
            eup.Show();
        }
    }
}
