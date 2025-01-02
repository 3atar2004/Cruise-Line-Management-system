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
    public partial class AddShip : UserControl
    {
        Controller obj;
        public AddShip()
        {
            InitializeComponent();
            obj = new Controller();
        }

        private void addShipButton_Click(object sender, EventArgs e)
        {
            if (shipNameTextbox.Text == "")
            {
                MessageBox.Show("Ship Name Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int checkshipName = obj.CountShipName(shipNameTextbox.Text);
            if (checkshipName > 0)
            {
                MessageBox.Show("ship already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Singlenumeric.Value == 0 && Doublenumeric.Value == 0 && Triplenumeric.Value == 0)
            {
                MessageBox.Show("Ship cannot be empty with no cabins", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (singleTextbox.Text == "" && Singlenumeric.Value != 0)
            {
                MessageBox.Show("Can't add single cabins without a price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (doubleTextbox.Text == "" && Doublenumeric.Value != 0)
            {
                MessageBox.Show("Can't add double cabins without a price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tripleTextbox.Text == "" && Triplenumeric.Value != 0)
            {
                MessageBox.Show("Can't add triple cabins without a price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int singlePrice = 0;
            if (singleTextbox.Text!= "" && !int.TryParse(singleTextbox.Text, out singlePrice))
            {
                MessageBox.Show("Please enter a valid price for single cabins", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int doublePrice = 0;
            if (doubleTextbox.Text != "" && !int.TryParse(doubleTextbox.Text, out doublePrice))
            {
                MessageBox.Show("Please enter a valid price for double cabins", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int triplePrice = 0;
            if (tripleTextbox.Text != "" && !int.TryParse(tripleTextbox.Text, out triplePrice))
            {
                MessageBox.Show("Please enter a valid price for triple cabins", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ne add el ship
            int shipID = obj.addShip(shipNameTextbox.Text);
            if (shipID <= 0)
            {
                MessageBox.Show("Ship was not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // add cabins
                int result = obj.addCabins(shipID, (int)Singlenumeric.Value, singlePrice, (int)Doublenumeric.Value, doublePrice, (int)Triplenumeric.Value, triplePrice);
                if (result == 0)
                {
                    MessageBox.Show("Cabins on ship were not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Ship is Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    shipNameTextbox.Clear();
                    singleTextbox.Clear();
                    doubleTextbox.Clear();
                    tripleTextbox.Clear();
                    Singlenumeric.Value = 0;
                    Doublenumeric.Value = 0;
                    Triplenumeric.Value = 0;
                    return;
                }
            }
        }
        
    }
    
}
