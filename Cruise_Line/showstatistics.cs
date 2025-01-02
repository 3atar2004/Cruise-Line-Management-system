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
    public partial class showstatistics : UserControl
    {
        public showstatistics()
        {
            InitializeComponent();
            Controller obj = new Controller();
            string dateFormatted = DateTime.Today.ToString("yyyy-MM-dd");
            ongoinglabel.Text = obj.getongoingcruisecount(dateFormatted).ToString();
            totalbooklabel.Text = obj.gettotalbooking().ToString();
            totalactlabel.Text = obj.gettotalactivity().ToString();
            decimal totalbook = obj.gettotalbooking();
            decimal totalact = obj.gettotalactivity();
            decimal totalsaless = totalbook + totalact;
            totalsales.Text = totalsaless.ToString();
            totalrecievedlabel.Text = obj.gettotalrecieved().ToString();
            decimal totalrecieved = obj.gettotalrecieved();
            decimal totalunreceived = totalsaless - totalrecieved;
            totalunrecievedlabel.Text = totalunreceived.ToString();
            int bookingcount = obj.getbookingcount();
            decimal average = Math.Round(totalsaless / bookingcount,2);
            averagespentlabel.Text = average.ToString();
            int customercount = obj.getcustomercount();
            int staffcount = obj.getstaffcount();
            decimal scratio = (decimal) staffcount / customercount;
            scratio = Math.Round(scratio, 2);
            ratiolabel.Text=scratio.ToString();

            string MaxCruise = obj.getMaxCruise();
            string MinCruise = obj.getMinCruise();
            maxcruiselabel.Text = MaxCruise;
            mincruiselabel.Text = MinCruise;


        }

        private void showstatistics_Load(object sender, EventArgs e)
        {

        }
    }
}
