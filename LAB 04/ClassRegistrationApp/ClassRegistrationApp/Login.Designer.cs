namespace ClassRegistrationApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            groupBox1 = new GroupBox();
            linkLblRegister = new LinkLabel();
            btnCancel = new Button();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLblRegister);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 415);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Form";
            // 
            // linkLblRegister
            // 
            linkLblRegister.AutoSize = true;
            linkLblRegister.Location = new Point(146, 326);
            linkLblRegister.Name = "linkLblRegister";
            linkLblRegister.Size = new Size(121, 20);
            linkLblRegister.TabIndex = 7;
            linkLblRegister.TabStop = true;
            linkLblRegister.Text = "Register Account";
            linkLblRegister.LinkClicked += linkLblRegister_LinkClicked;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.Cancel2;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(557, 282);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 64);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Image = Properties.Resources.Login;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(414, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 64);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(439, 195);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(439, 48);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 3;
            label1.Text = "UserName:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(439, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(191, 30);
            txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(439, 82);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(191, 30);
            txtUserName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_ico2;
            pictureBox1.Location = new Point(39, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel linkLblRegister;
        private Button btnCancel;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private PictureBox pictureBox1;
    }
}