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
}
