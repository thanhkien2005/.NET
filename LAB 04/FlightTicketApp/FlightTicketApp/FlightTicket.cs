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
    public partial class FlightTicket : Form
    {
        LoginForm ParentForm;
        public Customer currentCustomer;
        public User currentUser;
        public FlightTicket(User user)
        {
            InitializeComponent();
            currentUser = user;
            ParentForm = LoginForm.OriginalForm;
        }

        public void SetCurrentUser(User user)
        {
            currentUser = user;
            currentCustomer = ParentForm.CustomerList.Find(x => (x.CustomerID == currentUser.CustomerID));
        }
        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            string flightID = txtFlightID.Text;
            DateTime timeDepart = dtTimeDepart.Value;
            DateTime timeArrival = dtTimeArrival.Value;
            string flightType = txtFlightType.Text;

            if (string.IsNullOrWhiteSpace(flightID) || string.IsNullOrWhiteSpace(flightType))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chuyến bay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newFlight = new Flight.FlightList
            {
                FlightID = flightID,
                TimeDepart = timeDepart,
                TimeArrival = timeArrival,
                FlightType = flightType
            };


            ParentForm.FlightList.Add(newFlight);

            txtFlightID.Clear();
            txtFlightType.Clear();
            dtTimeDepart.Value = DateTime.Now;
            dtTimeArrival.Value = DateTime.Now;

            MessageBox.Show("Chuyến bay đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            AirTicketBooking obj = new AirTicketBooking();
            obj.SetCurrentUser(currentUser);
            this.Hide();
            obj.Show();
        }
    }
}
