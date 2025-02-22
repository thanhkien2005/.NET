namespace FlightTicketApp
{
    partial class AirTicketBooking
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
            label3 = new Label();
            label2 = new Label();
            btnLogOut = new Button();
            btnComfirm = new Button();
            rtxtFlightRegistration = new RichTextBox();
            lsbFlightList = new ListBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 368);
            label3.Name = "label3";
            label3.Size = new Size(271, 41);
            label3.TabIndex = 23;
            label3.Text = "Flight Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(155, 41);
            label2.TabIndex = 22;
            label2.Text = "Flight List";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Wheat;
            btnLogOut.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(1001, 501);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(212, 95);
            btnLogOut.TabIndex = 21;
            btnLogOut.Text = "&Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnComfirm
            // 
            btnComfirm.BackColor = Color.Gray;
            btnComfirm.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnComfirm.Location = new Point(1001, 314);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(212, 95);
            btnComfirm.TabIndex = 20;
            btnComfirm.Text = "&Comfirm";
            btnComfirm.UseVisualStyleBackColor = false;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // rtxtFlightRegistration
            // 
            rtxtFlightRegistration.Location = new Point(12, 412);
            rtxtFlightRegistration.Name = "rtxtFlightRegistration";
            rtxtFlightRegistration.Size = new Size(898, 257);
            rtxtFlightRegistration.TabIndex = 19;
            rtxtFlightRegistration.Text = "";
            // 
            // lsbFlightList
            // 
            lsbFlightList.FormattingEnabled = true;
            lsbFlightList.Location = new Point(12, 81);
            lsbFlightList.Name = "lsbFlightList";
            lsbFlightList.SelectionMode = SelectionMode.MultiSimple;
            lsbFlightList.Size = new Size(898, 244);
            lsbFlightList.TabIndex = 18;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gray;
            btnAdd.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1001, 81);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(212, 95);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AirTicketBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1433, 812);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogOut);
            Controls.Add(btnComfirm);
            Controls.Add(rtxtFlightRegistration);
            Controls.Add(lsbFlightList);
            Name = "AirTicketBooking";
            Text = "AirTicketBooking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button btnLogOut;
        private Button btnComfirm;
        private RichTextBox rtxtFlightRegistration;
        private ListBox lsbFlightList;
        private Button button1;
        private Button btnAdd;
    }
}