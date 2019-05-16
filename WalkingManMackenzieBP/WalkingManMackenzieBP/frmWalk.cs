using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WalkingManMackenzieBP
{
    public partial class frmWalk : Form
    {
        public frmWalk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            while (pictureFrameCounter < MAX_FRAMES + 1)
            if (pictureFrameCounter == 1)
                    this.picWalk.Image = Properties.Resources.walk1;
            else if (pictureFrameCounter)
        }

        private void picWalk_Click(object sender, EventArgs e)
        {

        }
    }
}
