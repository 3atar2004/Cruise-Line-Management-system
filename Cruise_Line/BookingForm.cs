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
    public partial class BookingForm : Form
    {
        string username, shipName, cruiseName, endDate, startDate, departure, destination;
        int totalprice,SelectedPrice =0; //total price da el payment amt

        public int CalculateLoyaltyPointsForGoal(int totalPrice)
        {

            double pointsPerDollar = 1500.0 / (5 * 500); // Adjust if the average price changes
            return (int)(totalPrice * pointsPerDollar);
        }
        private void GoToCheckout_Click(object sender, EventArgs e)
        {
            GoToCheckout.Enabled = false;
            GoToCheckout.Visible = false;
            TermsLabel.Visible = true;
            PayButton.Visible = true;
            CancelButton.Visible = true;
            PayLater.Visible = false;

            string Loyalty = controllerobj.getLoyalty(username);
            int loyalty = Convert.ToInt32(Loyalty);
            if (loyalty >= 1000) {
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
                InvoiceLabel.Font = new Font(InvoiceLabel.Font,FontStyle.Strikeout);
                NewDiscountedPrice.Visible = true;
                NewDiscountedPrice.Font = new Font(NewDiscountedPrice.Font,FontStyle.Bold);
                NewDiscountedPrice.Text = "Your Loyalty Points Are "+Loyalty+"\nYou Received a "+discount+"\nNew Total is"+newPrice+"";
            }

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (totalprice == 0)
            {
                MessageBox.Show("Please Book Cabins First");
                return;
            }

            int payment_id = controllerobj.makePayment(totalprice);
            if (payment_id == 0)
            {
                MessageBox.Show("Payment Failure");
                return;
            }

            DialogResult validate = MessageBox.Show(
                "Are you sure you want to proceed?",
                "Confirm Action",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

           
            if (validate == DialogResult.No)
            { 
                return;
            }
            int user_id = controllerobj.GetUserIdByUsername(username);

            int booking_id = controllerobj.makeBooking(user_id, payment_id, cruiseID);
            if (booking_id == 0)
            {
                MessageBox.Show("Booking Failure");
                return;
            }

            foreach (DataGridViewRow row in TobeBookedDataGrid.Rows)
            {
                if (row.Cells["Cabin"].Value != null &&
                    row.Cells["NumberOfCabins"].Value != null)
                {
                    string cabinType = row.Cells["Cabin"].Value.ToString();
                    int numberOfCabins = Convert.ToInt32(row.Cells["NumberOfCabins"].Value);
                    int cabinTypeint = GetCabinType(cabinType);
                    for(int i = 0; i<numberOfCabins;i++) { 
                    int CabinID = controllerobj.getCabinID(cruiseID,cabinTypeint);
                        int AssignmentSucess = controllerobj.AssignCabin(CabinID, shipID, booking_id);
}
                }
            }



            int gainedLoyalty_Points = CalculateLoyaltyPointsForGoal(totalprice);
            int result = controllerobj.UpdateLoyaltyPoints(user_id,gainedLoyalty_Points);

            if (result > 0)
            {
                Console.WriteLine("Loyalty points updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update loyalty points. User not found.");
            }

            this.Close();
            MessageBox.Show("Welcome aboard, Mr./ Mrs. " + username + "\nYour booking and payment have been successfully finalized.\nYou gained "+gainedLoyalty_Points+" loyalty points\nYou will be redirected to another window to view your booking and cabin details.\nThank you for choosing us!");
            ViewBookedCruises page = new ViewBookedCruises(username);
            page.Show();

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelButton.Visible = false;
            PayButton.Visible = false;
            TermsLabel.Visible = false;
            GoToCheckout.Visible = true;
            GoToCheckout.Enabled = true;
            PayLater.Visible = true;
        }

        private void CabinChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCabin = CabinChoiceComboBox.SelectedItem.ToString();
            int identifier = 0;

            if (selectedCabin == "Single")
            {
                identifier = 1;
            }
            else if (selectedCabin == "Double")
            {
                identifier = 2;
            }
            else if (selectedCabin == "Triple")
            {
                identifier = 3;
            }
            SelectedPrice = controllerobj.getPricePerNight(shipID,identifier);
            PricePerNightLabel.Text = "Price Per Night "+SelectedPrice+"";

            
            
        }

        private void PayLater_Click(object sender, EventArgs e)
        {
            if (totalprice == 0)
            {
                MessageBox.Show("Please Book Cabins First");
                return;
            }

            DialogResult result = MessageBox.Show(
            "Are you sure you want to proceed?",
            "Confirm Action",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );


            if (result == DialogResult.No)
            {

                return;
            }


            int user_id = controllerobj.GetUserIdByUsername(username);
            
            int booking_id = controllerobj.makeBooking(user_id,null, cruiseID);
            if (booking_id == 0)
            {
                MessageBox.Show("Booking Failure");
                return;
            }

            foreach (DataGridViewRow row in TobeBookedDataGrid.Rows)
            {
                if (row.Cells["Cabin"].Value != null &&
                    row.Cells["NumberOfCabins"].Value != null)
                {
                    string cabinType = row.Cells["Cabin"].Value.ToString();
                    int numberOfCabins = Convert.ToInt32(row.Cells["NumberOfCabins"].Value);
                    int cabinTypeint = GetCabinType(cabinType);
                    for (int i = 0; i < numberOfCabins; i++)
                    {
                        int CabinID = controllerobj.getCabinID(cruiseID, cabinTypeint);
                        int AssignmentSucess = controllerobj.AssignCabin(CabinID, shipID, booking_id);
                    }
                }
            }
            this.Close();
            MessageBox.Show("Welcome aboard, Mr./ Mrs. " + username + "\nYour booking has been successfully finalized. You will be redirected to another window to view your booking and cabin details.\nPayment can be made at your convenience. Thank you for choosing us!");
            ViewBookedCruises page = new ViewBookedCruises(username);
            page.Show();
        }

        int shipID, cruiseID;
        Controller controllerobj = new Controller();

        public BookingForm(string username, int cruiseID, int shipID,string shipname ,string cruisename,string enddate,string startDate,string Departure,string Destination)
        {
            InitializeComponent();
            this.username = username;
            this.shipID = shipID;
            this.cruiseID = cruiseID;
            this.shipName = shipName;
            this.cruiseName = cruiseName;
            this.endDate = endDate;
            this.startDate = startDate;
            this.departure = departure;
            this.destination = destination;

            
            CabinChoiceComboBox.Items.AddRange(new string[] { "Single", "Double", "Triple" });
            CabinChoiceComboBox.SelectedIndex = 0;
            NumberError.Visible = false;
            SelectionError.Visible = false;

            
            TobeBookedDataGrid.Columns.Add("Cabin", "Cabin");
            TobeBookedDataGrid.Columns.Add("NumberOfCabins", "Number of Cabins");

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "DeleteButton";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            TobeBookedDataGrid.Columns.Add(deleteButton);

            InfoLabel.Text = "Selected Cruise:"+cruisename+"\n\nOn Board:"+shipname+"\n\nFrom:"+startDate+" Till:"+enddate+"\n\nDeparting From:"+Departure+" To "+Destination+"";


            InvoiceLabel.Visible = false;

            TermsLabel.Visible = true;
            TermsLabel.Text = "By pressing \"Pay,\" you acknowledge and agree to our Terms and Conditions, including the understanding that\npayments are non-refundable within 30 days of the cruise departure date.";

            TermsLabel.Visible = false;
            PayButton.Visible = false;
            CancelButton.Visible = false;
            NewDiscountedPrice.Visible = false;
        }

        private void TobeBookedDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TobeBookedDataGrid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {

                int cabinsToRemove = Convert.ToInt32(TobeBookedDataGrid.Rows[e.RowIndex].Cells["NumberOfCabins"].Value);
                string selectedCabin = TobeBookedDataGrid.Rows[e.RowIndex].Cells["Cabin"].Value.ToString();
                int identifier = 0;

                if (selectedCabin == "Single")
                {
                    identifier = 1;
                }
                else if (selectedCabin == "Double")
                {
                    identifier = 2;
                }
                else if (selectedCabin == "Triple")
                {
                    identifier = 3;
                }


                int pricepernight = controllerobj.getPricePerNight(shipID,identifier);
                int priceToSubtract = pricepernight * cabinsToRemove;




                TobeBookedDataGrid.Rows.RemoveAt(e.RowIndex);


                totalprice -= priceToSubtract;
                InvoiceLabel.Text = "Invoice:\nTotal Bill: " + totalprice;
            }
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private int GetCabinType(string cabinType)
        {

            if (cabinType == "Single")
                return 1; 
            if (cabinType == "Double")
                return 2; 
            if (cabinType == "Triple")
                return 3; 
            return 0;
        }

        private void AddCabinsButton_Click(object sender, EventArgs e)
        {
            if (CabinChoiceComboBox.SelectedItem == null)
            {
                SelectionError.Visible = true;
                return;
            }

            if (Convert.ToInt32(NumberOfCabins.Value) == 0)
            {
                NumberError.Visible = true;
                return;
            }

            string selectedCabin = CabinChoiceComboBox.SelectedItem.ToString();
            int numberOfCabins = Convert.ToInt32(NumberOfCabins.Value);
            int identifier = 0;

            // Correctly set identifier based on selected cabin type
            if (selectedCabin == "Single")
            {
                identifier = 1;
            }
            else if (selectedCabin == "Double")
            {
                identifier = 2;
            }
            else if (selectedCabin == "Triple")
            {
                identifier = 3;
            }

            // Ensure the correct price per night is assigned
            SelectedPrice = controllerobj.getPricePerNight(shipID, identifier);

            // Retrieve available cabins
            int available_cabins = controllerobj.getNumberAvailableCabins(cruiseID, identifier);

            // Calculate booked cabins from DataGridView
            int bookedCabins = 0;
            foreach (DataGridViewRow row in TobeBookedDataGrid.Rows)
            {
                if (row.Cells["Cabin"].Value != null && row.Cells["Cabin"].Value.ToString() == selectedCabin && row.Cells["NumberOfCabins"].Value != null)
                {
                    bookedCabins += Convert.ToInt32(row.Cells["NumberOfCabins"].Value);
                }
            }

            // Check if the total number of cabins exceeds available cabins
            if (bookedCabins + numberOfCabins > available_cabins)
            {
                MessageBox.Show($"Number of bookings exceeded the available cabins.\nNumber of available cabins: {available_cabins - bookedCabins}");
                return;
            }

            // Update the DataGridView with the new cabin count
            bool cabinExists = false;
            foreach (DataGridViewRow row in TobeBookedDataGrid.Rows)
            {
                if (row.Cells["Cabin"].Value != null && row.Cells["NumberOfCabins"].Value != null && row.Cells["Cabin"].Value.ToString() == selectedCabin)
                {
                    int currentCabins = Convert.ToInt32(row.Cells["NumberOfCabins"].Value);
                    row.Cells["NumberOfCabins"].Value = currentCabins + numberOfCabins;
                    cabinExists = true;
                    break;
                }
            }

            if (!cabinExists)
            {
                TobeBookedDataGrid.Rows.Add(selectedCabin, numberOfCabins);
            }

            
            CabinChoiceComboBox.SelectedIndex = 0;
            NumberOfCabins.Value = 0;

            int price = controllerobj.getPricePerNight(shipID,identifier);

            totalprice +=  price * numberOfCabins;

            InvoiceLabel.Text = "Invoice:\nTotal Bill: " + totalprice;
            InvoiceLabel.Visible = true;
        }

    }
}
