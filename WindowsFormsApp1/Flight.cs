using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Flight
    {
        public string FlightID { get; set; }
        public DateTime TimeDepart { get; set; }
        public DateTime TimeArrival { get; set; }
        public string FlightType { get; set; }
        public decimal FlightCost { get; set; } // New property for flight cost

        public Flight()
        {
            FlightID = "Not Assigned";
        }

        public Flight(string flightID, DateTime timeDepart, DateTime timeArrival, string flightType, decimal flightCost)
        {
            FlightID = flightID;
            TimeDepart = timeDepart;
            TimeArrival = timeArrival;
            FlightType = flightType;
            FlightCost = flightCost;
        }
    }
}
