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
    public partial class AdminManageStaff : Form
    {
        public AdminManageStaff()
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

        private void LoadManagerInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5DDD00J\\SQLEXPRESS;Initial Catalog=G-CLUB;Integrated Security=True;TrustServerCertificate=True");
                con.Open();

                var query = "select * from ManagerInfo";

                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataSet dataset = new DataSet();
                adp.Fill(dataset);

                DataTable dt = dataset.Tables[0];

                this.dgvManagerInfo.DataSource = dt;
                this.dgvManagerInfo.Refresh();
                this.dgvManagerInfo.ClearSelection();
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
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address is Required.");
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-5DDD00J\\SQLEXPRESS;Initial Catalog=G-CLUB;Integrated Security=True;TrustServerCertificate=True");
                con.Open();

                string query = "Insert into ManagerInfo VALUES ('" + name + "', '" + password + "', '" + gender + "', '" + contact + "', '" + address + "')";
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

        private void AdminManageStaff_Load(object sender, EventArgs e)
        {
            this.LoadManagerInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadManagerInfo();
            this.FormRefresh();
        }

        private void dgvManagerInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = this.dgvManagerInfo.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtId.Text = id;

                var name = this.dgvManagerInfo.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtName.Text = name;

                var password = this.dgvManagerInfo.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtPass.Text = password;

                var gender = this.dgvManagerInfo.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                if (gender == rbMale.Text)
                {
                    rbMale.Checked = true;
                }

                else
                {
                    rbFemale.Checked = true;
                }

                var contact = this.dgvManagerInfo.Rows[e.RowIndex].Cells["ContactNumber"].Value.ToString();
                txtContact.Text = contact;

                var address = this.dgvManagerInfo.Rows[e.RowIndex].Cells["Address"].Value.ToString();
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
            this.dgvManagerInfo.ClearSelection();
        }
    }
}
