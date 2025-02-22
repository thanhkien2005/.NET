using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmartPhoneLINQ
{
    public partial class Form1 : Form
    {
        static string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        SmartPhoneDBDataContext db = new SmartPhoneDBDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void DisplayData()
        {
            dgwSmartPhone.DataSource = (from sp in db.SmartPhones select sp);
            dgwSmartPhone.Columns["ImageName"].Visible = false;
            dgwSmartPhone.Columns["SmartPhoneID"].ReadOnly = true;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void dgwSmartPhone_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwSmartPhone.Focused == false || dgwSmartPhone.CurrentCell == null)
                return;
            int RowIndex = dgwSmartPhone.CurrentRow.Index;
            string SelectedSmartPhoneID = dgwSmartPhone.Rows[RowIndex].Cells[0].Value.ToString();

            string SmartPhoneImage = (from sp in db.SmartPhones
                                      where sp.SmartPhoneID == SelectedSmartPhoneID
                                      select sp.ImageName).FirstOrDefault();
            if (SmartPhoneImage == null)
                return;
            picSmartPhone.Image = Image.FromFile(ProjectPath + "\\Data\\" + SmartPhoneImage);
            picSmartPhone.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete in Database
            int RowIndex = dgwSmartPhone.CurrentRow.Index;
            string SelectedSmartPhoneID = dgwSmartPhone.Rows[RowIndex].Cells[0].Value.ToString();

            SmartPhone deletedSP = (from sp in db.SmartPhones
                                    where sp.SmartPhoneID == SelectedSmartPhoneID
                                    select sp).SingleOrDefault();
            db.SmartPhones.DeleteOnSubmit(deletedSP);
            db.SubmitChanges();
            DisplayData();

            MessageBox.Show("SmartPhone: " + deletedSP.SmartPhoneID + "is deleted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int RowIndex = dgwSmartPhone.CurrentRow.Index;
            string SelectedSmartPhoneID = dgwSmartPhone.Rows[RowIndex].Cells[0].Value.ToString();

            SmartPhone updatedSP = (from sp in db.SmartPhones
                                    where sp.SmartPhoneID == SelectedSmartPhoneID
                                    select sp).SingleOrDefault();

            updatedSP.SmartPhoneID = dgwSmartPhone.Rows[RowIndex].Cells[0].Value.ToString();
            updatedSP.SmartPhone_Name = dgwSmartPhone.Rows[RowIndex].Cells[1].Value.ToString();
            updatedSP.Smart_Phone_Type = dgwSmartPhone.Rows[RowIndex].Cells[2].Value.ToString();
            updatedSP.Announced_Date = DateTime.Parse(dgwSmartPhone.Rows[RowIndex].Cells[3].Value.ToString());
            updatedSP.Platform = dgwSmartPhone.Rows[RowIndex].Cells[4].Value.ToString();
            updatedSP.Camera = dgwSmartPhone.Rows[RowIndex].Cells[5].Value.ToString();
            updatedSP.RAM = dgwSmartPhone.Rows[RowIndex].Cells[6].Value.ToString();
            updatedSP.Battery = dgwSmartPhone.Rows[RowIndex].Cells[7].Value.ToString();
            updatedSP.Price = Convert.ToInt32(dgwSmartPhone.Rows[RowIndex].Cells[8].Value.ToString());
            updatedSP.ImageName = "smartphone.jpg";

            db.SubmitChanges();
            DisplayData();
            MessageBox.Show("SmartPhone:" + updatedSP.SmartPhoneID + "is updated");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SmartPhone checkedSP;
            List<SmartPhone> SPList = (from sp in db.SmartPhones
                                       where sp.SmartPhoneID.Contains("NEW")
                                       select sp).ToList();
            string NewID = "NEW";
            if (SPList.Count == 0)
                NewID = NewID + "001";
            else
            {
                checkedSP = SPList.Last();
                NewID = NewID + NextId(checkedSP.SmartPhoneID.Substring(checkedSP.SmartPhoneID.Length - 3));
            }

            SmartPhone insertedSP = new SmartPhone();
            insertedSP.SmartPhoneID = NewID;
            insertedSP.SmartPhone_Name = "Not Assigned";
            insertedSP.Smart_Phone_Type = "Not Assigned";
            insertedSP.Announced_Date = DateTime.Now;
            insertedSP.Platform = "Not Assigned";
            insertedSP.Camera = "Not Assigned";
            insertedSP.RAM = "Not Assigned";
            insertedSP.Battery = "Not Assigned";
            insertedSP.Price = 0;
            insertedSP.ImageName = "smartphone.jpg";

            db.SmartPhones.InsertOnSubmit(insertedSP);
            db.SubmitChanges();
            DisplayData();
            MessageBox.Show("New SmartPhone is inserted! Please update data and press button Update");
        }
        public string NextId(string currentId)
        {
            int i = 0;
            if(int.TryParse(currentId, out i))
            {
                i++;
                return (i.ToString().PadLeft(3, '0'));
            }
            throw new System.ArgumentException("Non-numeric string passed as argument");
        }

    }
}
