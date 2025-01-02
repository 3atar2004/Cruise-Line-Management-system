using DBapplication;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cruise_Line
{
    public partial class ViewPayments : Form
    {
        Controller controllerobj = new Controller();
        string _username;

        public ViewPayments(string username)
        {
            InitializeComponent();
            this._username = username;
            TypeCombo.Items.AddRange(new string[] { "Activities", "Bookings" });
            PaymentStatusCombo.Items.AddRange(new string[] { "Paid", "Unpaid" });

            // Assign event handlers
            TypeCombo.SelectedIndexChanged += Combo_SelectedIndexChanged;
            PaymentStatusCombo.SelectedIndexChanged += Combo_SelectedIndexChanged;

            // Assign CellClick event handler
            dataGridView1.CellClick += DataGridView1_CellClick;
            label3.Visible = false;
        }

        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            // Ensure both combo boxes have a selection
            if (TypeCombo.SelectedItem == null || PaymentStatusCombo.SelectedItem == null)
                return;

            string type = TypeCombo.SelectedItem.ToString();
            string paymentStatus = PaymentStatusCombo.SelectedItem.ToString();

            DataTable dt = null;
            if (type == "Activities" && paymentStatus == "Paid")
            {
                dt = controllerobj.getPaidActivities(_username);
            }
            else if (type == "Bookings" && paymentStatus == "Paid")
            {
                dt = controllerobj.getPaidCruise(_username);
            }
            else if (type == "Bookings" && paymentStatus == "Unpaid")
            {
                dt = controllerobj.getUnpaidCruise(_username);
            }
            else if (type == "Activities" && paymentStatus == "Unpaid")
            {
                dt = controllerobj.getUnpaidActivites(_username);
            }

            if (dt != null)
            {
                dataGridView1.DataSource = dt;

                if ((type == "Bookings" && paymentStatus == "Unpaid") || (type == "Activities" && paymentStatus == "Unpaid"))
                {
                    if (!dataGridView1.Columns.Contains("PayButton"))
                    {
                        DataGridViewButtonColumn payButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "PayButton",
                            HeaderText = "Action",
                            Text = "Pay",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridView1.Columns.Insert(0, payButtonColumn);
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Cells["PayButton"].Style.ForeColor = Color.Red;
                    }
                }
                else
                {
                    // Remove the Pay button column if it exists and is not needed
                    if (dataGridView1.Columns.Contains("PayButton"))
                    {
                        dataGridView1.Columns.Remove("PayButton");
                    }
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                label3.Visible = true;

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["PayButton"].Index && e.RowIndex >= 0)
            {
                DialogResult validate = MessageBox.Show(
                    "Are you sure you want to proceed?",
                    "Confirm Action",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (validate == DialogResult.Yes)
                {
                    if (TypeCombo.SelectedItem.ToString() == "Bookings" && PaymentStatusCombo.SelectedItem.ToString() == "Unpaid")
                    {
                        int BookingID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BookingID"].Value);
                        int totalprice = controllerobj.getBookingTotal(BookingID);
                        string Loyalty = controllerobj.getLoyalty(_username);
                        int loyalty = Convert.ToInt32(Loyalty);
                        //if (loyalty >= 1000)
                        //{
                            int discount = 0;

                            if (loyalty >= 2000)
                            {
                                discount = 30;
                            }
                            else if (loyalty >= 1500)
                            {
                                discount = 25;
                            }
                            else if (loyalty >= 1000)
                            {
                                discount = 20;
                            }

                            int newPrice = totalprice - (totalprice * discount / 100);
                            int payment_id = controllerobj.makePayment(newPrice);
                            int UpdateComplete = controllerobj.UpdateCruiseBooking(BookingID, payment_id);
                            int gainedLoyalty_Points = CalculateLoyaltyPointsForGoal(totalprice);
                            int userID = controllerobj.GetUserIdByUsername(_username);
                            int result = controllerobj.UpdateLoyaltyPoints(userID, gainedLoyalty_Points);
                            MessageBox.Show("Payment Successful\n Loyalty points gained " + gainedLoyalty_Points + "");
                    }
                    else if (TypeCombo.SelectedItem.ToString() == "Activities" && PaymentStatusCombo.SelectedItem.ToString() == "Unpaid")
                    {
                            int ActivityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ActivityID"].Value);
                            int totalprice2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Total Cost"].Value);
                            int payment_id = controllerobj.makePayment(totalprice2);
                            int userID = controllerobj.GetUserIdByUsername(_username);
                            int UpdateComplete = controllerobj.UpdateActivityPayment(payment_id, userID, ActivityID);
                            MessageBox.Show("Payment Successful!");
                    }
                    
                }
            }
        }
        public int CalculateLoyaltyPointsForGoal(int totalPrice)
        {

            double pointsPerDollar = 1500.0 / (5 * 500);
            return (int)(totalPrice * pointsPerDollar);
        }

        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}