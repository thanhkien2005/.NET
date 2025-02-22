namespace SmartPhoneLINQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadData = new Button();
            btnCloseApp = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            dgwSmartPhone = new DataGridView();
            colSmartPhoneID = new DataGridViewTextBoxColumn();
            colSmartPhoneName = new DataGridViewTextBoxColumn();
            colSmartPhoneType = new DataGridViewTextBoxColumn();
            colAnnoucedDate = new DataGridViewTextBoxColumn();
            colPlatform = new DataGridViewTextBoxColumn();
            colCamera = new DataGridViewTextBoxColumn();
            colRAM = new DataGridViewTextBoxColumn();
            colBattery = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            picSmartPhone = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgwSmartPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSmartPhone).BeginInit();
            SuspendLayout();
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(23, 29);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(228, 39);
            btnLoadData.TabIndex = 0;
            btnLoadData.Text = "Load Data From SQL Server";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnCloseApp
            // 
            btnCloseApp.Location = new Point(296, 29);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(160, 39);
            btnCloseApp.TabIndex = 1;
            btnCloseApp.Text = "Close Application";
            btnCloseApp.UseVisualStyleBackColor = true;
            btnCloseApp.Click += btnCloseApp_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(86, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 39);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(260, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 39);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(435, 354);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(137, 39);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgwSmartPhone
            // 
            dgwSmartPhone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSmartPhone.Columns.AddRange(new DataGridViewColumn[] { colSmartPhoneID, colSmartPhoneName, colSmartPhoneType, colAnnoucedDate, colPlatform, colCamera, colRAM, colBattery, colPrice });
            dgwSmartPhone.Location = new Point(38, 89);
            dgwSmartPhone.MultiSelect = false;
            dgwSmartPhone.Name = "dgwSmartPhone";
            dgwSmartPhone.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgwSmartPhone.Size = new Size(540, 208);
            dgwSmartPhone.TabIndex = 5;
            // 
            // colSmartPhoneID
            // 
            colSmartPhoneID.DataPropertyName = "SmartPhoneID";
            colSmartPhoneID.HeaderText = "SmartPhoneID";
            colSmartPhoneID.Name = "colSmartPhoneID";
            // 
            // colSmartPhoneName
            // 
            colSmartPhoneName.DataPropertyName = "SmartPhoneName";
            colSmartPhoneName.HeaderText = "SmartPhone Name";
            colSmartPhoneName.Name = "colSmartPhoneName";
            // 
            // colSmartPhoneType
            // 
            colSmartPhoneType.DataPropertyName = "SmartPhoneType";
            colSmartPhoneType.HeaderText = "SmartPhone Type";
            colSmartPhoneType.Name = "colSmartPhoneType";
            // 
            // colAnnoucedDate
            // 
            colAnnoucedDate.DataPropertyName = "AnnoucedDate";
            colAnnoucedDate.HeaderText = "Annouced Date";
            colAnnoucedDate.Name = "colAnnoucedDate";
            // 
            // colPlatform
            // 
            colPlatform.DataPropertyName = "Platform";
            colPlatform.HeaderText = "Platform";
            colPlatform.Name = "colPlatform";
            // 
            // colCamera
            // 
            colCamera.DataPropertyName = "Camera";
            colCamera.HeaderText = "Camera";
            colCamera.Name = "colCamera";
            // 
            // colRAM
            // 
            colRAM.DataPropertyName = "RAM";
            colRAM.HeaderText = "RAM";
            colRAM.Name = "colRAM";
            // 
            // colBattery
            // 
            colBattery.DataPropertyName = "Battery";
            colBattery.HeaderText = "Battery";
            colBattery.Name = "colBattery";
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            // 
            // picSmartPhone
            // 
            picSmartPhone.Image = Properties.Resources.smartphone;
            picSmartPhone.Location = new Point(621, 89);
            picSmartPhone.Name = "picSmartPhone";
            picSmartPhone.Size = new Size(153, 208);
            picSmartPhone.SizeMode = PictureBoxSizeMode.Zoom;
            picSmartPhone.TabIndex = 6;
            picSmartPhone.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picSmartPhone);
            Controls.Add(dgwSmartPhone);
            Controls.Add(btnInsert);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseApp);
            Controls.Add(btnLoadData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgwSmartPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSmartPhone).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadData;
        private Button btnCloseApp;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView dgwSmartPhone;
        private PictureBox picSmartPhone;
        private DataGridViewTextBoxColumn colSmartPhoneID;
        private DataGridViewTextBoxColumn colSmartPhoneName;
        private DataGridViewTextBoxColumn colSmartPhoneType;
        private DataGridViewTextBoxColumn colAnnoucedDate;
        private DataGridViewTextBoxColumn colPlatform;
        private DataGridViewTextBoxColumn colCamera;
        private DataGridViewTextBoxColumn colRAM;
        private DataGridViewTextBoxColumn colBattery;
        private DataGridViewTextBoxColumn colPrice;
    }
}
