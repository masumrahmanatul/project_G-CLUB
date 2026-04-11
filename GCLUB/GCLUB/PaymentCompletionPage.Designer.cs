namespace GCLUB
{
    partial class PaymentCompletionPage
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
            this.lblTitleComplete = new System.Windows.Forms.Label();
            this.btnBackToHomePage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleComplete
            // 
            this.lblTitleComplete.AutoSize = true;
            this.lblTitleComplete.BackColor = System.Drawing.Color.Black;
            this.lblTitleComplete.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.lblTitleComplete.Location = new System.Drawing.Point(330, 253);
            this.lblTitleComplete.Name = "lblTitleComplete";
            this.lblTitleComplete.Size = new System.Drawing.Size(638, 86);
            this.lblTitleComplete.TabIndex = 0;
            this.lblTitleComplete.Text = "Payment Completed!";
            this.lblTitleComplete.Click += new System.EventHandler(this.lblComplete_Click);
            // 
            // btnBackToHomePage
            // 
            this.btnBackToHomePage.BackColor = System.Drawing.Color.Black;
            this.btnBackToHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(42)))));
            this.btnBackToHomePage.Location = new System.Drawing.Point(536, 380);
            this.btnBackToHomePage.Name = "btnBackToHomePage";
            this.btnBackToHomePage.Size = new System.Drawing.Size(168, 72);
            this.btnBackToHomePage.TabIndex = 1;
            this.btnBackToHomePage.Text = "Back to Homepage";
            this.btnBackToHomePage.UseVisualStyleBackColor = false;
            this.btnBackToHomePage.Click += new System.EventHandler(this.btnBHP_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitleComplete);
            this.panel1.Controls.Add(this.btnBackToHomePage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 729);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GCLUB.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 729);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PaymentCompletionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentCompletionPage";
            this.Text = "PaymentCompletionPage";
            this.Load += new System.EventHandler(this.PaymentCompletionPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleComplete;
        private System.Windows.Forms.Button btnBackToHomePage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}