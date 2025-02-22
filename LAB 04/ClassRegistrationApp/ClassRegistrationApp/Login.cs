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

namespace ClassRegistrationApp
{
    public partial class LoginForm : Form
    {
        public static LoginForm OriginalForm;
        public List<Student> StudentList;
        public List<User> UserList;
        public List<Course> CourseList;
        public List<CourseRegistration> CourseRegList;
        public string startupPath;
        public bool ResetLogin;

        public LoginForm()
        {
            InitializeComponent();

            OriginalForm = this;
            startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            StudentList = new List<Student>();
            StudentList.Add(new Student("ST001", "Admin", Image.FromFile(startupPath + "\\Images\\Doraemon.jpg"),
                Sex.Male, DateTime.Now, "admin@gmail.com"));

            UserList = new List<User>();
            UserList.Add(new User("Admin", "1234", "ST001"));

            CourseList = new List<Course>();
            CourseList.Add(new Course("C001", "C# Programming", 4));
            CourseList.Add(new Course("C002", "Java Programming", 4));
            CourseList.Add(new Course("C003", "Data Structure", 4));
            CourseList.Add(new Course("C004", "Database Management", 4));
            CourseList.Add(new Course("C005", "Web Design", 4));
            CourseList.Add(new Course("C006", "Pattern Recognition", 4));
            CourseList.Add(new Course("C007", "Network Programming", 4));

            CourseRegList = new List<CourseRegistration>();
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

            ClassSelectionForm obj = new ClassSelectionForm();
            User currentUser = UserList.Find(x => (x.UserName == txtUserName.Text) && (x.Password == txtPassword.Text));
            obj.SetCurrentUser(currentUser);
            this.Hide();
            obj.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm obj = new RegistrationForm();
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
