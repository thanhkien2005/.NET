using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace SmartphoneManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgwPhoneList.SelectionChanged += dgwPhoneList_SelectionChanged;
            dgwPhoneList.EditingControlShowing += dgwPhoneList_EditingControlShowing;
        }
        public List<SmartPhone> SPList = new List<SmartPhone>();
        // loadData = 0 (chua co du lieu);
        // loadData = 1 (co du lieu tu excel);
        // loadData = 2 (co du lieu tu sql);
        public int loadData = 0;
        static string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string ExcelFilePath = ProjectPath + "\\Data\\SmartPhoneList.xlsx";
        string connetionString =
            "Data Source = DESKTOP-H37FLVP\\SQLEXPRESS; Initial Catalog = SmartPhoneDB; Integrated Security=SSPI";
        int CurrentPhoneIndex = -1;
        System.Data.DataTable datatable;
        BindingSource biding = new BindingSource();



        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            loadData = 1;
            datatable = new System.Data.DataTable();
            SPList.Clear();

            int colCount = 10;
            int NumDataRow = ReadDataFromFile(SPList, ExcelFilePath, colCount);

            var sublist = SPList.Select(x => new
            {
                SmartPhoneID = x.SmartPhoneID,
                SmartPhoneName = x.SmartPhoneName,
                SmartPhoneType = x.SmartPhoneType,
                AnnoucedDate = x.AnnoucedDate.ToString("dd/MM/yyyy"),
                Platform = x.Platform,
                Camera = x.Camera,
                RAM = x.RAM,
                Battery = x.Battery,
                Price = x.Price.ToString() + "USD",
            }).ToList();

            datatable.Columns.Add("SmartPhoneID");
            datatable.Columns.Add("SmartPhoneName");
            datatable.Columns.Add("SmartPhoneType");
            datatable.Columns.Add("AnnoucedDate");
            datatable.Columns.Add("Platform");
            datatable.Columns.Add("Camera");
            datatable.Columns.Add("RAM");
            datatable.Columns.Add("Battery");
            datatable.Columns.Add("Price");

            DataRow newrow;
            foreach (var bi in sublist)
            {
                newrow = datatable.NewRow();
                newrow["SmartPhoneID"] = bi.SmartPhoneID;
                newrow["SmartPhoneName"] = bi.SmartPhoneName;
                newrow["SmartPhoneType"] = bi.SmartPhoneType;
                newrow["AnnoucedDate"] = bi.AnnoucedDate;
                newrow["Platform"] = bi.Platform;
                newrow["Camera"] = bi.Camera;
                newrow["RAM"] = bi.RAM;
                newrow["Battery"] = bi.Battery;
                newrow["Price"] = bi.Price;
                datatable.Rows.Add(newrow);
                datatable.AcceptChanges();
            }
            biding.AllowNew = true;
            biding.DataSource = datatable;
            dgwPhoneList.AutoGenerateColumns = false;
            dgwPhoneList.DataSource = biding;
        }
        public int ReadDataFromFile(List<SmartPhone> Datalist, string FilePath, int colCount)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(FilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            xlWorksheet.Columns.ClearFormats();
            xlWorksheet.Rows.ClearFormats();

            int rowCount = xlWorksheet.UsedRange.Rows.Count;

            int numPhone = 0;
            string SmartPhoneID = ""; ;
            string SmartPhoneName = "";
            string SmartPhoneType = "";
            DateTime AnnoucedDate = DateTime.Now;
            string Platform = "";
            string Camera = "";
            string RAM = "";
            string Battery = "";
            int Price = 0;
            string Avatar = "";

            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    switch (j)
                    {
                        case 1: // Column SmartPhoneID
                            SmartPhoneID = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 2: // Column SmartPhoneName
                            SmartPhoneName = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 3: // Column SmartPhoneType
                            SmartPhoneType = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 4: // Column Annouced Date
                            AnnoucedDate = DateTime.ParseExact(xlRange.Cells[i, j].Value2.ToString(),
                                "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            break;
                        case 5: // Column Platform
                            Platform = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 6: // Column Camera
                            Camera = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 7: // Column RAM
                            RAM = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 8: // Column Battery
                            Battery = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 9: // Column Price
                            Price = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString());
                            break;
                        case 10: // Column Avatar
                            Avatar = xlRange.Cells[i, j].Value2.ToString();
                            break;
                    }
                }
                Datalist.Add(new SmartPhone());
                Datalist[numPhone].SmartPhoneID = SmartPhoneID;
                Datalist[numPhone].SmartPhoneName = SmartPhoneName;
                Datalist[numPhone].SmartPhoneType = SmartPhoneType;
                Datalist[numPhone].AnnoucedDate = AnnoucedDate;
                Datalist[numPhone].Platform = Platform;
                Datalist[numPhone].Camera = Camera;
                Datalist[numPhone].RAM = RAM;
                Datalist[numPhone].Battery = Battery;
                Datalist[numPhone].Price = Price;
                Datalist[numPhone].Avatar = Avatar;
                numPhone = numPhone + 1;
            }
            xlApp.Quit();
            MessageBox.Show("Load Data Form Excel Finished!: " + (rowCount - 1).ToString() + "Records");
            return (rowCount - 1); //Khong tinh dong tieu de
        }

        private void dgwPhoneList_SelectionChanged(object sender, EventArgs e)
        {
            if (SPList.Count == 0 || datatable.Rows.Count == 0)
                return;
            CurrentPhoneIndex = dgwPhoneList.CurrentRow.Index;
            if (CurrentPhoneIndex >= 0 && CurrentPhoneIndex < SPList.Count)
                picPhoneImage.Image = Image.FromFile(ProjectPath + "\\Data\\" + SPList[CurrentPhoneIndex].Avatar);
        }

        private void btnLoadSQL_Click(object sender, EventArgs e)
        {
            loadData = 2;
            datatable = new System.Data.DataTable();
            SPList.Clear();

            int NumDataRow = ReadDataFromSQLServer(SPList, connetionString);

            var sublist = SPList.Select(x => new
            {
                SmartPhoneID = x.SmartPhoneID,
                SmartPhoneName = x.SmartPhoneName,
                SmartPhoneType = x.SmartPhoneType,
                AnnoucedDate = x.AnnoucedDate.ToString("dd/MM/yyyy"),
                Platform = x.Platform,
                Camera = x.Camera,
                RAM = x.RAM,
                Battery = x.Battery,
                Price = x.Price.ToString() + "USD",
            }).ToList();

            datatable.Columns.Add("SmartPhoneID");
            datatable.Columns.Add("SmartPhoneName");
            datatable.Columns.Add("SmartPhoneType");
            datatable.Columns.Add("AnnoucedDate");
            datatable.Columns.Add("Platform");
            datatable.Columns.Add("Camera");
            datatable.Columns.Add("RAM");
            datatable.Columns.Add("Battery");
            datatable.Columns.Add("Price");

            DataRow newrow;
            foreach (var bi in sublist)
            {
                newrow = datatable.NewRow();
                newrow["SmartPhoneID"] = bi.SmartPhoneID;
                newrow["SmartPhoneName"] = bi.SmartPhoneName;
                newrow["SmartPhoneType"] = bi.SmartPhoneType;
                newrow["AnnoucedDate"] = bi.AnnoucedDate;
                newrow["Platform"] = bi.Platform;
                newrow["Camera"] = bi.Camera;
                newrow["RAM"] = bi.RAM;
                newrow["Battery"] = bi.Battery;
                newrow["Price"] = bi.Price;
                datatable.Rows.Add(newrow);
                datatable.AcceptChanges();
            }
            biding.AllowNew = true;
            biding.DataSource = datatable;
            dgwPhoneList.AutoGenerateColumns = false;
            dgwPhoneList.DataSource = biding;
        }
        public int ReadDataFromSQLServer(List<SmartPhone> DataList, string connectionString)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            int iRow = 0;
            int Numrecords = 0;

            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open !");

                string SqlString = @"SELECT
                                    SmartphoneID,
                                    SmartPhoneName,
                                    SmartPhoneType,
                                    AnnoucedDate = Convert(varchar(10),CONVERT(date,AnnoucedDate,106), 103),
                                    Platform,
                                    Camera,
                                    RAM,
                                    Battery,
                                    Price,
                                    ImageName
                                    FROM dbo.SmartPhone";
                using (var command = new SqlCommand(SqlString, cnn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SPList.Add(new SmartPhone());
                            SPList[iRow].SmartPhoneID = reader.GetString(0);
                            SPList[iRow].SmartPhoneName = reader.GetString(1);
                            SPList[iRow].SmartPhoneType = reader.GetString(2);
                            SPList[iRow].AnnoucedDate = DateTime.ParseExact(reader.GetString(3), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            SPList[iRow].Platform = reader.GetString(4);
                            SPList[iRow].Camera = reader.GetString(5);
                            SPList[iRow].RAM = reader.GetString(6);
                            SPList[iRow].Battery = reader.GetString(7);
                            SPList[iRow].Price = reader.GetInt32(8);
                            SPList[iRow].Avatar = reader.GetString(9);

                            iRow = iRow + 1;
                        }
                    }
                }
                SqlCommand cmd = new SqlCommand("Select count(*) from SmartPhone", cnn);
                object result = cmd.ExecuteScalar();
                Numrecords = int.Parse(result.ToString());

                MessageBox.Show("Finished load data from SQL: " + Numrecords.ToString() + "Records");
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cannot open Connection! : " + ex.Message);
            }
            return Numrecords;
        }
        private void dgwPhoneList_EditingControlShowing(object sender,
                                                        DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(CoumnPrice_KeyPress);
            if (dgwPhoneList.CurrentCell.ColumnIndex == 8) //Colum Price
            {
                System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(CoumnPrice_KeyPress);
                }
            }
        }
        private void CoumnPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SmartPhone sp = new SmartPhone();
            sp.SmartPhoneID = "Not Assigned";
            sp.SmartPhoneName = "Not Assigned";
            sp.SmartPhoneType = "Not Assigned";
            sp.AnnoucedDate = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            sp.Platform = "Not Assigned";
            sp.Camera = "Not Assigned";
            sp.RAM = "Not Assigned";
            sp.Battery = "Not Assigned";
            sp.Price = 0;
            sp.Avatar = "smartphone.jpg";
            SPList.Add(sp);

            DataRow newrow;
            newrow = datatable.NewRow();
            newrow["SmartPhoneID"] = sp.SmartPhoneID;
            newrow["SmartPhoneName"] = sp.SmartPhoneName;
            newrow["SmartPhoneType"] = sp.SmartPhoneType;
            newrow["AnnoucedDate"] = sp.AnnoucedDate.ToString("dd/MM/yyyy");
            newrow["Platform"] = sp.Platform;
            newrow["Camera"] = sp.Camera;
            newrow["RAM"] = sp.RAM;
            newrow["Battery"] = sp.Battery;
            newrow["Price"] = sp.Price.ToString() + "USD";
            datatable.Rows.Add(newrow);
            datatable.AcceptChanges();

            MessageBox.Show("Finish Adding");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow row;
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                row = datatable.Rows[i];

                SPList[i].SmartPhoneID = row["SmartPhoneID"].ToString();
                SPList[i].SmartPhoneName = row["SmartPhoneName"].ToString();
                SPList[i].SmartPhoneType = row["SmartPhoneName"].ToString();
                SPList[i].AnnoucedDate = DateTime.ParseExact(row["AnnoucedDate"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                SPList[i].Platform = row["Platform"].ToString();
                SPList[i].Camera = row["Camera"].ToString();
                SPList[i].RAM = row["RAM"].ToString();
                SPList[i].Battery = row["Battery"].ToString();
                string sPrice = row["Price"].ToString();

                // Bo chu USD phia sau

                // Kiểm tra nếu chuỗi có chứa "USD" và cắt bỏ phần đó
                if (sPrice.Contains("USD"))
                {
                    sPrice = sPrice.Substring(0, sPrice.IndexOf("USD")).Trim();  // Loại bỏ "USD"
                }

                SPList[i].Price = Convert.ToInt32(sPrice);
            }
            MessageBox.Show("Finish Update");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SmartPhone sp;
            if (CurrentPhoneIndex >= 0)
                sp = SPList[CurrentPhoneIndex];
            else
                return;

            string question = "Do you want to delete phone:" + sp.SmartPhoneID;
            DialogResult result = MessageBox.Show(question, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SPList.RemoveAt(CurrentPhoneIndex);
                biding.RemoveAt(CurrentPhoneIndex);
            }
            MessageBox.Show("Finish Delete");
        }

        private void btnUpdateSource_Click(object sender, EventArgs e)
        {
            if (loadData == 1)
                WriteDataToExcelFile(SPList, ExcelFilePath);
            else
                WriteDataToSQLServer(SPList, connetionString);
        }

        public void WriteDataToExcelFile(List<SmartPhone> SPList, string ExcelFilePath)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            Excel.Range xlRange;
            string[,] Data = new string[1, 10];

            int idxRow = 2;
            foreach (SmartPhone sp in SPList)
            {
                Data[0, 0] = sp.SmartPhoneID;
                Data[0, 1] = sp.SmartPhoneName;
                Data[0, 2] = sp.SmartPhoneType;
                Data[0, 3] = sp.AnnoucedDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                Data[0, 4] = sp.Platform;
                Data[0, 5] = sp.Camera;
                Data[0, 6] = sp.RAM;
                Data[0, 7] = sp.Battery;
                Data[0, 8] = sp.Price.ToString();
                Data[0, 9] = sp.Avatar;

                xlRange = xlWorksheet.get_Range("A" + idxRow.ToString(), "J" + idxRow.ToString());
                xlRange.Value2 = Data;

                idxRow = idxRow + 1;

            }
            xlWorkbook.Save();
            xlWorkbook.Close();
            xlApp.Quit();

            MessageBox.Show("Finish Update to DataSource Excel");
        }
        public void WriteDataToSQLServer(List<SmartPhone> SPList, string connectionString)
        {
            SqlConnection cnn;
            SqlCommand myCommand = new SqlCommand();
            string query;

            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open! ");

                query = "TRUNCATE TABLE SmartPhone";
                myCommand.CommandText = query;
                myCommand.Connection = cnn;
                myCommand.ExecuteNonQuery();

                query = @"INSERT INTO SmartPhone(SmartPhoneID, SmartPhoneName, SmartPhoneType,
                                                AnncoucedDate, Platform, Camera, RAM, Battery, Price, ImageName)";
                query += "VALUES (@SmartPhoneID, @SmartPhoneName, @SmartPhoneType, @AnnoucedDate, @Platform, @Camera, @RAM, @Battery, @Price, @ImageName)";

                myCommand.CommandText = query;
                myCommand.Connection = cnn;

                myCommand.Parameters.Add(new SqlParameter("@SmartPhoneID", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@SmartPhoneName", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@SmartPhoneType", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@AnncoucedDate", SqlDbType.DateTime));
                myCommand.Parameters.Add(new SqlParameter("@Platform", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@Camera", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@RAM", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@Battery", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Int));
                myCommand.Parameters.Add(new SqlParameter("@ImageName", SqlDbType.NVarChar));

                foreach (SmartPhone sp in SPList)
                {
                    myCommand.Parameters[0].Value = sp.SmartPhoneID;
                    myCommand.Parameters[1].Value = sp.SmartPhoneName;
                    myCommand.Parameters[2].Value = sp.SmartPhoneType;

                    myCommand.Parameters[3].Value = sp.AnnoucedDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                    myCommand.Parameters[4].Value = sp.Platform;
                    myCommand.Parameters[5].Value = sp.Camera;
                    myCommand.Parameters[6].Value = sp.RAM;

                    myCommand.Parameters[7].Value = sp.Battery;
                    myCommand.Parameters[8].Value = sp.Price;
                    myCommand.Parameters[9].Value = sp.Avatar;


                    myCommand.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Can not open connection! " + ex.Message);
            }
            MessageBox.Show("Finish Update to DataSource SQL Server");
        }
    }
}
