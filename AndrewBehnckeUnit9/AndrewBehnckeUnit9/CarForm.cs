using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewBehnckeUnit9
{
    public partial class CarForm : Form
    {
        // Private instance variables
        private Car car;

        /**
         * Something something constructor
         **/
        public CarForm(Car c)
        {
            InitializeComponent();
            this.car = c;
            this.Text = car.getMake() + " - " + car.getYear();
            this.lblSpeed.Text = car.getSpeed().ToString();
        }

        /**
         * Executes the Accelerate method on the Car given on form creation
         **/
        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            car.Accelerate();
            this.lblSpeed.Text = car.getSpeed().ToString();
        }

        /**
         * Executes the Brake method on the Car given on form creation
         **/
        private void btnBrake_Click(object sender, EventArgs e)
        {
            car.Brake();
            this.lblSpeed.Text = car.getSpeed().ToString();
        }

        /**
         * Something something exit button
         **/
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
