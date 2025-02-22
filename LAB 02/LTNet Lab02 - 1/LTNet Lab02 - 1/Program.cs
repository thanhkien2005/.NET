using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using MainData;
using AttributeData;
using System.IO;
namespace AttributeData
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class MilkMoreInfo : System.Attribute
    {
        public string Manufacturer { get; set; }
        public string CompanyName { get; set; }

        public MilkMoreInfo(string Manufacturer = "", string CompanyName = "")
        {
            this.Manufacturer = Manufacturer;
            this.CompanyName = CompanyName;
        }
    }
}

delegate int MilkInputOutput(string filename);

namespace MilkManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk milk = new Milk();
            milk.ValMilkName = "Vinamilk";
            milk.ValProductionDate = "01/03/2016";
            milk.ValExpiredDate = "20/05/2017";
            milk.ValQuantity = 123456;

            MilkInputOutput action1 = new MilkInputOutput(milk.InputInfo);
            MilkInputOutput action2 = new MilkInputOutput(milk.OutputInfo);

            action1.Invoke("C:\\Users\\T K\\OneDrive - VNU-HCMUS\\Desktop\\Projects kì 5\\Project .NET\\LAB 02\\milk.txt");
            Console.WriteLine("Input Successfully");


            milk.ValQuantity = 789;
            action2.Invoke("C:\\Users\\T K\\OneDrive - VNU-HCMUS\\Desktop\\Projects kì 5\\Project .NET\\LAB 02\\OutputInfoByDelegate.txt");
            Console.WriteLine("Output Successfully");

            Console.ReadKey();
        }
    }
}

namespace MainData
{
    interface IMilkAction
    {
        int InputInfo(string filename);
        int OutputInfo(string filename);
    }

    [MilkMoreInfo("VietNamProduction", "Vina Company")]
    class Milk
    {
        public int InputInfo(string filename)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                string[] terms = line.Split(':');
                if (line.Contains("MilkName:")) ValMilkName = terms[1];
                if(line.Contains("ProductionDate :")) ValProductionDate = terms[1].Trim();
                if(line.Contains("ExpiredDate :")) ValExpiredDate = terms[1].Trim();
                if(line.Contains("Quantity :")) ValQuantity = float.Parse(terms[1].Trim());
                counter++;
            }
            file.Close();
            return counter;
        }

        public int OutputInfo(string filename)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);

            string OutputMessage = "";
            OutputMessage = String.Format("\n MilkID = {0}, \n MilkName = {1}", ValMilkID, ValMilkName);
            file.WriteLine(OutputMessage);
            OutputMessage = String.Format("\n ProductionDate = {0}, \n ExpiredDate = {1}", ValProductionDate, ValExpiredDate);
            file.WriteLine(OutputMessage);
            OutputMessage = string.Format("\n Quantity = {0} San Pham", ValQuantity);
            file.WriteLine(OutputMessage);

            file.Close();
            return 1;
        }

        private string MilkID = "MILK01032016";
        private string MilkName;
        private DateTime ProductionDate;
        private DateTime? ExpiredDate;
        private float Quantity;

        public Milk(string MilkName = "Not Assgined", string ProductionDate = "01/03/2016",
                    string ExpiredDate = null, float Quantity = 0)
        {
            this.MilkName = MilkName;
            this.ProductionDate = DateTime.ParseExact(ProductionDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (!string.IsNullOrEmpty(ExpiredDate))
            {
                this.ExpiredDate = DateTime.ParseExact(ExpiredDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                this.ExpiredDate = null; // hoặc một giá trị mặc định nào đó
            }
            this.Quantity = Quantity;
            this.MilkID = String.Format("MILK{0}", this.ProductionDate.ToString("ddMMYYYY"));
        }
        public string ValMilkID
        {
            get { return MilkID; }
        }

        public string ValMilkName
        {
            get { return MilkName; }
            set { MilkName = value; }
        }

        public string ValProductionDate
        {
            get { return ProductionDate.ToString("dd/MM/yyyy"); }
            set {
                ProductionDate = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                MilkID = String.Format("MILK{0}", this.ProductionDate.ToString("ddMMyyyy"));
            }
        }

        public string ValExpiredDate
        {
            get { return ExpiredDate.HasValue ? ExpiredDate.Value.ToString("dd/MM/yyyy") : "Not Assigned"; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    ExpiredDate = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                else
                {
                    ExpiredDate = null;
                }
            }
        }

        public float ValQuantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
    }
}