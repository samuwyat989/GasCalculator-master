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
        const double GAS_PRIEMIUM = 1.019;
        const double GAS_REGULAR = 0.869;
        const double GAS_MID = 0.946;
        double carV = 49.9;
        double truckV = 87;
        double miniV = 76;
        string gasIn;
        string gasOut;
        string spend;
        double message;
        
        public storeInterface()
        {
            InitializeComponent();
        }

        private void costButton_Click(object sender, EventArgs e)
        {
            /*Graphics gas = this.CreateGraphics();
            gas.DrawImage(Properties.Resources.fuel_gauge, 400, 100, 150 , 250);
            Graphics lines = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 4);
            lines.DrawLine(redPen, 10, 30, 400, 30);
            lines.DrawLine(redPen, 480, 30, 700, 30);*/

            double gasRate;
            double vehicalType;
            gasIn = fuelAmount.Text;
            gasOut = fuelNeeded.Text;
            spend = moneyRequest.Text;

            try
            {
                if (regCheck.Checked) // Checks for what fuel type
                {
                    gasRate = GAS_REGULAR;
                    //midCheck.Enabled = false;
                    //premCheck.Enabled = false;
                }

                else if (midCheck.Checked)
                {
                    gasRate = GAS_MID;
                    //premCheck.Enabled = false;
                    //regCheck.Enabled = false;
                }
                else
                {
                    gasRate = GAS_PRIEMIUM;
                }

                if (carCheck.Checked) // Checks for what vehical type
                {
                    vehicalType = carV;
                }

                else if (truckCheck.Checked)
                {
                    vehicalType = truckV;
                }

                else
                {
                    vehicalType = miniV;
                }

                if (option1.Checked)  // Checks which option you chose
                {
                    message = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType;
                    outputLabel.Text = "The cost is " + message.ToString("C");
                }
                else
                {
                    message = ((Convert.ToDouble(spend) / gasRate) + (Convert.ToDouble(gasIn) * vehicalType)) / vehicalType * 100; 
                    outputLabel.Text = "Your tank is " + message.ToString(".##") + "% full.";
                }
                
            }
            catch
            {
                outputLabel.Text = "Please remember to fill all requirements. \nCheck the help section above if needed.";
            }

            Graphics box = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);//loop potential
            box.FillRectangle(whiteBrush, 30, 365, 250, 65);          
                        
        }
               
        private void storeInterface_Load(object sender, EventArgs e)
        {
            Graphics lines = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 4);
            lines.DrawLine(redPen, 10, 30, 400, 30);
            lines.DrawLine(redPen, 480, 30, 700, 30);

            regularBox.Visible = false;
            midBox.Visible = false;
            premiumBox.Visible = false;                             
        }

        private void regCheck_MouseHover(object sender, EventArgs e)
        {
            regularBox.Visible = true;
        }

        private void regCheck_MouseLeave(object sender, EventArgs e)
        {
            regularBox.Visible = false;
        }

        private void midCheck_MouseHover(object sender, EventArgs e)
        {
            midBox.Visible = true;
        }

        private void midCheck_MouseLeave(object sender, EventArgs e)
        {
            midBox.Visible = false;
        }

        private void premCheck_MouseHover(object sender, EventArgs e)
        {
            premiumBox.Visible = true;
        }

        private void premCheck_MouseLeave(object sender, EventArgs e)
        {
            premiumBox.Visible = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            int loopNumber = 300;
            int xr = 721;
            for (int x = 0; x < loopNumber; x++)
            {
                this.Size = new Size(xr, 484);
                Thread.Sleep(1);
                xr++;
            }                       

            Graphics print = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);//loop potential
            SolidBrush textBrush = new SolidBrush(Color.Black);
            Font printFont = new Font("Courier New", 12);

            print.FillRectangle(whiteBrush, 735, 20, 225, 400);
            print.DrawString("THE GAS CORNER", printFont, textBrush, 765, 30);
            print.DrawString("SALES RECEIPT", printFont, textBrush, 765, 45);

        }
    }
}
