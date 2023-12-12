using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace RegistrationAccountApp
{
    public partial class RegistrationForm : Form
    {
        string startupPath;
        string AvatarPath;
        Login ParentForm;
        public RegistrationForm()
        {
            InitializeComponent();
            startupPath = Login.OriginalForm.startupPath;
            ParentForm = Login.OriginalForm;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDlg.Title = "Find Avatar Images";
            openFileDlg.Filter = "IPG files|*.jpg"; openFileDlg.InitialDirectory = startupPath;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                AvatarPath = openFileDlg.FileName;
                picAvatar.Image = Image.FromFile(AvatarPath);
                startupPath = Path.GetDirectoryName(AvatarPath);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(RegistrationForm));
            picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            User obj = new User();
            Customer objCustomer = new Customer();
            if (txtUserID.Text.Trim().Length == 0 || txtPassWord.Text.Trim().Length == 0 || txtCustomerID.Text.Trim().Length == 0)
            {
                MessageBox.Show("CustomerID, UserName, Password are not blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                if (txtPassWord.Text != txtPassWordConfirm.Text)
                {
                    MessageBox.Show("Password and Comfirm Password are not matched", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                User SpecificOne = ParentForm.UserList.Find(x => (x.UserName == txtUserID.Text) && (x.Password == txtPassWord.Text));
                if (SpecificOne != null)
                {
                    MessageBox.Show("UserID is existed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                obj.UserName = txtUserID.Text;
                obj.Password = txtPassWord.Text;
                obj.CustomerID = txtCustomerID.Text;

                objCustomer.CustomerID = txtCustomerID.Text;
                objCustomer.CustomerName = txtCustomerName.Text;
                objCustomer.Birthday = dtBirthDay.Value;
                objCustomer.Nationallity = txtNationality.Text;
                objCustomer.PassPortNbr = txtPassPortNbr.Text;
                objCustomer.Sex = (rdMale.Checked == true) ? Sex.Male : Sex.Female;
                ParentForm.UserList.Add(obj);
                ParentForm.CustomerList.Add(objCustomer);
                
                MessageBox.Show("New UserID is Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = " ";
            txtCustomerName.Text = " ";
            txtNationality.Text = " ";  
            txtPassPortNbr.Text = " ";  
            txtPassWord.Text = " "; 
            txtPassWordConfirm.Text = " ";
            txtUserID.Text = " ";
            dtBirthDay.Value = DateTime.Now;

            ComponentResourceManager resources = new ComponentResourceManager(typeof(RegistrationForm));
            picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;



        }
    }
}
