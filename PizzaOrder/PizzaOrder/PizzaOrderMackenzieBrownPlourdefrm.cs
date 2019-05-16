using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Mackenzie Brown Plourde
 * Created on: 22 3 2019
 * Created for: ICS3U Programming
 * Assignment #5b - PizzaOrder
 * This program calculatess the cost for a pizza
*/

namespace PizzaOrder
{
    
    public partial class PizzaOrderMackenzieBrownPlourdefrm : Form
    {
        
        public PizzaOrderMackenzieBrownPlourdefrm()
        {
            InitializeComponent();
            //Hides label
            lblAmount.Hide();
            //Sets maximum for numUpDown
            numSize.Maximum = 2;
            numTopings.Maximum = 4;
            
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            //Declars variables
            double Total = 0;
            double Total2 = 0;
            double Total3 = 0;
            
            





            //Calculates how much to charde for the pizza size
            if (numSize.Value == 1)
            {
                Total = + 9.99;

            }
            else if (numSize.Value == 2)
            {
                Total = + 12.99;
            }


            //Calculates how much to charge for the number of topings
            if (numTopings.Value == 1)
            {
                Total2 = + .75;
            }
            else if (numTopings.Value == 2)
            {
                Total2 = + 1.35;
            }
            else if (numTopings.Value == 3)
            {
                Total2 = + 2.15;
            }
            else if (numTopings.Value == 4)
            {
                Total2 = + 2.75;
            }


            Total3 = Total + Total2;

            //Adds HST tax
            Total3 *= 1.13;
            //Rounds to 2 decimal places
            Total3 = Math.Round(Total3, 2, MidpointRounding.ToEven);
            lblAmount.Text = "$" + (Total3) + " is your total";
            lblAmount.Show();
            

        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PizzaOrderMackenzieBrownPlourdefrm_Load(object sender, EventArgs e)
        {

        }
    }
}
