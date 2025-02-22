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
using Microsoft.VisualBasic.Devices;

namespace FlightTicketApp
{
    public partial class LoginForm : Form
    {
        public static LoginForm OriginalForm;
        public List<Customer> CustomerList;
        public List<User> UserList;
        public List<Flight.FlightList> FlightList = new List<Flight.FlightList>();
        public List<Flight.FlightRegistration> FlightRegList;
        public string startupPath;
        public bool ResetLogin;

        public LoginForm()
        {
            InitializeComponent();

            OriginalForm = this;
            startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            CustomerList = new List<Customer>();
            CustomerList.Add(new Customer("F101", "Admin", Image.FromFile(startupPath + "\\Images\\Doraemon.jpg"),
                 DateTime.Now, "VN12345678", "VietNam"));

            UserList = new List<User>();
            UserList.Add(new User("Admin", "1234", "F101"));

            FlightList = new List<Flight.FlightList>();

            FlightRegList = new List<Flight.FlightRegistration>();
            ResetLogin = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }

            User SpecificOne = UserList.Find(x => (x.UserName == txtUserName.Text) && (x.Password == txtPassword.Text));
            if (SpecificOne == null)
            {
                MessageBox.Show("Username and Password are not matched. \n Please reinput or register a new one ",
                    "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }

            FlightTicket obj = new FlightTicket(SpecificOne);
            User currentUser = UserList.Find(x => (x.UserName == txtUserName.Text) && (x.Password == txtPassword.Text));
            obj.SetCurrentUser(currentUser);
            this.Hide();
            obj.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration obj = new Registration();
            this.Hide();
            obj.Show();
        }
        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (ResetLogin == true)
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
