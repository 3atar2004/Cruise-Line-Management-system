using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruise_Line
{
    public partial class ViewCustomerInfo : Form
    {
        Controller controllerobj = new Controller();
        string username;
        public ViewCustomerInfo(string username)
        {
            InitializeComponent();
            this.username = username;
            DataTable dt = controllerobj.getPerson(username);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                string email = row["Email"].ToString();
                string address = row["Address"].ToString();
                string phone = row["Phone"].ToString();
                string password = row["Password"].ToString();
                string firstName = row["FName"].ToString();
                string lastName = row["LName"].ToString();
                string role = row["Role"].ToString();
                string city = row["City"].ToString();
                string country = row["Country"].ToString();
                string ssn = row["Ssn"].ToString();
                string gender = row["Gender"].ToString();
                EmailLabel.Text = email;
                phoneLabel.Text = phone;
                FullNameLabel.Text = firstName +" "+ lastName;
                SSNlabel.Text = ssn;
                CountryLabel.Text = country;
                CityLabel.Text = city;
                AddressLabel.Text = address;
                GenderLabel.Text = gender;
                
            }
            else
            {
                MessageBox.Show("User not found.");
            }
            changeEmailBox.Visible = false;
            changeEmailError.Visible = false;
            DoneEmail.Visible = false;
            EnterEmailLabel.Visible = false;
            EnterPhoneLabel.Visible = false;
            changePhoneNumberBox.Visible = false;
            changePhoneError.Visible = false;
            DonePhone.Visible = false;
            PasswordError.Visible = false;
            string Loyalty = controllerobj.getLoyalty(username);
            int loyalty = Convert.ToInt32(Loyalty);
            LoyaltyLabel.Text = Loyalty;
            if (loyalty >= 1000)
            {
                LoyaltyLabel.ForeColor = Color.Silver;
                label2.Text = "Loyalty Points\n Silver Member";
            }
            if (loyalty >= 1500)
            {
                
                LoyaltyLabel.ForeColor = Color.Gold;
                label2.Text = "Loyalty Points\n Gold Member";
            }
            if (loyalty >= 2000)
            {
                LoyaltyLabel.ForeColor = Color.Turquoise;
                label2.Text = "Loyalty Points\n Diamond Member";
            }
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            changeEmailBox.Visible = true;
            DoneEmail.Visible = true;
            EnterEmailLabel.Visible = true;

        }

        private void DoneEmail_Click(object sender, EventArgs e)
        {
            if(changeEmailBox.Text == "")
            {
                changeEmailError.Visible = true;
                return;
            }
            string Email = changeEmailBox.Text;
            if(controllerobj.changeEmail(username,Email) == 0) {
                changeEmailError.Visible = true;
                changeEmailError.Text = "Failed to update Email,not in correct format";
                return;
            }
            else
            {
                MessageBox.Show("Email Updated Successfully");
                return;
            }


            
        }

        private void changePhoneNumberButton_Click(object sender, EventArgs e)
        {
            changePhoneNumberBox.Visible = true;
            DonePhone.Visible = true;
            EnterPhoneLabel.Visible = true;
        }

        private void DonePhone_Click(object sender, EventArgs e)
        {

            if (changePhoneNumberBox.Text == "")
            {
                changePhoneError.Visible = true;
                return;
            }
            string phone = changePhoneNumberBox.Text;
            if (!phone.All(char.IsDigit))
            {
                changePhoneError.Visible = true;
                changePhoneError.Text = "Phone number must only contain numbers";
                return;
            }

            if (controllerobj.changePhone(username, phone) == 0)
            {
                changePhoneNumberBox.Text = "Failed to update Phone";
                return;
            }
            else
            {
                MessageBox.Show("Phone Number Updated Successfully");
                return;
            }


        }


        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if(changePasswordBox.Text == "")
            {
                PasswordError.Text = "Please Enter Password to be Changeed";
                return;
            }
            if(controllerobj.ChangePassword(username,changePasswordBox.Text) == 1)
            {
                MessageBox.Show("Password Changed Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Change Password");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerInterface page = new CustomerInterface(username);
            page.Show();
        }
    }
}
