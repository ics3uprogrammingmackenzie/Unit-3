using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandoNumbersMacBP
{
    public partial class frmRandomNumbers : Form
    {
        public frmRandomNumbers()
        {
            InitializeComponent();
            lblWin.Hide();
            lblLoss.Hide();
        }

        private void frmRandomNumbers_Load(object sender, EventArgs e)
        {

        }

        private void btnCheak_Click(object sender, EventArgs e)
        {
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
                int aRandomNumber;
            Random randomNumberGenerator = new Random();
            
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            if (txtInput.Text == Convert.ToString(aRandomNumber))  
            {
                lblWin.Show();
                lblLoss.Hide();
            }

            else 
                {
                lblLoss.Show();
                lblWin.Hide();
                }
           

            
        }
    }
}

