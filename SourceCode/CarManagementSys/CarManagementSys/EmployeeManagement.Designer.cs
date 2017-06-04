namespace CarManagementSys
{
    partial class EmployeeManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox4 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox3 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.FullName,
            this.Gender,
            this.ID,
            this.DateOfBirth,
            this.Address,
            this.ContactNumber});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(2, 176);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(741, 211);
            this.bunifuCustomDataGrid1.TabIndex = 12;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton21);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton22);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton25);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton24);
            this.bunifuGradientPanel1.Controls.Add(this.comboBox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomTextbox4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomTextbox3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.dateTimePicker1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomTextbox2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomTextbox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(2, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(741, 179);
            this.bunifuGradientPanel1.TabIndex = 16;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Cancel";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(576, 123);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(133, 41);
            this.bunifuThinButton21.TabIndex = 33;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Add";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(36, 123);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(133, 41);
            this.bunifuThinButton22.TabIndex = 29;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Update";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton25.Location = new System.Drawing.Point(220, 123);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(133, 41);
            this.bunifuThinButton25.TabIndex = 32;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Delete";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton24.Location = new System.Drawing.Point(402, 123);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(133, 41);
            this.bunifuThinButton24.TabIndex = 31;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(466, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(399, 17);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(61, 16);
            this.bunifuCustomLabel6.TabIndex = 26;
            this.bunifuCustomLabel6.Text = "Gender:";
            // 
            // bunifuCustomTextbox4
            // 
            this.bunifuCustomTextbox4.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox4.Location = new System.Drawing.Point(466, 78);
            this.bunifuCustomTextbox4.Name = "bunifuCustomTextbox4";
            this.bunifuCustomTextbox4.Size = new System.Drawing.Size(150, 20);
            this.bunifuCustomTextbox4.TabIndex = 25;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(341, 78);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(119, 16);
            this.bunifuCustomLabel5.TabIndex = 24;
            this.bunifuCustomLabel5.Text = "Contact Number:";
            // 
            // bunifuCustomTextbox3
            // 
            this.bunifuCustomTextbox3.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox3.Location = new System.Drawing.Point(157, 75);
            this.bunifuCustomTextbox3.Name = "bunifuCustomTextbox3";
            this.bunifuCustomTextbox3.Size = new System.Drawing.Size(150, 20);
            this.bunifuCustomTextbox3.TabIndex = 23;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(86, 78);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(65, 16);
            this.bunifuCustomLabel4.TabIndex = 22;
            this.bunifuCustomLabel4.Text = "Address:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(466, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(369, 48);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(91, 16);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Date of Birth:";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click_1);
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(157, 45);
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(133, 20);
            this.bunifuCustomTextbox2.TabIndex = 19;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(126, 45);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(25, 16);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "ID:";
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(157, 16);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(150, 20);
            this.bunifuCustomTextbox1.TabIndex = 17;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(74, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(77, 16);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Full Name:";
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 387);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
    }
}