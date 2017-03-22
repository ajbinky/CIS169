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
 Unit 8 - Vending Machine
 Simulated vending machine
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/

namespace AndrewBehnckeUnit8
{

    public struct soda
    {
        public string name;
        public double cost;
        public int stock;

        public soda(string name, double cost, int stock)
        {
            this.name = name;
            this.cost = cost;
            this.stock = stock;
        }
    }

    public partial class formMain : Form
    {

        soda[] sodas = {new soda("Cola", 1, 20), new soda("Root Beer", 1, 20), new soda("Lemon Lime", 1, 20), new soda("Grape Soda", 1.5, 20), new soda("Cream Soda", 1.5, 20) };
        public double sales = 0;

        public formMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbCola_Click(object sender, EventArgs e)
        {
            if(sodas[0].stock > 0)
            {
                sodas[0].stock -= 1;
                sales += sodas[0].cost;
                lblColaDrinksLeft.Text = "Drinks Left: " + sodas[0].stock.ToString();
                lblRunningTotal.Text = sales.ToString("c");
            }
        }

        private void pbLemonLime_Click(object sender, EventArgs e)
        {
            if (sodas[2].stock > 0)
            {
                sodas[2].stock -= 1;
                sales += sodas[2].cost;
                lblLemonLimeDrinksLeft.Text = "Drinks Left: " + sodas[2].stock.ToString();
                lblRunningTotal.Text = sales.ToString("c");
            }
        }

        private void pbCreamSoda_Click(object sender, EventArgs e)
        {
            if (sodas[4].stock > 0)
            {
                sodas[4].stock -= 1;
                sales += sodas[4].cost;
                lblCreamSodaDrinksLeft.Text = "Drinks Left: " + sodas[4].stock.ToString();
                lblRunningTotal.Text = sales.ToString("c");
            }
        }

        private void pbRootBeer_Click(object sender, EventArgs e)
        {
            if (sodas[1].stock > 0)
            {
                sodas[1].stock -= 1;
                sales += sodas[1].cost;
                lblRootBeerDrinksLeft.Text = "Drinks Left: " + sodas[1].stock.ToString();
                lblRunningTotal.Text = sales.ToString("c");
            }
        }

        private void pbGrapeSoda_Click(object sender, EventArgs e)
        {
            if (sodas[3].stock > 0)
            {
                sodas[3].stock -= 1;
                sales += sodas[3].cost;
                lblGrapeSodaDrinksLeft.Text = "Drinks Left: " + sodas[3].stock.ToString();
                lblRunningTotal.Text = sales.ToString("c");
            }
        }
    }
}
