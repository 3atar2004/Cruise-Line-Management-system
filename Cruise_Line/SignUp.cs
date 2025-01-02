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

    public partial class SignUp : Form
    {
        Controller controllerobj;
        public SignUp()
        {
            InitializeComponent();
            controllerobj = new Controller();
            Gender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void signup1_Click(object sender, EventArgs e)////lesa mehtag a validate en kol el boxes filled abl ma n sign up
        {
            if(Username.Text.ToString() == "")
            {
                MessageBox.Show("Please Enter a Username");
                return;
            }
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(Email.Text, emailPattern))
            {
                MessageBox.Show("Email not in correct format");
                return;
            }
            if (Email.Text == "" ||
                Phone.Text == "" || 
                Fname.Text == "" || 
                Lname.Text =="" ||
                Gender.Text ==""||
                Country.Text ==""||
                SSN.Text ==""||
                City.Text == ""||
                Address.Text == "")
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }
            int checkusername = controllerobj.CountUsername(Username.Text);
            int checkemail = controllerobj.CountEmail(Email.Text);
            if (checkusername > 0)
            {
                MessageBox.Show("Username already exists,Try a different one");
                return;
            }
            else if (checkemail > 0)
             {
                MessageBox.Show("Email already used,Try a different one");
                return;
            }
            else
            {
                if (Password.Text == "")
                {
                    MessageBox.Show("Password Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (reenterpassbox.Text == "")
                {
                    MessageBox.Show("Please Re-enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Password.Text != reenterpassbox.Text)
                {
                    MessageBox.Show("passwords doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string phonenumber = Phone.Text;
                int ssn = 0;
                if (!phonenumber.All(char.IsDigit))
                {
                    MessageBox.Show("Phone number must only contain numbers");
                    return;
                }


                else if (!int.TryParse(SSN.Text, out ssn))
                { 

                    MessageBox.Show("Please enter a valid SSN");
                    return;
                }
                else
                {
                    int result = controllerobj.AddPerson(Username.Text, Email.Text, Address.Text, phonenumber, Password.Text, Fname.Text, Lname.Text, "C", City.Text, Country.Text, Int32.Parse(SSN.Text), Gender.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to insert new person");
                        return;
                    }

                    else
                    {
                        MessageBox.Show("Person Inserted Successfully\nYou will be redirected to login screen");
                        this.Close();
                        Login page = new Login();
                        page.Show();

                    }
                }

            }
            


        }


        private void redirectToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Login page = new Login();
            page.Show();
        }
    }
}
