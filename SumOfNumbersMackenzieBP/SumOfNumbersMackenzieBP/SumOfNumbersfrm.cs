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
 * Created by: Mackenzee Brown Plourde
 * Created on: 25 03 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 sum of numbers
 * This program calculates the sum of a factorial
*/

namespace SumOfNumbersMackenzieBP
{
    public partial class SumOfNumbersfrm : Form
    {
        public SumOfNumbersfrm()
        {
            InitializeComponent();
            lblAnswer1.Hide();
            lblAnswer2.Hide();
            Double Number1;
            Double Number2;
        }

        private void lblAnswer1_Click(object sender, EventArgs e)
        {

        }

        private void lblAnswer2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
