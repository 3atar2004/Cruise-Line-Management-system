using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruise_Line
{
    public partial class Activities : Form
    {
        Controller controllerobj;
        string username;

        public Activities(string username)
        {
            InitializeComponent();
            this.username = username;
            controllerobj = new Controller();
            DataTable dt1 = controllerobj.getpersonIdfromUsername(username);
            int personID = Convert.ToInt32(dt1.Rows[0][0]);
            DataTable dt3 = controllerobj.GetCrusieidbyPersonid(personID);
            int cruiseid = Convert.ToInt32(dt3.Rows[0][0]);
            dataGridView1.DataSource = controllerobj.searchActivities(cruiseid);
            ActivitynameCombobox.DataSource = controllerobj.searchActivities(cruiseid);
            ActivitynameCombobox.DisplayMember = "Name";
            ActivitynameCombobox.ValueMember = "ActivityID";
            Reservedactivitylabel.Visible = false;
            dataGridView2.Visible = false;
            ActivitynameCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Activities_Load(object sender, EventArgs e)
        {

        }

        private void bookActivitybutton_Click(object sender, EventArgs e)
        {
            int participators = 0;
            DataTable dt1 = controllerobj.getpersonIdfromUsername(username);
            DataTable dt2 = controllerobj.getActivityCapacity(Int16.Parse(ActivitynameCombobox.SelectedValue.ToString()));


            int personID = Convert.ToInt32(dt1.Rows[0][0]);
            int activtyCapacity = Convert.ToInt16(dt2.Rows[0][0]);


            int activityID = Convert.ToInt32(ActivitynameCombobox.SelectedValue.ToString());
            int paymentAmount = controllerobj.getCost(activityID);
            int paymentID = controllerobj.makePayment(paymentAmount);


            //MessageBox.Show(cruiseid.ToString());

            //MessageBox.Show(paymentID.ToString());
            if (numofParticicpationstextbox.Text == "")
            {
                MessageBox.Show("Please Enter the number of participations ");
            }
            else if (!int.TryParse(numofParticicpationstextbox.Text, out participators) || Int16.Parse(numofParticicpationstextbox.Text) <= 0)
            {

                MessageBox.Show("Please enter a valid number of participations");
                return;
            }

            else
            {
                int Activitycount = controllerobj.GetActivityCount(Int16.Parse(ActivitynameCombobox.SelectedValue.ToString())) + Int16.Parse(numofParticicpationstextbox.Text);
                //MessageBox.Show(Activitycount.ToString());

                if (Activitycount > activtyCapacity)
                {
                    MessageBox.Show("Activity Capacity limit exceeded");
                }
                else
                {
                    int result = controllerobj.BookActivity(Int16.Parse(numofParticicpationstextbox.Text), personID, Int16.Parse(ActivitynameCombobox.SelectedValue.ToString()), paymentID);
                    if (result == 0)
                    {
                        int result2 = controllerobj.UpdateActivityBooking(Int16.Parse(numofParticicpationstextbox.Text), personID, Int16.Parse(ActivitynameCombobox.SelectedValue.ToString()), paymentID);
                        MessageBox.Show("Activity Booking Updated Successsfully");
                        dataGridView2.DataSource = controllerobj.GetReservedActivityinfo(personID);
                        Reservedactivitylabel.Visible = true;
                        dataGridView2.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Activity booked successfully");
                        dataGridView2.DataSource = controllerobj.GetReservedActivityinfo(personID);
                        Reservedactivitylabel.Visible = true;
                        dataGridView2.Visible = true;
                    }
                }

            }
            //MessageBox.Show(personID.ToString());

        }







    }
}
