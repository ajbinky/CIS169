using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/** =========================================================

 Andrew Behncke

 Windows 10

 Microsoft Visual Studio 2015 Community

 CIS 169

 Unit 3 - Tip, Tax, and Total

 Given a number, will calculate and display 15%, 7%, and total

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace AndrewBehnckeUnit3
{
    public partial class formMain : Form
    {

        double x;
        const double tipPercent = .15;
        const double taxPercent = .07;

        public formMain()
        {
            InitializeComponent();
        }

        /**
         * Closes the application
         **/
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Takes the input, does the calculations, and displays the information
         **/
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (tbCharge.Text.Equals("Bill Amount"))
            {
                MessageBox.Show("Please enter a number.");
                return;
            }
            try
            {
                x = Double.Parse(tbCharge.Text);
                double tip = x * tipPercent;
                double tax = x * taxPercent;
                lblTip.Text = "Tip: " + tip.ToString("c");
                lblTax.Text = "Tax: " + tax.ToString("c");
                lblTotal.Text = "Total: " + (x + tip + tax).ToString("c");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
