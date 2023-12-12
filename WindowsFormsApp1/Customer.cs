using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum Sex { Male,Female};
    public class Customer
    {
        public string CustomerID {get; set;}
        public string CustomerName { get; set;}
        public DateTime Birthday { get; set;}
        public Sex Sex { get; set;}
        public string PassPortNbr {  get; set;}
        public string Nationallity {  get; set;}
        public Image Avatar { get; set;}

        public Customer()
        {
            CustomerID = "Not Assigned";
        }

        public Customer(string customerID, string customerName, DateTime birthday, Sex sex, string passPortNbr, string nationallity, Image avatar)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            Birthday = birthday;
            Sex = sex;
            PassPortNbr = passPortNbr;
            Nationallity = nationallity;
            Avatar = avatar;
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

        public User(string userName, string password, string customerID)
        {
            UserName = userName;
            Password = password;
            CustomerID = customerID;
        }
    }

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

    public class FlightRegistration
    {
        public string CustomerID { get;  set; }
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

        /*
        public int CalculateSumCredit()
        {
            return FlightEnrollList.Sum(x => x.NumCredit);
        }
        */
    }
}
