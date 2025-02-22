namespace ClassRegistrationApp
{
    partial class ClassSelectionForm
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
            Button btnLogOut;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassSelectionForm));
            lsbCourseList = new ListBox();
            rtxtRegistrationInfo = new RichTextBox();
            btnAdd = new Button();
            btnComfirm = new Button();
            label1 = new Label();
            label2 = new Label();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.Image = Properties.Resources.Log_Out_Icon_;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(732, 374);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(138, 63);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "&Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lsbCourseList
            // 
            lsbCourseList.FormattingEnabled = true;
            lsbCourseList.Location = new Point(70, 51);
            lsbCourseList.Name = "lsbCourseList";
            lsbCourseList.SelectionMode = SelectionMode.MultiSimple;
            lsbCourseList.Size = new Size(257, 304);
            lsbCourseList.TabIndex = 0;
            // 
            // rtxtRegistrationInfo
            // 
            rtxtRegistrationInfo.Location = new Point(389, 51);
            rtxtRegistrationInfo.Name = "rtxtRegistrationInfo";
            rtxtRegistrationInfo.Size = new Size(617, 304);
            rtxtRegistrationInfo.TabIndex = 1;
            rtxtRegistrationInfo.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.Add1;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(118, 374);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 63);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnComfirm
            // 
            btnComfirm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComfirm.Image = Properties.Resources.Confirm;
            btnComfirm.ImageAlign = ContentAlignment.MiddleLeft;
            btnComfirm.Location = new Point(572, 374);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(138, 63);
            btnComfirm.TabIndex = 3;
            btnComfirm.Text = "   &Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 33);
            label1.TabIndex = 5;
            label1.Text = "Course List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(608, 9);
            label2.Name = "label2";
            label2.Size = new Size(201, 33);
            label2.TabIndex = 6;
            label2.Text = "Registration List";
            // 
            // ClassSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 486);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogOut);
            Controls.Add(btnComfirm);
            Controls.Add(btnAdd);
            Controls.Add(rtxtRegistrationInfo);
            Controls.Add(lsbCourseList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClassSelectionForm";
            Text = "ClassSelectionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbCourseList;
        private RichTextBox rtxtRegistrationInfo;
        private Button btnAdd;
        private Button btnComfirm;
        private Button btnLogOut;
        private Label label1;
        private Label label2;
    }
}