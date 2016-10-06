using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasCalculator
{
    public partial class storeInterface : Form
    {
        const double GAS_PRIEMIUM = 0.95;
        const double GAS_REGULAR = 0.75;
        const double GAS_SUPER = 0.85;

        public storeInterface()
        {
            InitializeComponent();
        }

        private void costButton_Click(object sender, EventArgs e)
        {

        }

        private void storeInterface_Load(object sender, EventArgs e)
        {
            regularBox.Visible = false;
            superBox.Visible = false;
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

        private void super_MouseHover(object sender, EventArgs e)
        {
            superBox.Visible = true;
        }

        private void super_MouseLeave(object sender, EventArgs e)
        {
            superBox.Visible = false;
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
