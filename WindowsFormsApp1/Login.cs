using RegistrationAccountApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public static Login OriginalForm;

        public List<Customer> CustomerList;
        public List<Flight> FlightList;
        public List<User> UserList;
        public List<FlightRegistration> FlightRegistrations;

        public string startupPath;
        public bool ResetLogin;
        public Login()
        {
            InitializeComponent();

            OriginalForm = this;
            startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            CustomerList = new List<Customer>();

            CustomerList.Add(new Customer("CT001", "Admin", DateTime.Now, Sex.Male,"D11","VietNam",Image.FromFile(startupPath+ "\\img_Avatar\\CV2.png")));
            
            UserList = new List<User>();
            UserList.Add(new User("Admin", "1234", "CT0001"));
            UserList.Add(new User("1", "1", "111"));



            FlightList = new List<Flight>();
            FlightList.Add(new Flight("FL0001", DateTime.Now, DateTime.Now, "Bamboo",90000));
            FlightList.Add(new Flight("FL0002", DateTime.Now, DateTime.Now, "VN",20000));
            FlightList.Add(new Flight("FL0003", DateTime.Now, DateTime.Now, "US",30000));
            FlightList.Add(new Flight("FL0004", DateTime.Now, DateTime.Now, "UK",40000));
            FlightList.Add(new Flight("FL0005", DateTime.Now, DateTime.Now, "JP",50000));
            FlightList.Add(new Flight("FL0006", DateTime.Now, DateTime.Now, "CN",60000));

            FlightRegistrations = new List<FlightRegistration>();

            ResetLogin = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter user name","Input Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }

            if(txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }

            User SpecificOne = UserList.Find( x=> (x.UserName == txtUserName.Text)&&(x.Password == txtPassword.Text));
            if(SpecificOne == null)
            {
                Console.WriteLine(UserList);
                MessageBox.Show("Username and Password are not matched. \n Please reinput or register a new one",
                                "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Text = "";
                txtPassword.Text = ""; 
                txtUserName.Focus();
                return;
            }

            AirTicketBooking obj = new AirTicketBooking();
            User currentUser = UserList.Find(x=>(x.UserName==txtUserName.Text)&&(x.Password==txtPassword.Text));
            obj.SetCurrentUser(currentUser);
            this.Hide();
            obj.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void LinkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm obj = new RegistrationForm();
            this.Hide();
            obj.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(ResetLogin ==  true)
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }


    }
}
