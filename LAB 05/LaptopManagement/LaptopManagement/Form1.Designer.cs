namespace LaptopManagement
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
            dgwLaptopList = new DataGridView();
            colLaptopID = new DataGridViewTextBoxColumn();
            colLaptopName = new DataGridViewTextBoxColumn();
            colLaptopType = new DataGridViewTextBoxColumn();
            colProductDate = new DataGridViewTextBoxColumn();
            colProcessor = new DataGridViewTextBoxColumn();
            colHDD = new DataGridViewTextBoxColumn();
            colRAM = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            btnLoadExcel = new Button();
            btnLoadSQL = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnUpdateSource = new Button();
            picLaptopImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgwLaptopList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLaptopImage).BeginInit();
            SuspendLayout();
            // 
            // dgwLaptopList
            // 
            dgwLaptopList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLaptopList.Columns.AddRange(new DataGridViewColumn[] { colLaptopID, colLaptopName, colLaptopType, colProductDate, colProcessor, colHDD, colRAM, colPrice });
            dgwLaptopList.Location = new Point(35, 87);
            dgwLaptopList.MultiSelect = false;
            dgwLaptopList.Name = "dgwLaptopList";
            dgwLaptopList.RowHeadersWidth = 51;
            dgwLaptopList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgwLaptopList.Size = new Size(642, 367);
            dgwLaptopList.TabIndex = 0;
            // 
            // colLaptopID
            // 
            colLaptopID.DataPropertyName = "LaptopID";
            colLaptopID.HeaderText = "LaptopID";
            colLaptopID.MinimumWidth = 6;
            colLaptopID.Name = "colLaptopID";
            colLaptopID.Width = 125;
            // 
            // colLaptopName
            // 
            colLaptopName.DataPropertyName = "LaptopName";
            colLaptopName.HeaderText = "LaptopName";
            colLaptopName.MinimumWidth = 6;
            colLaptopName.Name = "colLaptopName";
            colLaptopName.Width = 125;
            // 
            // colLaptopType
            // 
            colLaptopType.DataPropertyName = "LaptopType";
            colLaptopType.HeaderText = "LaptopType";
            colLaptopType.MinimumWidth = 6;
            colLaptopType.Name = "colLaptopType";
            colLaptopType.Width = 125;
            // 
            // colProductDate
            // 
            colProductDate.DataPropertyName = "ProductDate";
            colProductDate.HeaderText = "ProductDate";
            colProductDate.MinimumWidth = 6;
            colProductDate.Name = "colProductDate";
            colProductDate.Width = 125;
            // 
            // colProcessor
            // 
            colProcessor.DataPropertyName = "Processor";
            colProcessor.HeaderText = "Processor";
            colProcessor.MinimumWidth = 6;
            colProcessor.Name = "colProcessor";
            colProcessor.Width = 125;
            // 
            // colHDD
            // 
            colHDD.DataPropertyName = "HDD";
            colHDD.HeaderText = "HDD";
            colHDD.MinimumWidth = 6;
            colHDD.Name = "colHDD";
            colHDD.Width = 125;
            // 
            // colRAM
            // 
            colRAM.DataPropertyName = "RAM";
            colRAM.HeaderText = "RAM";
            colRAM.MinimumWidth = 6;
            colRAM.Name = "colRAM";
            colRAM.Width = 125;
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
            btnLoadExcel.Location = new Point(35, 26);
            btnLoadExcel.Name = "btnLoadExcel";
            btnLoadExcel.Size = new Size(201, 33);
            btnLoadExcel.TabIndex = 1;
            btnLoadExcel.Text = "Load Data From Excel";
            btnLoadExcel.UseVisualStyleBackColor = true;
            btnLoadExcel.Click += btnLoadExcel_Click;
            // 
            // btnLoadSQL
            // 
            btnLoadSQL.Location = new Point(403, 26);
            btnLoadSQL.Name = "btnLoadSQL";
            btnLoadSQL.Size = new Size(201, 33);
            btnLoadSQL.TabIndex = 2;
            btnLoadSQL.Text = "Load Data From SQL";
            btnLoadSQL.UseVisualStyleBackColor = true;
            btnLoadSQL.Click += btnLoadSQL_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(35, 480);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(193, 480);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 35);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 480);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdateSource
            // 
            btnUpdateSource.Location = new Point(498, 480);
            btnUpdateSource.Name = "btnUpdateSource";
            btnUpdateSource.Size = new Size(179, 35);
            btnUpdateSource.TabIndex = 6;
            btnUpdateSource.Text = "Update to DataSource";
            btnUpdateSource.UseVisualStyleBackColor = true;
            btnUpdateSource.Click += btnUpdateSource_Click;
            // 
            // picLaptopImage
            // 
            picLaptopImage.Image = Properties.Resources.images;
            picLaptopImage.Location = new Point(704, 105);
            picLaptopImage.Name = "picLaptopImage";
            picLaptopImage.Size = new Size(236, 296);
            picLaptopImage.SizeMode = PictureBoxSizeMode.Zoom;
            picLaptopImage.TabIndex = 7;
            picLaptopImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 557);
            Controls.Add(picLaptopImage);
            Controls.Add(btnUpdateSource);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoadSQL);
            Controls.Add(btnLoadExcel);
            Controls.Add(dgwLaptopList);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgwLaptopList).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLaptopImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwLaptopList;
        private Button btnLoadExcel;
        private Button btnLoadSQL;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnUpdateSource;
        private PictureBox picLaptopImage;
        private DataGridViewTextBoxColumn colLaptopID;
        private DataGridViewTextBoxColumn colLaptopName;
        private DataGridViewTextBoxColumn colLaptopType;
        private DataGridViewTextBoxColumn colProductDate;
        private DataGridViewTextBoxColumn colProcessor;
        private DataGridViewTextBoxColumn colHDD;
        private DataGridViewTextBoxColumn colRAM;
        private DataGridViewTextBoxColumn colPrice;
    }
}
