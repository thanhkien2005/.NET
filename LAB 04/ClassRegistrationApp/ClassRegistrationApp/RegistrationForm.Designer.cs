namespace ClassRegistrationApp
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            txtStudentID = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUserID = new TextBox();
            txtComfirmPassword = new TextBox();
            dtBirthday = new DateTimePicker();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            picAvatar = new PictureBox();
            btnBrowse = new Button();
            btnRemove = new Button();
            btnCreate = new Button();
            btnClear = new Button();
            btnClose = new Button();
            openFileDlg = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(152, 12);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(185, 30);
            txtStudentID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(152, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 30);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(152, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 30);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(152, 299);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(185, 30);
            txtPassword.TabIndex = 3;
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserID.Location = new Point(152, 251);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(185, 30);
            txtUserID.TabIndex = 4;
            // 
            // txtComfirmPassword
            // 
            txtComfirmPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComfirmPassword.Location = new Point(152, 345);
            txtComfirmPassword.Name = "txtComfirmPassword";
            txtComfirmPassword.PasswordChar = '*';
            txtComfirmPassword.Size = new Size(185, 30);
            txtComfirmPassword.TabIndex = 5;
            // 
            // dtBirthday
            // 
            dtBirthday.Format = DateTimePickerFormat.Short;
            dtBirthday.Location = new Point(152, 110);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new Size(185, 27);
            dtBirthday.TabIndex = 6;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(166, 152);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 24);
            rdMale.TabIndex = 7;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(241, 152);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 24);
            rdFemale.TabIndex = 8;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(42, 17);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 9;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 57);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 10;
            label2.Text = "Your Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 110);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 11;
            label3.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 150);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 12;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 201);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 13;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(74, 251);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 14;
            label6.Text = "UserID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 299);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 15;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 345);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 16;
            label8.Text = "Comfirmed:";
            // 
            // picAvatar
            // 
            picAvatar.Image = Properties.Resources.NewMember;
            picAvatar.Location = new Point(479, 54);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(281, 221);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 17;
            picAvatar.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Image = Properties.Resources.Browse;
            btnBrowse.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrowse.Location = new Point(457, 299);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(157, 54);
            btnBrowse.TabIndex = 18;
            btnBrowse.Text = "&Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRemove
            // 
            btnRemove.Image = Properties.Resources.Cancel1;
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.Location = new Point(633, 299);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(157, 54);
            btnRemove.TabIndex = 19;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCreate
            // 
            btnCreate.Image = Properties.Resources.Login1;
            btnCreate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreate.Location = new Point(12, 392);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(157, 54);
            btnCreate.TabIndex = 20;
            btnCreate.Text = "&Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.Image = Properties.Resources.Clear;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(180, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(157, 54);
            btnClear.TabIndex = 21;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.Close;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(343, 392);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(157, 54);
            btnClose.TabIndex = 22;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // openFileDlg
            // 
            openFileDlg.FileName = "openFileDialog";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 475);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(btnRemove);
            Controls.Add(btnBrowse);
            Controls.Add(picAvatar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(dtBirthday);
            Controls.Add(txtComfirmPassword);
            Controls.Add(txtUserID);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtStudentID);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationForm";
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUserID;
        private TextBox txtComfirmPassword;
        private DateTimePicker dtBirthday;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox picAvatar;
        private Button btnBrowse;
        private Button btnRemove;
        private Button btnCreate;
        private Button btnClear;
        private Button btnClose;
        private OpenFileDialog openFileDlg;
    }
}