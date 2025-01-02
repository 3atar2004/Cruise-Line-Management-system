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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cruise_Line
{
    
    public partial class AddStaff : UserControl
    {
        string Role;
        Controller obj = new Controller();
        public AddStaff(string role)
        {
            InitializeComponent();
            Role = role;
            if (role == "M")
            {
                jobtitlebox.Visible = false;
                jobTitleLabel.Visible = false;
                button1.Text = "Add Manager";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (fnamebox.Text == "")
            {
                MessageBox.Show("First Name Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Lnamebox.Text=="")
            {
                MessageBox.Show("Last Name Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(ssnbox.Text=="")
            {
                MessageBox.Show("SSN Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(phonebox.Text=="")
            {
                MessageBox.Show("Phone Number Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(jobtitlebox.Text=="" &&  Role != "M")
            {
                MessageBox.Show("Job title Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(gendercombobox.SelectedIndex==-1)
            {
                MessageBox.Show("Please Select a gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(emailbox.Text=="")
            {
                MessageBox.Show("email Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(addressbox.Text=="")
            {
                MessageBox.Show("address Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(citybox.Text=="")
            {
                MessageBox.Show("City  Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(countrybox.Text=="")
            {
                MessageBox.Show("Country Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(emailbox.Text=="")
            {
                MessageBox.Show("email Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(passwordbox.Text=="")
            {
                MessageBox.Show("Password Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(reenterpassbox.Text=="")
            {
                MessageBox.Show("Please Re-enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (usernamebox.Text == "")
            {
                MessageBox.Show("Username can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(emailbox.Text, emailPattern))
            {
                MessageBox.Show("Email not in correct format");
                return;
            }
            else
            {

                /// first we need to check that the email doesn't exist ///
                int checkemail = obj.CountEmail(emailbox.Text);
                if(checkemail>0)
                {
                    MessageBox.Show("email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int checkusername = obj.CountUsername(usernamebox.Text);
                if(checkusername>0)
                {
                    MessageBox.Show("username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int ssn = 0;
                if(!int.TryParse(ssnbox.Text,out ssn))
                {
                    MessageBox.Show("Please enter a valid ssn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(passwordbox.Text!=reenterpassbox.Text)
                {
                    MessageBox.Show("passwords doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string fname = fnamebox.Text;
                string lname = Lnamebox.Text;
                string jobtitle = jobtitlebox.Text;
                string gender = (string)gendercombobox.SelectedItem;
                string address = addressbox.Text;
                string city = citybox.Text;
                string country = countrybox.Text;
                string username = usernamebox.Text;
                string password = passwordbox.Text;
                string email = emailbox.Text;
                string phone = phonebox.Text;
               
                int result = obj.AddPerson(username, email, address, phone, password, fname, lname,Role, city, country, ssn, gender);

                if (Role == "M")
                {
                    if (result == 0)
                    {

                        MessageBox.Show("Manager is not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Manager is added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    int id = obj.getstaffid(username);
                    int staffadd = obj.AddStaff(jobtitle, id);
                    if (staffadd == 0)
                    {
                        MessageBox.Show("Staff is not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Staff is added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }



            }
        }

    }
}
