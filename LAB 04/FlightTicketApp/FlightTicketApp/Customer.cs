using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FlightTicketApp
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime Birthday { get; set; }
        public string PassportNumber { get; set; }
        public string Nationality { get; set; }
        public Image Avatar { get; set; }

        public Customer()
        {
            CustomerID = "Not Assigned";
        }
        public Customer(string CustomerID, string CustomerName, Image Avatar, DateTime Birthday, string PassportNumber, string Nationality)
        {
            this.Avatar = Avatar;
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
            this.Birthday = Birthday;
            this.PassportNumber = PassportNumber;
            this.Nationality = Nationality;
        }
    }
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CustomerID { get; set; }

        public User()
        {
            UserName = "Not Assigned";
        }
        public User(string UserName, string Password, string CustomerID)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.CustomerID = CustomerID;
        }
    }
}
