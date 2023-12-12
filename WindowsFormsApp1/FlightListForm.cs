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
    public partial class FlightListForm : Form
    {
        string strRegistration;

        public FlightListForm()
        {
            InitializeComponent();
            PopulateFlightList();
        }

        private void PopulateFlightList()
        {
            // Set up columns in the ListView
            listViewFlights.View = View.Details;
            listViewFlights.Columns.Add("Flight ID", 150);
            listViewFlights.Columns.Add("Departure Time", 200);
            listViewFlights.Columns.Add("Arrival Time", 200);
            listViewFlights.Columns.Add("Flight Type", 100);

            // Assuming you have a reference to the ParentForm or have a static list of flights
            foreach (var flight in Login.OriginalForm.FlightList)
            {
                // Format each flight information for better display
                string[] flightInfo = {
                flight.FlightID,
                flight.TimeDepart.ToString("yyyy-MM-dd HH:mm:ss"),
                flight.TimeArrival.ToString("yyyy-MM-dd HH:mm:ss"),
                flight.FlightType
            };

                // Add each formatted flight information to the ListView
                var item = new ListViewItem(flightInfo);
                listViewFlights.Items.Add(item);
            }
        }
    }

    }
