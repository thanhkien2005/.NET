namespace FlightTicketApp
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
            groupBox1 = new GroupBox();
            linkLblRegister = new LinkLabel();
            btnExit = new Button();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(linkLblRegister);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1354, 604);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOGIN";
            // 
            // linkLblRegister
            // 
            linkLblRegister.AutoSize = true;
            linkLblRegister.LinkColor = Color.Red;
            linkLblRegister.Location = new Point(738, 531);
            linkLblRegister.Name = "linkLblRegister";
            linkLblRegister.Size = new Size(121, 20);
            linkLblRegister.TabIndex = 8;
            linkLblRegister.TabStop = true;
            linkLblRegister.Text = "Register Account";
            linkLblRegister.LinkClicked += linkLblRegister_LinkClicked;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gold;
            btnExit.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Image = Properties.Resources.Cancel;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1251, 564);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 40);
            btnExit.TabIndex = 7;
            btnExit.Text = "   &Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleGreen;
            btnLogin.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Maroon;
            btnLogin.Image = Properties.Resources.Login;
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.Location = new Point(240, 554);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(619, 44);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 488);
            label3.Name = "label3";
            label3.Size = new Size(144, 37);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 421);
            label2.Name = "label2";
            label2.Size = new Size(156, 37);
            label2.TabIndex = 4;
            label2.Text = "UserName:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(240, 497);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(619, 28);
            txtPassword.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(240, 430);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(619, 28);
            txtUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 359);
            label1.Name = "label1";
            label1.Size = new Size(110, 37);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.VA;
            pictureBox1.Location = new Point(427, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 604);
            Controls.Add(groupBox1);
            Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LoginForm";
            Text = "Login Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label1;
        private LinkLabel linkLblRegister;
        private Button btnExit;
        private Button btnLogin;
    }
}