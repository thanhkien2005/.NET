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
namespace LaptopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgwLaptopList.SelectionChanged += dgwLaptopList_SelectionChanged;
            dgwLaptopList.EditingControlShowing += dgwLaptopList_EditingControlShowing;
        }
        public List<Laptop> SPList = new List<Laptop>();
        // loadData = 0 (chua co du lieu);
        // loadData = 1 (co du lieu tu excel);
        // loadData = 2 (co du lieu tu sql);
        public int loadData = 0;
        static string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string ExcelFilePath = ProjectPath + "\\Data\\LaptopDB.xlsx";
        string connetionString =
            "Data Source = DESKTOP-H37FLVP\\SQLEXPRESS; Initial Catalog = LaptopDB ; Integrated Security=SSPI";
        int CurrentLaptopIndex = -1;
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
                LaptopID = x.LaptopID,
                LaptopName = x.LaptopName,
                LaptopType = x.LaptopType,
                ProductDate = x.ProductDate.ToString("dd/MM/yyyy"),
                Processor = x.Processor,
                HDD = x.HDD,
                RAM = x.RAM,
                Price = x.Price.ToString() + "kVND",
            }).ToList();

            datatable.Columns.Add("LaptopID");
            datatable.Columns.Add("LaptopName");
            datatable.Columns.Add("LaptopType");
            datatable.Columns.Add("ProductDate");
            datatable.Columns.Add("Processor");
            datatable.Columns.Add("HDD");
            datatable.Columns.Add("RAM");
            datatable.Columns.Add("Price");

            DataRow newrow;
            foreach (var bi in sublist)
            {
                newrow = datatable.NewRow();
                newrow["LaptopID"] = bi.LaptopID;
                newrow["LaptopName"] = bi.LaptopName;
                newrow["LaptopType"] = bi.LaptopType;
                newrow["ProductDate"] = bi.ProductDate;
                newrow["Processor"] = bi.Processor;
                newrow["HDD"] = bi.HDD;
                newrow["RAM"] = bi.RAM;
                newrow["Price"] = bi.Price;
                datatable.Rows.Add(newrow);
                datatable.AcceptChanges();
            }
            biding.AllowNew = true;
            biding.DataSource = datatable;
            dgwLaptopList.AutoGenerateColumns = false;
            dgwLaptopList.DataSource = biding;
        }
        public int ReadDataFromFile(List<Laptop> Datalist, string FilePath, int colCount)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(FilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            xlWorksheet.Columns.ClearFormats();
            xlWorksheet.Rows.ClearFormats();

            int rowCount = xlWorksheet.UsedRange.Rows.Count;

            int numLaptop = 0;
            string LaptopID = ""; ;
            string LaptopName = "";
            string LaptopType = "";
            DateTime ProductDate = DateTime.Now;
            string Processor = "";
            string HDD = "";
            string RAM = "";
            int Price = 0;
            string Avatar = "";

            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    switch (j)
                    {
                        case 1: // Column LaptopID
                            LaptopID = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 2: // Column LaptopName
                            LaptopName = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 3: // Column LaptopType
                            LaptopType = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 4: // Column ProductDate 
                            ProductDate = DateTime.ParseExact(xlRange.Cells[i, j].Value2.ToString(),
                                "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            break;
                        case 5: // Column Processor
                            Processor = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 6: // Column HDD
                            HDD = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 7: // Column RAM
                            RAM = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 8: // Column Price
                            Price = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString());
                            break;
                        case 9: // Column Avatar
                            Avatar = xlRange.Cells[i, j].Value2.ToString();
                            break;
                    }
                }
                Datalist.Add(new Laptop());
                Datalist[numLaptop].LaptopID = LaptopID;
                Datalist[numLaptop].LaptopName = LaptopName;
                Datalist[numLaptop].LaptopType = LaptopType;
                Datalist[numLaptop].ProductDate = ProductDate;
                Datalist[numLaptop].Processor = Processor;
                Datalist[numLaptop].HDD = HDD;
                Datalist[numLaptop].RAM = RAM;
                Datalist[numLaptop].Price = Price;
                Datalist[numLaptop].Avatar = Avatar;
                numLaptop = numLaptop + 1;
            }
            xlApp.Quit();
            MessageBox.Show("Load Data Form Excel Finished!: " + (rowCount - 1).ToString() + "Records");
            return (rowCount - 1); //Khong tinh dong tieu de
        }
        private void dgwLaptopList_SelectionChanged(object sender, EventArgs e)
        {
            if (SPList.Count == 0 || datatable.Rows.Count == 0)
                return;
            CurrentLaptopIndex = dgwLaptopList.CurrentRow.Index;
            if (CurrentLaptopIndex >= 0 && CurrentLaptopIndex < SPList.Count)
                picLaptopImage.Image = Image.FromFile(ProjectPath + "\\Data\\" + SPList[CurrentLaptopIndex].Avatar);
        }

        private void btnLoadSQL_Click(object sender, EventArgs e)
        {
            loadData = 2;
            datatable = new System.Data.DataTable();
            SPList.Clear();

            int NumDataRow = ReadDataFromSQLServer(SPList, connetionString);

            var sublist = SPList.Select(x => new
            {
                LaptopID = x.LaptopID,
                LaptopName = x.LaptopName,
                LaptopType = x.LaptopType,
                ProductDate = x.ProductDate.ToString("dd/MM/yyyy"),
                Processor = x.Processor,
                HDD = x.HDD,
                RAM = x.RAM,
                Price = x.Price.ToString() + "kVND",
            }).ToList();

            datatable.Columns.Add("LaptopID");
            datatable.Columns.Add("LaptopName");
            datatable.Columns.Add("LaptopType");
            datatable.Columns.Add("ProductDate");
            datatable.Columns.Add("Processor");
            datatable.Columns.Add("HDD");
            datatable.Columns.Add("RAM");
            datatable.Columns.Add("Price");

            DataRow newrow;
            foreach (var bi in sublist)
            {
                newrow = datatable.NewRow();
                newrow["LaptopID"] = bi.LaptopID;
                newrow["LaptopName"] = bi.LaptopName;
                newrow["LaptopType"] = bi.LaptopType;
                newrow["ProductDate"] = bi.ProductDate;
                newrow["Processor"] = bi.Processor;
                newrow["HDD"] = bi.HDD;
                newrow["RAM"] = bi.RAM;
                newrow["Price"] = bi.Price;
                datatable.Rows.Add(newrow);
                datatable.AcceptChanges();
            }
            biding.AllowNew = true;
            biding.DataSource = datatable;
            dgwLaptopList.AutoGenerateColumns = false;
            dgwLaptopList.DataSource = biding;
        }
        public int ReadDataFromSQLServer(List<Laptop> DataList, string connectionString)
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
                                    LaptopID,
                                    LaptopName,
                                    LaptopType,
                                    ProductDate = Convert(varchar(10),CONVERT(date,ProductDate,106), 103),
                                    Processor,
                                    HDD,
                                    RAM,
                                    Price,
                                    ImageName
                                    FROM dbo.LaptopDB";
                using (var command = new SqlCommand(SqlString, cnn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SPList.Add(new Laptop());
                            SPList[iRow].LaptopID = reader.GetString(0);
                            SPList[iRow].LaptopName = reader.GetString(1);
                            SPList[iRow].LaptopType = reader.GetString(2);
                            SPList[iRow].ProductDate = DateTime.ParseExact(reader.GetString(3), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            SPList[iRow].Processor = reader.GetString(4);
                            SPList[iRow].HDD = reader.GetString(5);
                            SPList[iRow].RAM = reader.GetString(6);
                            SPList[iRow].Price = reader.GetInt32(7);
                            SPList[iRow].Avatar = reader.GetString(8);

                            iRow = iRow + 1;
                        }
                    }
                }
                SqlCommand cmd = new SqlCommand("Select count(*) from LaptopDB", cnn);
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
        private void dgwLaptopList_EditingControlShowing(object sender,
                                                        DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnPrice_KeyPress);
            if (dgwLaptopList.CurrentCell.ColumnIndex == 7) //Colum Price
            {
                System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnPrice_KeyPress);
                }
            }
        }
        private void ColumnPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Laptop sp = new Laptop();
            sp.LaptopID = "Not Assigned";
            sp.LaptopName = "Not Assigned";
            sp.LaptopType = "Not Assigned";
            sp.ProductDate = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            sp.Processor = "Not Assigned";
            sp.HDD = "Not Assigned";
            sp.RAM = "Not Assigned";
            sp.Price = 0;
            sp.Avatar = "images.jpg";
            SPList.Add(sp);

            DataRow newrow;
            newrow = datatable.NewRow();
            newrow["LaptopID"] = sp.LaptopID;
            newrow["LaptopName"] = sp.LaptopName;
            newrow["LaptopType"] = sp.LaptopType;
            newrow["ProductDate"] = sp.ProductDate.ToString("dd/MM/yyyy");
            newrow["Processor"] = sp.Processor;
            newrow["HDD"] = sp.HDD;
            newrow["RAM"] = sp.RAM;
            newrow["Price"] = sp.Price.ToString() + "kVND";
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

                SPList[i].LaptopID = row["LaptopID"].ToString();
                SPList[i].LaptopName = row["LaptopName"].ToString();
                SPList[i].LaptopType = row["LaptopType"].ToString();
                SPList[i].ProductDate = DateTime.ParseExact(row["ProductDate"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                SPList[i].Processor = row["Processor"].ToString();
                SPList[i].HDD = row["HDD"].ToString();
                SPList[i].RAM = row["RAM"].ToString();
                string sPrice = row["Price"].ToString();

                // Bo chu kVND phia sau

                // Kiểm tra nếu chuỗi có chứa "kVND" và cắt bỏ phần đó
                if (sPrice.Contains("kVND"))
                {
                    sPrice = sPrice.Substring(0, sPrice.IndexOf("kVND")).Trim();  // Loại bỏ "kVND"
                }

                SPList[i].Price = Convert.ToInt32(sPrice);
            }
            MessageBox.Show("Finish Update");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Laptop sp;
            if (CurrentLaptopIndex >= 0)
                sp = SPList[CurrentLaptopIndex];
            else
                return;

            string question = "Do you want to delete laptop:" + sp.LaptopID;
            DialogResult result = MessageBox.Show(question, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SPList.RemoveAt(CurrentLaptopIndex);
                biding.RemoveAt(CurrentLaptopIndex);
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
        public void WriteDataToExcelFile(List<Laptop> SPList, string ExcelFilePath)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            Excel.Range xlRange;
            string[,] Data = new string[1, 10];

            int idxRow = 2;
            foreach (Laptop sp in SPList)
            {
                Data[0, 0] = sp.LaptopID;
                Data[0, 1] = sp.LaptopName;
                Data[0, 2] = sp.LaptopType;
                Data[0, 3] = sp.ProductDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                Data[0, 4] = sp.Processor;
                Data[0, 5] = sp.HDD;
                Data[0, 6] = sp.RAM;
                Data[0, 7] = sp.Price.ToString();
                Data[0, 8] = sp.Avatar;

                xlRange = xlWorksheet.get_Range("A" + idxRow.ToString(), "J" + idxRow.ToString());
                xlRange.Value2 = Data;

                idxRow = idxRow + 1;

            }
            xlWorkbook.Save();
            xlWorkbook.Close();
            xlApp.Quit();

            MessageBox.Show("Finish Update to DataSource Excel");
        }
        public void WriteDataToSQLServer(List<Laptop> SPList, string connectionString)
        {
            SqlConnection cnn;
            SqlCommand myCommand = new SqlCommand();
            string query;

            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open! ");

                query = "TRUNCATE TABLE LaptopDB";
                myCommand.CommandText = query;
                myCommand.Connection = cnn;
                myCommand.ExecuteNonQuery();

                query = @"INSERT INTO LaptopDB(LaptopID, LaptopName, LaptopType, ProductDate, Processor, 
                                            HDD, RAM, Price, ImageName)";
                query += "VALUES (@LaptopID, @LaptopName, @LaptopType, @ProductDate, @Processor, @HDD, @RAM, @Price, @ImageName)";

                myCommand.CommandText = query;
                myCommand.Connection = cnn;

                myCommand.Parameters.Add(new SqlParameter("@LaptopID", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@LaptopName", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@LaptopType", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@ProductDate", SqlDbType.DateTime));
                myCommand.Parameters.Add(new SqlParameter("@Processor", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@HDD", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@RAM", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Int));
                myCommand.Parameters.Add(new SqlParameter("@ImageName", SqlDbType.NVarChar));

                foreach (Laptop sp in SPList)
                {
                    myCommand.Parameters[0].Value = sp.LaptopID;
                    myCommand.Parameters[1].Value = sp.LaptopName;
                    myCommand.Parameters[2].Value = sp.LaptopType;

                    myCommand.Parameters[3].Value = sp.ProductDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                    myCommand.Parameters[4].Value = sp.Processor;
                    myCommand.Parameters[5].Value = sp.HDD;
                    myCommand.Parameters[6].Value = sp.RAM;
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

