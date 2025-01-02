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
    public partial class Login : Form
    {
        Controller controllerobj;
        public Login()
        {
            InitializeComponent();
            controllerobj = new Controller();
        }
        private void Login1_Click(object sender, EventArgs e)
        {
            
            DataTable checkIfUserExists = controllerobj.Selectpassword(username.Text);

            if (checkIfUserExists == null || checkIfUserExists.Rows.Count == 0)
            {
                MessageBox.Show("Username doesn't exist. Please sign up first.");
            }
            else
            {
                
                string storedHashedPassword = checkIfUserExists.Rows[0]["Password"].ToString();

                
                string enteredHashedPassword = controllerobj.HashPassword(password.Text);

                char Role = controllerobj.getRole(username.Text);

                if (storedHashedPassword == enteredHashedPassword && Role == 'C')
                {

                    CustomerInterface customer = new CustomerInterface(username.Text);
                    this.Close();
                    customer.Show();
                }
                else if (storedHashedPassword == enteredHashedPassword && Role == 'S') {

                    StaffInterface page = new StaffInterface(username.Text);
                    this.Close();
                    page.Show();
                }
                else if (storedHashedPassword == enteredHashedPassword && Role == 'M')
                {

                    ManagerInterface page = new ManagerInterface(username.Text);
                    this.Close();
                    page.Show();
                }
                else
                { 
                    MessageBox.Show("Incorrect Password");
                }
            }
        }


        private void redirectToSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUp page = new SignUp();
            page.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
