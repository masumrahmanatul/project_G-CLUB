namespace GCLUB
{
    partial class ManagerProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox picManagerProfile;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerProfile));
            this.btnManagerEditProfile = new System.Windows.Forms.Button();
            this.btnManagerManageTournaments = new System.Windows.Forms.Button();
            this.btnManagerManagePackage = new System.Windows.Forms.Button();
            this.btnManagerManageBookings = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            picManagerProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picManagerProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picManagerProfile
            // 
            picManagerProfile.BackColor = System.Drawing.Color.Black;
            picManagerProfile.Image = ((System.Drawing.Image)(resources.GetObject("picManagerProfile.Image")));
            picManagerProfile.Location = new System.Drawing.Point(1007, 152);
            picManagerProfile.Name = "picManagerProfile";
            picManagerProfile.Size = new System.Drawing.Size(158, 141);
            picManagerProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picManagerProfile.TabIndex = 23;
            picManagerProfile.TabStop = false;
            // 
            // btnManagerEditProfile
            // 
            this.btnManagerEditProfile.BackColor = System.Drawing.Color.Black;
            this.btnManagerEditProfile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerEditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnManagerEditProfile.Location = new System.Drawing.Point(1046, 299);
            this.btnManagerEditProfile.Name = "btnManagerEditProfile";
            this.btnManagerEditProfile.Size = new System.Drawing.Size(90, 30);
            this.btnManagerEditProfile.TabIndex = 22;
            this.btnManagerEditProfile.Text = "Edit Profile";
            this.btnManagerEditProfile.UseVisualStyleBackColor = false;
            this.btnManagerEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnManagerManageTournaments
            // 
            this.btnManagerManageTournaments.BackColor = System.Drawing.Color.Black;
            this.btnManagerManageTournaments.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerManageTournaments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnManagerManageTournaments.Location = new System.Drawing.Point(539, 369);
            this.btnManagerManageTournaments.Name = "btnManagerManageTournaments";
            this.btnManagerManageTournaments.Size = new System.Drawing.Size(235, 50);
            this.btnManagerManageTournaments.TabIndex = 20;
            this.btnManagerManageTournaments.Text = "Manage Tournaments";
            this.btnManagerManageTournaments.UseVisualStyleBackColor = false;
            this.btnManagerManageTournaments.Click += new System.EventHandler(this.btnJoinTourney_Click);
            // 
            // btnManagerManagePackage
            // 
            this.btnManagerManagePackage.BackColor = System.Drawing.Color.Black;
            this.btnManagerManagePackage.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerManagePackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnManagerManagePackage.Location = new System.Drawing.Point(539, 301);
            this.btnManagerManagePackage.Name = "btnManagerManagePackage";
            this.btnManagerManagePackage.Size = new System.Drawing.Size(235, 50);
            this.btnManagerManagePackage.TabIndex = 19;
            this.btnManagerManagePackage.Text = "Manage Package";
            this.btnManagerManagePackage.UseVisualStyleBackColor = false;
            this.btnManagerManagePackage.Click += new System.EventHandler(this.btnBuyPackage_Click);
            // 
            // btnManagerManageBookings
            // 
            this.btnManagerManageBookings.BackColor = System.Drawing.Color.Black;
            this.btnManagerManageBookings.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerManageBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnManagerManageBookings.Location = new System.Drawing.Point(500, 232);
            this.btnManagerManageBookings.Name = "btnManagerManageBookings";
            this.btnManagerManageBookings.Size = new System.Drawing.Size(313, 50);
            this.btnManagerManageBookings.TabIndex = 18;
            this.btnManagerManageBookings.Text = "Manage Bookings and Sessions";
            this.btnManagerManageBookings.UseVisualStyleBackColor = false;
            this.btnManagerManageBookings.Click += new System.EventHandler(this.btnManagerManageBookings_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::GCLUB.Properties.Resources.homepage_bg;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1264, 729);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // ManagerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.btnManagerEditProfile);
            this.Controls.Add(this.btnManagerManageTournaments);
            this.Controls.Add(this.btnManagerManagePackage);
            this.Controls.Add(this.btnManagerManageBookings);
            this.Controls.Add(picManagerProfile);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ManagerProfile";
            this.Text = "ManagerProfile";
            ((System.ComponentModel.ISupportInitialize)(picManagerProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManagerEditProfile;
        private System.Windows.Forms.Button btnManagerManageTournaments;
        private System.Windows.Forms.Button btnManagerManagePackage;
        private System.Windows.Forms.Button btnManagerManageBookings;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}