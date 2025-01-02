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
    public partial class info : UserControl
    {
        Controller obj;
        public info(string username)
        {
            InitializeComponent();
            obj = new Controller();
            updatebtn.Visible = false;
            reenterlabel.Visible = false;
            reenterpassbox.Visible = false;
            passwordbox.Visible = false;
            passlabel.Visible = false;
            DataTable info = obj.getPerson(username);
            fnamebox.ReadOnly = true;
            Lnamebox.ReadOnly = true;
            emailbox.ReadOnly = true;
            ssnbox.ReadOnly = true;
            phonebox.ReadOnly = true;
            addressbox.ReadOnly = true;
            citybox.ReadOnly = true;
            countrybox.ReadOnly = true;
            usernamebox.ReadOnly = true;
            gendercombobox.Enabled = false;
            fnamebox.Text = info.Rows[0]["Fname"].ToString();
            Lnamebox.Text = info.Rows[0]["Lname"].ToString();
            emailbox.Text = info.Rows[0]["Email"].ToString();
            ssnbox.Text = info.Rows[0]["Ssn"].ToString();
            phonebox.Text = info.Rows[0]["Phone"].ToString();
            addressbox.Text = info.Rows[0]["Address"].ToString();
            citybox.Text = info.Rows[0]["City"].ToString();
            countrybox.Text = info.Rows[0]["Country"].ToString();
            usernamebox.Text = info.Rows[0]["Username"].ToString();
            gendercombobox.SelectedItem = info.Rows[0]["Gender"].ToString();

        }

        private void info_Load(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            updatebtn.Visible = true;
            changepasswordbtn.Visible = false;
            passwordbox.Visible = false;
            reenterpassbox.Visible = false;
            reenterlabel.Visible = false;
            passlabel.Visible = false;
            fnamebox.ReadOnly = false;
            Lnamebox.ReadOnly = false;
            ssnbox.ReadOnly = false;
            phonebox.ReadOnly = false;
            addressbox.ReadOnly = false;
            citybox.ReadOnly = false;
            countrybox.ReadOnly = false;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (fnamebox.Text == "")
            {
                MessageBox.Show("First Name Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Lnamebox.Text == "")
            {
                MessageBox.Show("Last Name Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ssnbox.Text == "")
            {
                MessageBox.Show("SSN Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (phonebox.Text == "")
            {
                MessageBox.Show("Phone Number Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (addressbox.Text == "")
            {
                MessageBox.Show("address Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (citybox.Text == "")
            {
                MessageBox.Show("City  Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (countrybox.Text == "")
            {
                MessageBox.Show("Country Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int ssn = 0;
                if (!int.TryParse(ssnbox.Text, out ssn))
                {
                    MessageBox.Show("Please enter a valid ssn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (passwordbox.Text != reenterpassbox.Text)
                {
                    MessageBox.Show("passwords doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string fname = fnamebox.Text;
                string lname = Lnamebox.Text;
                string address = addressbox.Text;
                string city = citybox.Text;
                string country = countrybox.Text;
                string phone = phonebox.Text;
                int result = obj.updateperson(usernamebox.Text, fname, lname, ssn, address, city, country, phone);
                
                if (result == 0)
                {
                    MessageBox.Show("Info is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Info is  updated", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updatebtn.Visible = false;
                    changepasswordbtn.Visible = true;
                    return;
                }

            }
        }

        private void changepasswordbtn_Click(object sender, EventArgs e)
        {
            if (passwordbox.Visible == false)
            {
                passlabel.Visible = true;
                passwordbox.Visible = true;
                reenterlabel.Visible = true;
                reenterpassbox.Visible = true;
            }
            else
            {

                if (passwordbox.Text == "")
                {
                    MessageBox.Show("Password Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (reenterpassbox.Text == "")
                {
                    MessageBox.Show("Please Re-enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (passwordbox.Text != reenterpassbox.Text)
                    {
                        MessageBox.Show("passwords doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int result = obj.ChangePassword(usernamebox.Text, passwordbox.Text);
                        if (result == 0)
                        {
                            MessageBox.Show("passwords is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("passwords is updated successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reenterlabel.Visible = false;
                            reenterpassbox.Visible = false;
                            passwordbox.Visible = false;
                            passlabel.Visible = false;
                            return;
                        }
                    }
                    
                }

            }
        }

      
    }
}
