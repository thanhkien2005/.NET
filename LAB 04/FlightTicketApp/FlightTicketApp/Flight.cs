using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketApp
{
    public class Flight
    {
        public class FlightList
        {
            public string FlightID { get; set; }
            public DateTime TimeDepart { get; set; }
            public DateTime TimeArrival { get; set; }

            public string FlightType { get; set; }

            public FlightList()
            {
                FlightID = "Not Assigned";
            }
            public FlightList(string FlightID, DateTime TimeDepart, DateTime TimeArrival, string FlightType)
            {
                this.FlightID = FlightID;
                this.TimeDepart = TimeDepart;
                this.TimeArrival = TimeArrival;
                this.FlightType = FlightType;
            }
        }
        public class FlightRegistration
        {
            public string FlightID { get; set; }
            public List<FlightList> FlightEnrollList;

            public FlightRegistration()
            {
                FlightID = "Not Assigned";
                FlightEnrollList = new List<FlightList>();
            }
            public FlightRegistration(string FlightID)
            {
                this.FlightID = FlightID;
                FlightEnrollList = new List<FlightList>();
            }
        }
    }
}
