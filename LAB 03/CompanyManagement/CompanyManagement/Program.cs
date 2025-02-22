using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainData;

namespace CompanyManagement
{
    class Program
    {
        static void UpdateNumberOfCustomers(Company company)
        {
            company.ValNumberOfCustomers = company.ListOfCustomers.Count;
        }
        static void Main(string [] args)
        {
            Company company = new Company();
            company.ValCompanyName = "Vinhomes";

            company.CompanyAddorRemoveEvent += new Company.CompanyHandler(UpdateNumberOfCustomers);

            company.ListOfCustomers.Add(new Customer("C002","Nguyen Dang Khoi", "Vinhomes Grand Park S7.02", 0987654321, CustomerType.TiemNang));
            company.ListOfCustomers.Add(new Customer("C003", "Tran Hong Tinh", "Vinhomes Grand Park S5.03", 0135792468, CustomerType.CanQuanTam));
            company.ListOfCustomers.Add(new Customer("C004", "KevinSanjaya", "Vinhomes Grand Park S7.02", 0246813579, CustomerType.KhachHangKhac));

            Customer customer = company.SearchCustomer("C002");
            company.RemoveCustomer(customer);

            company.CompanyInfo();

            Console.ReadKey();

        }
    }
}

namespace MainData
{
    public enum CustomerType { TrungThanh, TiemNang, CanQuanTam, KhachHangKhac };

    public class Customer
    {
        string CustomerID = "C001";
        string CustomerName = "Nguyen Thanh Kien";
        string CustomerAddress = "Vinhomes Grand Park S1.02";
        int CustomerPhone = 0123456789;
        CustomerType type = CustomerType.TrungThanh;
        
        public Customer() {}
        public Customer(string CustomerID, string CustomerName, string CustomerAddress, int CustomerPhone, CustomerType type)
        {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
            this.CustomerAddress = CustomerAddress;
            this.CustomerPhone = CustomerPhone;
            this.type = type;
        }
        public string ValCustomerID
        {
            get { return CustomerID; }
            set { CustomerID = value; }
        }
        public string ValCustomerName
        {
            get { return CustomerName; }
            set { CustomerName = value; }
        }
        public string ValCustomerAddress
        {
            get { return CustomerAddress; }
            set { CustomerAddress = value; }
        }
        public int ValCustomerPhone
        {
            get { return CustomerPhone; }
            set { CustomerPhone = value; }
        }
        public CustomerType valtype
        {
            get { return type; }
            set { type = value; }
        }

        public void CustomerInfo()
        {
            string typeName = Enum.GetName(typeof(CustomerType), type);

            if(CustomerID  != "C001")
                Console.WriteLine("Khach Hang {0} co ten la {1}, dia chi la {2}, so dien thoai la {3}, \nLa dang khach hang {4}\n",
                    CustomerID, CustomerName, CustomerAddress, CustomerPhone, typeName);
        }
    }
    public class Company
    {
        public List<Customer> ListOfCustomers { get; set; }
        Dictionary<CustomerType, string> TypeInfo = new Dictionary<CustomerType, string>();

        public delegate void CompanyHandler (Company company);
        public event CompanyHandler CompanyAddorRemoveEvent;

        string CompanyName;
        int NumberOfCustomers = 0;

        public int ValNumberOfCustomers
        {
            get { return NumberOfCustomers; }
            set { NumberOfCustomers = value; }

        }
        public Company()
        {
            ListOfCustomers = new List<Customer>();
            CompanyName = "Not Assigned";
            TypeInfo.Add(CustomerType.TiemNang, "Khach hang nay co tiem nang gia han hop dong thue va mua ban nha");
            TypeInfo.Add(CustomerType.CanQuanTam, "Khach hang nay can co nhieu thoi gian de tim hieu de co the thue hoac mua nha");
            TypeInfo.Add(CustomerType.KhachHangKhac, "Khach hang nay khong co du dinh mua hay thue nha");
            TypeInfo.Add(CustomerType.TrungThanh, "Khach hang nay chac chan se thue hoac mua nha");
        }

        public string ValCompanyName
        {
            get { return CompanyName; }
            set { CompanyName = value; }
        }

        public void CompanyInfo()
        {
            Console.WriteLine("Cong ty {0} co {1} khach hang. Gom cac khach hang nhu sau:\n", CompanyName, NumberOfCustomers);
            foreach (Customer rm in ListOfCustomers)
            {
                KeyValuePair<CustomerType, string> info = TypeInfo.FirstOrDefault(o => o.Key == rm.valtype);
                rm.CustomerInfo();
                Console.WriteLine("----Thong Tin Khach Hang: {0}\n", info.Value);
            }
        }

        public void AddCustomer(Customer customer)
        {
            ListOfCustomers.Add(customer);
            OnCompanyChanger(this);
        }

        public void RemoveCustomer(Customer customer)
        {
            ListOfCustomers.Remove(customer);
            OnCompanyChanger(this);
        }

        public void OnCompanyChanger(Company company)
        {
            if (CompanyAddorRemoveEvent != null)
            {
                CompanyAddorRemoveEvent(this);
            }
        }
        public Customer SearchCustomer<T> (T search)
        {
            Customer r = new Customer();
            if (typeof(T) == typeof(string))
            {
                r = ListOfCustomers.FirstOrDefault(o => o.ValCustomerID == search.ToString());
                if (r != null)
                    return r;
            }
            else if (typeof(T) == typeof(int))
            {
                if (Convert.ToInt32(search) < ListOfCustomers.Count)
                    return ListOfCustomers[Convert.ToInt32(search)];
            }
            Console.WriteLine("Customer is not found");
            return new Customer();
        }
    }
    public static class MyExtensions
    {
        public static string ConvertToString(this Customer customer)
        {
            string typeName = Enum.GetName(typeof(CustomerType), customer.valtype);

            if (customer.ValCustomerID != "C001")
                return String.Format("Khach Hang: {0} - {1} - {2} - {3} la loai khach hang {4}",
                    customer.ValCustomerID, customer.ValCustomerName, customer.ValCustomerAddress, customer.ValCustomerPhone, typeName);
            else
                return " ";
        }
    }
}
