using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AirTicketBooking : Form
    {
        Login ParentForm;
        string strRegistration;
        public Customer currentCustomer;
        public User currentUser;
        public int idxRegistration;
        public AirTicketBooking()
        {
            InitializeComponent(); 
            ParentForm = Login.OriginalForm;

            lsbFlightList.DrawMode = DrawMode.OwnerDrawFixed;
            lsbFlightList.DrawItem += lsbFlightList_DrawItem;

            foreach (Flight obj in ParentForm.FlightList)
            {
                lsbFlightList.Items.Add(obj.FlightID);
            }

            rtxtRegistrationinfo.Text = "";
        }
        
        public void SetCurrentUser(User user)
        {
            currentUser = user;
            currentCustomer = ParentForm.CustomerList.Find(x=>(x.CustomerID == currentUser.CustomerID));

            idxRegistration = ParentForm.FlightRegistrations.FindIndex(x => (x.CustomerID == currentCustomer.CustomerID));
            if(idxRegistration >= 0)
            {   
                foreach(Flight obj in ParentForm.FlightRegistrations[idxRegistration].FlightEnrollList)
                {
                    int idx = lsbFlightList.FindString(obj.FlightID.Trim());
                    lsbFlightList.SetSelected(idx, true);
                }
            }
            ShowRegistrationInfo();
        }

        public string ShowRegistrationInfo()
        {
            strRegistration = "\t\t\t Flight Registration of Customer \n";
            strRegistration += "_______________________________________________________\n";

            if (currentUser != null)
            {
                strRegistration += $"\tCustomerID: {currentUser.CustomerID}\n";
                strRegistration += $"\tCustomerName: {currentCustomer.CustomerName}\n";
            }

            decimal sumCredit = 0; // Use decimal for currency values
            if (idxRegistration >= 0)
            {
                strRegistration += "\nFlightID" + "\t" + "Departure Time" + "\t\t" + "Arrival Time" ;
                var registration = ParentForm.FlightRegistrations[idxRegistration];
                foreach (var selectedItem in lsbFlightList.SelectedItems)
                {
                    var selectedFlight = ParentForm.FlightList.Find(x => x.FlightID == selectedItem.ToString());
                    if (selectedFlight != null)
                    {
                        // Add the FlightCost to the sumCredit
                        sumCredit += selectedFlight.FlightCost;

                        strRegistration += $"\n{selectedFlight.FlightID}\t{selectedFlight.TimeDepart}\t{selectedFlight.TimeArrival}";
                    }
                }

                strRegistration += $"\nSum Of Registered Flights Cost: {sumCredit:C}\n"; // Display the sum in currency format
            }
            else
            {
                strRegistration += "\tSum Of Registered Flights: 0\n";
            }

            strRegistration += "_______________________________________________________\n";
            rtxtRegistrationinfo.Text = strRegistration;
            return strRegistration;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.ResetLogin = true;
            ParentForm.Show();
        }

        private void ShowTimeInfo(string flightID)
        {
            Flight selectedFlight = ParentForm.FlightList.Find(x => x.FlightID == flightID);

            if (selectedFlight != null)
            {
                MessageBox.Show($"Flight {selectedFlight.FlightID} Departure Time: {selectedFlight.TimeDepart}\n" +
                                $"Flight {selectedFlight.FlightID} Arrival Time: {selectedFlight.TimeArrival}",
                                "Flight Time Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Flight not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (idxRegistration < 0)
            {
                ParentForm.FlightRegistrations.Add(new FlightRegistration(currentUser.CustomerID));
                idxRegistration = ParentForm.FlightRegistrations.FindIndex(x => (x.CustomerID == currentCustomer.CustomerID));

                Flight obj;
                foreach (object selectedItem in lsbFlightList.SelectedItems)
                {
                    obj = ParentForm.FlightList.Find(x => (x.FlightID == selectedItem.ToString()));

                    // Ensure that FlightRegistration and obj are not null before accessing their properties
                    if (ParentForm.FlightRegistrations[idxRegistration] != null && obj != null)
                    {
                        ParentForm.FlightRegistrations[idxRegistration].FlightEnrollList.Add(obj);

                        // Show flight time information
                        ShowTimeInfo(obj.FlightID);
                    }
                }
            }

            ShowRegistrationInfo();
        }

    
        private void btnConfim_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowRegistrationInfo(),"Thanks You", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnShowListFlight_Click(object sender, EventArgs e)
        {
            FlightListForm flightListForm = new FlightListForm();
            flightListForm.Show();
        }

        private void lsbFlightList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            ListBox listBox = sender as ListBox;
            if (listBox != null && e.Index >= 0)
            {
                string itemText = listBox.Items[e.Index].ToString();
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                using (Brush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds, stringFormat);
                }
            }
        }


            private void lsbFlightList_SelectedIndexChanged(object sender, EventArgs e)
        {

            lsbFlightList.DrawMode = DrawMode.OwnerDrawFixed;
            lsbFlightList.DrawItem += new DrawItemEventHandler(lsbFlightList_DrawItem);
            lsbFlightList.Invalidate();
        }
    }
}
