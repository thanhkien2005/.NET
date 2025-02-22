namespace FlightTicketApp
{
    partial class Registration
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
            picAvatar = new PictureBox();
            label1 = new Label();
            txtCustomerID = new TextBox();
            txtCustomerName = new TextBox();
            txtNationality = new TextBox();
            btnCreated = new Button();
            btnClear = new Button();
            btnClose = new Button();
            btnBrowse = new Button();
            btnRemove = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtBirthday = new DateTimePicker();
            txtPassportNumber = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtComfirmedPassword = new TextBox();
            openFileDlg = new OpenFileDialog();
            Avatar = new Label();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.Image = Properties.Resources.input;
            picAvatar.Location = new Point(888, 90);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(403, 447);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(242, 26);
            label1.Name = "label1";
            label1.Size = new Size(533, 38);
            label1.TabIndex = 1;
            label1.Text = "Register Account For Customer Airplane";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(232, 112);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(294, 30);
            txtCustomerID.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(232, 164);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(294, 30);
            txtCustomerName.TabIndex = 3;
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(232, 299);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(294, 30);
            txtNationality.TabIndex = 6;
            // 
            // btnCreated
            // 
            btnCreated.BackColor = SystemColors.ScrollBar;
            btnCreated.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreated.ForeColor = Color.Black;
            btnCreated.Image = Properties.Resources.Login1;
            btnCreated.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreated.Location = new Point(15, 582);
            btnCreated.Name = "btnCreated";
            btnCreated.Size = new Size(253, 89);
            btnCreated.TabIndex = 7;
            btnCreated.Text = "&Created";
            btnCreated.UseVisualStyleBackColor = false;
            btnCreated.Click += btnCreated_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ScrollBar;
            btnClear.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Image = Properties.Resources.Clear;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(292, 582);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(253, 89);
            btnClear.TabIndex = 8;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ScrollBar;
            btnClose.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(577, 582);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(253, 89);
            btnClose.TabIndex = 9;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(128, 255, 128);
            btnBrowse.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.Image = Properties.Resources.Browse;
            btnBrowse.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrowse.Location = new Point(942, 558);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(152, 89);
            btnBrowse.TabIndex = 10;
            btnBrowse.Text = "    &Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.IndianRed;
            btnRemove.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Image = Properties.Resources.Cancel1;
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.Location = new Point(1102, 558);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(152, 89);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "   &Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 119);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 12;
            label2.Text = "Customer ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 171);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 13;
            label3.Text = "Customer Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 216);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 14;
            label4.Text = "Birthday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 259);
            label5.Name = "label5";
            label5.Size = new Size(148, 23);
            label5.TabIndex = 15;
            label5.Text = "Passport Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 299);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 16;
            label6.Text = "Nationality:";
            // 
            // dtBirthday
            // 
            dtBirthday.Format = DateTimePickerFormat.Short;
            dtBirthday.Location = new Point(232, 216);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new Size(294, 30);
            dtBirthday.TabIndex = 17;
            // 
            // txtPassportNumber
            // 
            txtPassportNumber.Location = new Point(232, 259);
            txtPassportNumber.Name = "txtPassportNumber";
            txtPassportNumber.Size = new Size(294, 30);
            txtPassportNumber.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 367);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 19;
            label7.Text = "UserName:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 413);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 20;
            label8.Text = "Password:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 456);
            label9.Name = "label9";
            label9.Size = new Size(177, 23);
            label9.TabIndex = 21;
            label9.Text = "Comfirmed Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(232, 367);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(294, 30);
            txtUserName.TabIndex = 22;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(232, 413);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(294, 30);
            txtPassword.TabIndex = 23;
            // 
            // txtComfirmedPassword
            // 
            txtComfirmedPassword.Location = new Point(232, 456);
            txtComfirmedPassword.Name = "txtComfirmedPassword";
            txtComfirmedPassword.PasswordChar = '*';
            txtComfirmedPassword.Size = new Size(294, 30);
            txtComfirmedPassword.TabIndex = 24;
            // 
            // openFileDlg
            // 
            openFileDlg.FileName = "openFileDialog";
            // 
            // Avatar
            // 
            Avatar.AutoSize = true;
            Avatar.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Avatar.Location = new Point(1037, 41);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(120, 46);
            Avatar.TabIndex = 25;
            Avatar.Text = "Avatar";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1373, 733);
            Controls.Add(Avatar);
            Controls.Add(txtComfirmedPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtPassportNumber);
            Controls.Add(dtBirthday);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRemove);
            Controls.Add(btnBrowse);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnCreated);
            Controls.Add(txtNationality);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerID);
            Controls.Add(label1);
            Controls.Add(picAvatar);
            Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Registration";
            Text = "Registration Account";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvatar;
        private Label label1;
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private TextBox txtNationality;
        private Button btnCreated;
        private Button btnClear;
        private Button btnClose;
        private Button btnBrowse;
        private Button btnRemove;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtBirthday;
        private TextBox txtPassportNumber;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtComfirmedPassword;
        private OpenFileDialog openFileDlg;
        private Label Avatar;
    }
}