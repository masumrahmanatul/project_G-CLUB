using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCLUB
{
    public partial class AdminManageUsers : Form
    {
        public AdminManageUsers()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormRefresh()
        {
            txtId.Text = "Auto Generated.";
            txtName.Text = "";
            txtPass.Text = "";
            rbMale.Checked = rbFemale.Checked = false;
            txtContact.Text = "";
            rtxtAddress.Text = "";
        }

        private void LoadUserInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5DDD00J\\SQLEXPRESS;Initial Catalog=G-CLUB;Integrated Security=True;TrustServerCertificate=True");
                con.Open();

                var query = "select * from UserInfo";

                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataSet dataset = new DataSet();
                adp.Fill(dataset);

                DataTable dt = dataset.Tables[0];

                this.dgvUserInfo.DataSource = dt;
                this.dgvUserInfo.Refresh();
                this.dgvUserInfo.ClearSelection();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is Required.");
                return;
            }
            var password = txtPass.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is Required.");
                return;
            }
            string gender;
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Gender is required.");
                return;
            }
            var contact = txtContact.Text;
            if (string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Contact Number is required.");
                return;
            }
            if (contact.Length != 11)
            {
                MessageBox.Show("Invalid Contact Number.");
                return;
            }
            
            var address = rtxtAddress.Text;
            if(string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address is Required.");
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5DDD00J\\SQLEXPRESS;Initial Catalog=G-CLUB;Integrated Security=True;TrustServerCertificate=True");
                con.Open();

                string query = "Insert into UserInfo VALUES ('"+ name +"', '"+ password +"', '"+ gender +"', '"+ contact +"', '"+ address +"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Saved.");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            this.FormRefresh();
        }

        private void AdminManageUsers_Load(object sender, EventArgs e)
        {
            this.LoadUserInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadUserInfo();
            this.FormRefresh();
        }

        private void dgvUserInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = this.dgvUserInfo.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtId.Text = id;

                var name = this.dgvUserInfo.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtName.Text = name;

                var password = this.dgvUserInfo.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtPass.Text = password;

                var gender = this.dgvUserInfo.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                if(gender == rbMale.Text)
                {
                    rbMale.Checked = true;
                }

                else
                {
                    rbFemale.Checked = true;
                }

                var contact = this.dgvUserInfo.Rows[e.RowIndex].Cells["ContactNumber"].Value.ToString();
                txtContact.Text = contact;

                var address = this.dgvUserInfo.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                rtxtAddress.Text = address;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnPassShowHide_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = txtPass.PasswordChar == '*' ? '\0' : '*';
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.FormRefresh();
            this.dgvUserInfo.ClearSelection();
        }
    }
}
