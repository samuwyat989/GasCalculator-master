using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace GasCalculator
{
    public partial class storeInterface : Form
    {
        const double GAS_PRIEMIUM = 0.95;
        const double GAS_REGULAR = 0.75;
        const double GAS_MID = 0.85;

        public storeInterface()
        {
            InitializeComponent();
        }

        private void costButton_Click(object sender, EventArgs e)
        {
            Graphics gas = this.CreateGraphics();
            gas.DrawImage(Properties.Resources.fuel_gauge, 50, 100);
        }

        private void storeInterface_Load(object sender, EventArgs e)
        {
            regularBox.Visible = false;
            midBox.Visible = false;
            premiumBox.Visible = false;
        }

        private void regular_MouseHover(object sender, EventArgs e)
        {
            regularBox.Visible = true;
        }
      
        private void regular_MouseLeave(object sender, EventArgs e)
        {
            regularBox.Visible = false;
        }

        private void mid_MouseHover(object sender, EventArgs e)
        {
            midBox.Visible = true;
        }

        private void mid_MouseLeave(object sender, EventArgs e)
        {
            midBox.Visible = false;
        }

        private void premium_MouseHover(object sender, EventArgs e)
        {
            premiumBox.Visible = true;
        }

        private void premium_MouseLeave(object sender, EventArgs e)
        {
            premiumBox.Visible = false;
        }
    }
}
