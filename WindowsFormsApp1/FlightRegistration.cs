using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FlightRegistration
    {
        public string CustomerID { get; set; }
        public List<Flight> FlightEnrollList;

        public FlightRegistration()
        {
            CustomerID = "Not Assigned";
            FlightEnrollList = new List<Flight>();
        }

        public FlightRegistration(string CustomerID)
        {
            this.CustomerID = CustomerID;
            FlightEnrollList = new List<Flight>();
        }
    }
}
