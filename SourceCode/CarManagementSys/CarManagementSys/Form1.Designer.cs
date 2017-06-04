namespace CarManagementSys
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.bunifuTileButtonAdmin = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButtonGuest = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdmin.Image")));
            this.pictureBoxAdmin.InitialImage = null;
            this.pictureBoxAdmin.Location = new System.Drawing.Point(0, 1);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(686, 452);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAdmin.TabIndex = 0;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // bunifuTileButtonAdmin
            // 
            this.bunifuTileButtonAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButtonAdmin.BackColor = System.Drawing.Color.SlateBlue;
            this.bunifuTileButtonAdmin.color = System.Drawing.Color.SlateBlue;
            this.bunifuTileButtonAdmin.colorActive = System.Drawing.Color.SlateBlue;
            this.bunifuTileButtonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButtonAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButtonAdmin.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButtonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButtonAdmin.Image")));
            this.bunifuTileButtonAdmin.ImagePosition = 20;
            this.bunifuTileButtonAdmin.ImageZoom = 50;
            this.bunifuTileButtonAdmin.LabelPosition = 41;
            this.bunifuTileButtonAdmin.LabelText = "Administrator";
            this.bunifuTileButtonAdmin.Location = new System.Drawing.Point(114, 303);
            this.bunifuTileButtonAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButtonAdmin.Name = "bunifuTileButtonAdmin";
            this.bunifuTileButtonAdmin.Size = new System.Drawing.Size(145, 134);
            this.bunifuTileButtonAdmin.TabIndex = 2;
            this.bunifuTileButtonAdmin.Click += new System.EventHandler(this.bunifuTileButtonAdmin_Click);
            // 
            // bunifuTileButtonGuest
            // 
            this.bunifuTileButtonGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButtonGuest.BackColor = System.Drawing.Color.SlateBlue;
            this.bunifuTileButtonGuest.color = System.Drawing.Color.SlateBlue;
            this.bunifuTileButtonGuest.colorActive = System.Drawing.Color.SlateBlue;
            this.bunifuTileButtonGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButtonGuest.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButtonGuest.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButtonGuest.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButtonGuest.Image")));
            this.bunifuTileButtonGuest.ImagePosition = 20;
            this.bunifuTileButtonGuest.ImageZoom = 50;
            this.bunifuTileButtonGuest.LabelPosition = 41;
            this.bunifuTileButtonGuest.LabelText = "Guest";
            this.bunifuTileButtonGuest.Location = new System.Drawing.Point(449, 303);
            this.bunifuTileButtonGuest.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuTileButtonGuest.Name = "bunifuTileButtonGuest";
            this.bunifuTileButtonGuest.Size = new System.Drawing.Size(151, 134);
            this.bunifuTileButtonGuest.TabIndex = 3;
            this.bunifuTileButtonGuest.Click += new System.EventHandler(this.bunifuTileButtonGuest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 452);
            this.Controls.Add(this.bunifuTileButtonGuest);
            this.Controls.Add(this.bunifuTileButtonAdmin);
            this.Controls.Add(this.pictureBoxAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Car Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButtonAdmin;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButtonGuest;
    }
}

