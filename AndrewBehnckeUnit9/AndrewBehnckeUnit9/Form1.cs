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
 Unit 9 - Car Class
 Car class with demo
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/
namespace AndrewBehnckeUnit9
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Creates new car object and opens a new form for it
         **/
        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            string year = lblYear.Text;
            string make = lblMake.Text;
            Car c = new Car(tbYear.Text, tbMake.Text);
            CarForm cf = new CarForm(c);
            cf.ShowDialog();
        }
    }
}
