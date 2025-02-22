namespace FlightTicketApp
{
    partial class FlightTicket
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
            dtTimeArrival = new DateTimePicker();
            btnAddFlight = new Button();
            txtFlightType = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dtTimeDepart = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            txtFlightID = new TextBox();
            label1 = new Label();
            btnBooking = new Button();
            SuspendLayout();
            // 
            // dtTimeArrival
            // 
            dtTimeArrival.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dtTimeArrival.Format = DateTimePickerFormat.Custom;
            dtTimeArrival.Location = new Point(323, 190);
            dtTimeArrival.Name = "dtTimeArrival";
            dtTimeArrival.Size = new Size(289, 27);
            dtTimeArrival.TabIndex = 28;
            // 
            // btnAddFlight
            // 
            btnAddFlight.BackColor = Color.LightSeaGreen;
            btnAddFlight.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddFlight.Location = new Point(96, 327);
            btnAddFlight.Name = "btnAddFlight";
            btnAddFlight.Size = new Size(212, 95);
            btnAddFlight.TabIndex = 27;
            btnAddFlight.Text = "&Add Flight";
            btnAddFlight.UseVisualStyleBackColor = false;
            btnAddFlight.Click += btnAddFlight_Click;
            // 
            // txtFlightType
            // 
            txtFlightType.Location = new Point(323, 246);
            txtFlightType.Name = "txtFlightType";
            txtFlightType.Size = new Size(289, 27);
            txtFlightType.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(195, 249);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 25;
            label7.Text = "Flight Type: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(189, 197);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 24;
            label6.Text = "TimeArrival: ";
            // 
            // dtTimeDepart
            // 
            dtTimeDepart.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dtTimeDepart.Format = DateTimePickerFormat.Custom;
            dtTimeDepart.Location = new Point(323, 133);
            dtTimeDepart.Name = "dtTimeDepart";
            dtTimeDepart.Size = new Size(289, 27);
            dtTimeDepart.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 139);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 22;
            label5.Text = "TimeDepart:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 77);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 21;
            label4.Text = "Flight ID:";
            // 
            // txtFlightID
            // 
            txtFlightID.Location = new Point(323, 74);
            txtFlightID.Name = "txtFlightID";
            txtFlightID.Size = new Size(289, 27);
            txtFlightID.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 16);
            label1.Name = "label1";
            label1.Size = new Size(272, 41);
            label1.TabIndex = 19;
            label1.Text = "Flight Information";
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.Coral;
            btnBooking.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBooking.Location = new Point(492, 327);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(212, 95);
            btnBooking.TabIndex = 29;
            btnBooking.Text = "&Booking";
            btnBooking.UseVisualStyleBackColor = false;
            btnBooking.Click += btnBooking_Click;
            // 
            // FlightTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBooking);
            Controls.Add(dtTimeArrival);
            Controls.Add(btnAddFlight);
            Controls.Add(txtFlightType);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtTimeDepart);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFlightID);
            Controls.Add(label1);
            Name = "FlightTicket";
            Text = "FlightTicket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtTimeArrival;
        private Button btnAddFlight;
        private TextBox txtFlightType;
        private Label label7;
        private Label label6;
        private DateTimePicker dtTimeDepart;
        private Label label5;
        private Label label4;
        private TextBox txtFlightID;
        private Label label1;
        private Button btnBooking;
    }
}