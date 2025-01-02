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
    public partial class CustomerInterface : Form
    {
        Controller controllerobj;

        string username;
        public CustomerInterface(string username)
        {
            InitializeComponent();
            BookingGridView.CellContentClick += yourDataGridView_CellContentClick;
            this.username = username;
            BookingGridView.Visible = false;
            controllerobj = new Controller(); 
            DataTable dt = controllerobj.getDeparture();
            DataRow emptyRow = dt.NewRow();
            emptyRow["Departure"] = "None";
            dt.Rows.InsertAt(emptyRow, 0); 
            DepatureComboBox.DataSource = dt;
            DepatureComboBox.DisplayMember = "Departure";
            DepatureComboBox.ValueMember = "Departure";
            DepatureComboBox.SelectedIndex = 0;
            DataTable dtDest = controllerobj.getDestination();
            DataRow emptyRow2 = dtDest.NewRow();
            emptyRow2["Destination"] = "None";
            dtDest.Rows.InsertAt(emptyRow2, 0);
            ArrivalComboBox.DataSource = dtDest;
            ArrivalComboBox.DisplayMember = "Destination";
            ArrivalComboBox.ValueMember = "Destination";
            ArrivalComboBox.SelectedIndex = 0;
            BookingGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            


            DataGridViewButtonColumn bookButtonColumn = new DataGridViewButtonColumn
            {
                Name = "BookButton",
                HeaderText = "",
                Text = "Book", 
                UseColumnTextForButtonValue = true 
            };

            
            BookingGridView.Columns.Insert(0, bookButtonColumn);


        }
        private void yourDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == BookingGridView.Columns["BookButton"].Index && e.RowIndex >= 0)
            {
                
                string cruiseID = BookingGridView.Rows[e.RowIndex].Cells["Cruise Number"].Value.ToString();

                
                string shipID = BookingGridView.Rows[e.RowIndex].Cells["Ship ID"].Value.ToString();

                string shipName = BookingGridView.Rows[e.RowIndex].Cells["Ship Name"].Value.ToString();

                string cruiseName = BookingGridView.Rows[e.RowIndex].Cells["Cruise Name"].Value.ToString();
                
                DateTime endDate = Convert.ToDateTime(BookingGridView.Rows[e.RowIndex].Cells["Till"].Value);
                DateTime startDate = Convert.ToDateTime(BookingGridView.Rows[e.RowIndex].Cells["From"].Value);

                
                string endDateOnly = endDate.ToShortDateString();
                string startDateOnly = startDate.ToShortDateString(); 


                string departure = BookingGridView.Rows[e.RowIndex].Cells["Departure"].Value.ToString();

                string destination = BookingGridView.Rows[e.RowIndex].Cells["Destination"].Value.ToString();

                BookingForm bookingForm = new BookingForm(username, Convert.ToInt32(cruiseID), Convert.ToInt32(shipID),shipName,cruiseName,endDateOnly,startDateOnly,departure,destination);
                bookingForm.Show();
            }
        }

        private void ViewUserInfoButton_Click(object sender, EventArgs e)
        {

            this.Close();
            ViewCustomerInfo page = new ViewCustomerInfo(username);
            page.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

            this.Close();


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int Price;
            int.TryParse(MaxPriceTextBox.Text,out Price);
            dt = controllerobj.SearchCruises(DepatureComboBox.SelectedValue.ToString(),ArrivalComboBox.SelectedValue.ToString(),Price.ToString());
            BookingGridView.DataSource = dt;
            if (BookingGridView.Columns["Ship ID"] != null)
            {
                BookingGridView.Columns["Ship ID"].Visible = false;
            }
            BookingGridView.Visible = true;

        }

        private void ViewBookedCruises_Click(object sender, EventArgs e)
        {
            ViewBookedCruises page = new ViewBookedCruises(username);
            page.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Activities activities = new Activities(username);
            activities.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            //Welcome page = new Welcome();
           // page.Show();
        }

        private void userinfo_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewCustomerInfo page = new ViewCustomerInfo(username);
            page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            ViewPayments page = new ViewPayments(username);
            page.Show();
        }
    }
}
