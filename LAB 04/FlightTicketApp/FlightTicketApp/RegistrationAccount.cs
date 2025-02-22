using System.ComponentModel;

namespace FlightTicketApp
{
    public partial class Registration : Form
    {
        string startupPath;
        string AvatarPath;
        LoginForm ParentForm;
        public Registration()
        {
            InitializeComponent();
            startupPath = LoginForm.OriginalForm.startupPath;
            ParentForm = LoginForm.OriginalForm;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDlg.Title = "Find Avatar Images";
            openFileDlg.Filter = "JPG files|*.jpg";
            openFileDlg.InitialDirectory = startupPath;

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                AvatarPath = openFileDlg.FileName;
                picAvatar.Image = Image.FromFile(AvatarPath);

                startupPath = Path.GetDirectoryName(AvatarPath);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Registration));
            picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCreated_Click(object sender, EventArgs e)
        {
            User obj = new User();
            Customer objcustomer = new Customer();

            if (txtUserName.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0 || txtCustomerID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Customer, UserName, Password are not blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPassword.Text != txtComfirmedPassword.Text)
            {
                MessageBox.Show("Password and Comfirm Password are not matched", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            User SpecificOne = ParentForm.UserList.Find(x => (x.UserName == txtUserName.Text) && (x.Password == txtPassword.Text));
            if (SpecificOne != null)
            {
                MessageBox.Show("UserID is existed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            obj.UserName = txtUserName.Text;
            obj.Password = txtPassword.Text;
            obj.CustomerID = txtCustomerID.Text;

            objcustomer.CustomerID = txtCustomerID.Text;
            objcustomer.CustomerName = txtCustomerName.Text;
            objcustomer.PassportNumber = txtPassportNumber.Text;
            objcustomer.Nationality = txtNationality.Text;
            objcustomer.Avatar = picAvatar.Image;
            objcustomer.Birthday = dtBirthday.Value;


            ParentForm.UserList.Add(obj);
            ParentForm.CustomerList.Add(objcustomer);

            MessageBox.Show("New UserID is Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            dtBirthday.Value = DateTime.Now;
            txtUserName.Text = "";
            txtPassportNumber.Text = "";
            txtNationality.Text = "";
            txtPassword.Text = "";
            txtComfirmedPassword.Text = "";

            ComponentResourceManager resources = new ComponentResourceManager(typeof(Registration));
            picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
