using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketApp
{
    public partial class AirTicketBooking : Form
    {
        LoginForm ParentForm;
        string strRegistration;
        public Customer currentCustomer;
        public User currentUser;
        public int idxRegistration;
        public AirTicketBooking()
        {
            InitializeComponent();
            ParentForm = LoginForm.OriginalForm;


            foreach (Flight.FlightList flight in ParentForm.FlightList)
            {
                lsbFlightList.Items.Add(
                    $"Flight ID: {flight.FlightID} | Depart: {flight.TimeDepart} | Arrival: {flight.TimeArrival} | Type: {flight.FlightType}");
            }

            rtxtFlightRegistration.Text = "";
        }   
        public void SetCurrentUser(User user)
        {
            currentUser = user;
            currentCustomer = ParentForm.CustomerList.Find(x => x.CustomerID == currentUser.CustomerID);

            if (currentCustomer == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            idxRegistration = ParentForm.FlightRegList.FindIndex(x => x.FlightID == currentCustomer.CustomerID);

            if (idxRegistration >= 0)
            {
                foreach (Flight.FlightList flight in ParentForm.FlightRegList[idxRegistration].FlightEnrollList)
                {
                    lsbFlightList.Items.Add(
                        $"Flight ID: {flight.FlightID} | Depart: {flight.TimeDepart} | Arrival: {flight.TimeArrival} | Type: {flight.FlightType}");
                }
            }

            ShowRegistrationInfo();
        }
        public string ShowRegistrationInfo()
        {
            strRegistration = "\t\t\t Booking Registration of Customer \n";
            strRegistration += "__________________________________________________________________________\n";
            strRegistration += String.Format("\tCustomer ID: {0}\n \tCustomerName: {1} \n", currentCustomer.CustomerID, currentCustomer.CustomerName);
            strRegistration += "__________________________________________________________________________";


            foreach (Object selectedItem in lsbFlightList.SelectedItems)
            {
                string selectedText = selectedItem.ToString();
                string flightID = selectedText.Split('|')[0].Replace("Flight ID:", "").Trim();

                Flight.FlightList obj = ParentForm.FlightList.Find(x => x.FlightID == flightID);

                if (obj != null)
                {
                    strRegistration += $"\n\tFlight ID: {obj.FlightID}\n";
                    strRegistration += $"\tTime Depart: {obj.TimeDepart}\n";
                    strRegistration += $"\tTime Arrival: {obj.TimeArrival}\n";
                    strRegistration += $"\tFlight Type: {obj.FlightType}\n";
                    strRegistration += "\t-----------------------------------------\n";
                }
            }

            rtxtFlightRegistration.Text = strRegistration;

            return strRegistration;
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.ResetLogin = true;
            ParentForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idxRegistration < 0)
            {
                ParentForm.FlightRegList.Add(new Flight.FlightRegistration(currentCustomer.CustomerID));
                idxRegistration = ParentForm.FlightRegList.FindIndex(x => (x.FlightID == currentCustomer.CustomerID));

                Flight.FlightList obj;
                foreach (Object selectedItem in lsbFlightList.SelectedItems)
                {
                    obj = ParentForm.FlightList.Find(x => (x.FlightID == selectedItem.ToString()));
                    ParentForm.FlightRegList[idxRegistration].FlightEnrollList.Add(obj);
                }
            }

            ShowRegistrationInfo();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            string formattedMessage = ShowRegistrationInfo();

            MessageBox.Show(formattedMessage, "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
