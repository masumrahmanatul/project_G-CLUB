namespace GCLUB
{
    partial class User_MainMenu
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
            System.Windows.Forms.PictureBox picUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnGallery = new System.Windows.Forms.Button();
            this.btnJoinTournament = new System.Windows.Forms.Button();
            this.btnBuyPackage = new System.Windows.Forms.Button();
            this.btnBrowseGames = new System.Windows.Forms.Button();
            this.lblsubtitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            picUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnEditProfile);
            this.panel1.Controls.Add(this.btnGallery);
            this.panel1.Controls.Add(this.btnJoinTournament);
            this.panel1.Controls.Add(this.btnBuyPackage);
            this.panel1.Controls.Add(this.btnBrowseGames);
            this.panel1.Controls.Add(this.lblsubtitle);
            this.panel1.Controls.Add(picUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 729);
            this.panel1.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.No;
            this.lblTitle.Font = new System.Drawing.Font("Gayatri", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(78, 125);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 56);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "G-CLUB";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Black;
            this.btnEditProfile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnEditProfile.Location = new System.Drawing.Point(1071, 250);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(90, 30);
            this.btnEditProfile.TabIndex = 15;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click_1);
            // 
            // btnGallery
            // 
            this.btnGallery.BackColor = System.Drawing.Color.Black;
            this.btnGallery.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGallery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnGallery.Location = new System.Drawing.Point(542, 506);
            this.btnGallery.Name = "btnGallery";
            this.btnGallery.Size = new System.Drawing.Size(235, 50);
            this.btnGallery.TabIndex = 13;
            this.btnGallery.Text = "GALLERY";
            this.btnGallery.UseVisualStyleBackColor = false;
            this.btnGallery.Click += new System.EventHandler(this.btnGallery_Click_1);
            // 
            // btnJoinTournament
            // 
            this.btnJoinTournament.BackColor = System.Drawing.Color.Black;
            this.btnJoinTournament.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnJoinTournament.Location = new System.Drawing.Point(542, 429);
            this.btnJoinTournament.Name = "btnJoinTournament";
            this.btnJoinTournament.Size = new System.Drawing.Size(235, 50);
            this.btnJoinTournament.TabIndex = 12;
            this.btnJoinTournament.Text = "JOIN TOURNAMENT";
            this.btnJoinTournament.UseVisualStyleBackColor = false;
            this.btnJoinTournament.Click += new System.EventHandler(this.btnJoinTourney_Click_1);
            // 
            // btnBuyPackage
            // 
            this.btnBuyPackage.BackColor = System.Drawing.Color.Black;
            this.btnBuyPackage.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnBuyPackage.Location = new System.Drawing.Point(542, 361);
            this.btnBuyPackage.Name = "btnBuyPackage";
            this.btnBuyPackage.Size = new System.Drawing.Size(235, 50);
            this.btnBuyPackage.TabIndex = 11;
            this.btnBuyPackage.Text = "BUY PACKAGE";
            this.btnBuyPackage.UseVisualStyleBackColor = false;
            this.btnBuyPackage.Click += new System.EventHandler(this.btnBuyPackage_Click_1);
            // 
            // btnBrowseGames
            // 
            this.btnBrowseGames.BackColor = System.Drawing.Color.Black;
            this.btnBrowseGames.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnBrowseGames.Location = new System.Drawing.Point(542, 282);
            this.btnBrowseGames.Name = "btnBrowseGames";
            this.btnBrowseGames.Size = new System.Drawing.Size(235, 50);
            this.btnBrowseGames.TabIndex = 10;
            this.btnBrowseGames.Text = "BROWSE GAMES";
            this.btnBrowseGames.UseVisualStyleBackColor = false;
            this.btnBrowseGames.Click += new System.EventHandler(this.btnBrowseGames_Click_1);
            // 
            // lblsubtitle
            // 
            this.lblsubtitle.AutoSize = true;
            this.lblsubtitle.BackColor = System.Drawing.Color.Black;
            this.lblsubtitle.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.lblsubtitle.Location = new System.Drawing.Point(82, 194);
            this.lblsubtitle.Name = "lblsubtitle";
            this.lblsubtitle.Size = new System.Drawing.Size(433, 36);
            this.lblsubtitle.TabIndex = 9;
            this.lblsubtitle.Text = "UNLEASH YOUR INNER GAMER";
            // 
            // picUser
            // 
            picUser.BackColor = System.Drawing.Color.Black;
            picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            picUser.Location = new System.Drawing.Point(1032, 103);
            picUser.Name = "picUser";
            picUser.Size = new System.Drawing.Size(158, 141);
            picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 17;
            picUser.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1264, 729);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // User_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.panel1);
            this.Name = "User_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnGallery;
        private System.Windows.Forms.Button btnJoinTournament;
        private System.Windows.Forms.Button btnBuyPackage;
        private System.Windows.Forms.Button btnBrowseGames;
        private System.Windows.Forms.Label lblsubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}