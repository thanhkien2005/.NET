namespace SmartphoneManagement
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
            dgwPhoneList = new DataGridView();
            colSmartPhoneID = new DataGridViewTextBoxColumn();
            colSmartPhoneName = new DataGridViewTextBoxColumn();
            colSmartPhoneType = new DataGridViewTextBoxColumn();
            colAnncoucedDate = new DataGridViewTextBoxColumn();
            colPlatform = new DataGridViewTextBoxColumn();
            colCamera = new DataGridViewTextBoxColumn();
            colRAM = new DataGridViewTextBoxColumn();
            colBattery = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            btnLoadExcel = new Button();
            btnLoadSQL = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnUpdateSource = new Button();
            picPhoneImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgwPhoneList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneImage).BeginInit();
            SuspendLayout();
            // 
            // dgwPhoneList
            // 
            dgwPhoneList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPhoneList.Columns.AddRange(new DataGridViewColumn[] { colSmartPhoneID, colSmartPhoneName, colSmartPhoneType, colAnncoucedDate, colPlatform, colCamera, colRAM, colBattery, colPrice });
            dgwPhoneList.Location = new Point(45, 66);
            dgwPhoneList.MultiSelect = false;
            dgwPhoneList.Name = "dgwPhoneList";
            dgwPhoneList.RowHeadersWidth = 51;
            dgwPhoneList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgwPhoneList.Size = new Size(572, 326);
            dgwPhoneList.TabIndex = 0;
            // 
            // colSmartPhoneID
            // 
            colSmartPhoneID.DataPropertyName = "SmartPhoneID";
            colSmartPhoneID.HeaderText = "SmartPhoneID";
            colSmartPhoneID.MinimumWidth = 6;
            colSmartPhoneID.Name = "colSmartPhoneID";
            colSmartPhoneID.Width = 125;
            // 
            // colSmartPhoneName
            // 
            colSmartPhoneName.DataPropertyName = "SmartPhoneName";
            colSmartPhoneName.HeaderText = "SmartPhoneName";
            colSmartPhoneName.MinimumWidth = 6;
            colSmartPhoneName.Name = "colSmartPhoneName";
            colSmartPhoneName.Width = 125;
            // 
            // colSmartPhoneType
            // 
            colSmartPhoneType.DataPropertyName = "SmartPhoneType";
            colSmartPhoneType.HeaderText = "SmartPhoneType";
            colSmartPhoneType.MinimumWidth = 6;
            colSmartPhoneType.Name = "colSmartPhoneType";
            colSmartPhoneType.Width = 125;
            // 
            // colAnncoucedDate
            // 
            colAnncoucedDate.DataPropertyName = "AnnoucedDate";
            colAnncoucedDate.HeaderText = "AnnoucedDate";
            colAnncoucedDate.MinimumWidth = 6;
            colAnncoucedDate.Name = "colAnncoucedDate";
            colAnncoucedDate.Width = 125;
            // 
            // colPlatform
            // 
            colPlatform.DataPropertyName = "Platform";
            colPlatform.HeaderText = "Platform";
            colPlatform.MinimumWidth = 6;
            colPlatform.Name = "colPlatform";
            colPlatform.Width = 125;
            // 
            // colCamera
            // 
            colCamera.DataPropertyName = "Camera";
            colCamera.HeaderText = "Camera";
            colCamera.MinimumWidth = 6;
            colCamera.Name = "colCamera";
            colCamera.Width = 125;
            // 
            // colRAM
            // 
            colRAM.DataPropertyName = "RAM";
            colRAM.HeaderText = "RAM";
            colRAM.MinimumWidth = 6;
            colRAM.Name = "colRAM";
            colRAM.Width = 125;
            // 
            // colBattery
            // 
            colBattery.DataPropertyName = "Battery";
            colBattery.HeaderText = "Battery";
            colBattery.MinimumWidth = 6;
            colBattery.Name = "colBattery";
            colBattery.Width = 125;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.Width = 125;
            // 
            // btnLoadExcel
            // 
            btnLoadExcel.Location = new Point(45, 12);
            btnLoadExcel.Name = "btnLoadExcel";
            btnLoadExcel.Size = new Size(180, 30);
            btnLoadExcel.TabIndex = 1;
            btnLoadExcel.Text = "Load Data From Excel";
            btnLoadExcel.UseVisualStyleBackColor = true;
            btnLoadExcel.Click += btnLoadExcel_Click;
            // 
            // btnLoadSQL
            // 
            btnLoadSQL.Location = new Point(320, 12);
            btnLoadSQL.Name = "btnLoadSQL";
            btnLoadSQL.Size = new Size(180, 30);
            btnLoadSQL.TabIndex = 2;
            btnLoadSQL.Text = "Load Data From SQL";
            btnLoadSQL.UseVisualStyleBackColor = true;
            btnLoadSQL.Click += btnLoadSQL_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(45, 412);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(168, 412);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 30);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(290, 412);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdateSource
            // 
            btnUpdateSource.Location = new Point(431, 412);
            btnUpdateSource.Name = "btnUpdateSource";
            btnUpdateSource.Size = new Size(186, 30);
            btnUpdateSource.TabIndex = 6;
            btnUpdateSource.Text = "Update to DataSource";
            btnUpdateSource.UseVisualStyleBackColor = true;
            btnUpdateSource.Click += btnUpdateSource_Click;
            // 
            // picPhoneImage
            // 
            picPhoneImage.Image = Properties.Resources.smartphone;
            picPhoneImage.Location = new Point(677, 78);
            picPhoneImage.Name = "picPhoneImage";
            picPhoneImage.Size = new Size(251, 289);
            picPhoneImage.SizeMode = PictureBoxSizeMode.Zoom;
            picPhoneImage.TabIndex = 7;
            picPhoneImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 507);
            Controls.Add(picPhoneImage);
            Controls.Add(btnUpdateSource);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoadSQL);
            Controls.Add(btnLoadExcel);
            Controls.Add(dgwPhoneList);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgwPhoneList).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwPhoneList;
        private Button btnLoadExcel;
        private Button btnLoadSQL;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnUpdateSource;
        private PictureBox picPhoneImage;
        private DataGridViewTextBoxColumn colSmartPhoneID;
        private DataGridViewTextBoxColumn colSmartPhoneName;
        private DataGridViewTextBoxColumn colSmartPhoneType;
        private DataGridViewTextBoxColumn colAnncoucedDate;
        private DataGridViewTextBoxColumn colPlatform;
        private DataGridViewTextBoxColumn colCamera;
        private DataGridViewTextBoxColumn colRAM;
        private DataGridViewTextBoxColumn colBattery;
        private DataGridViewTextBoxColumn colPrice;
    }
}
