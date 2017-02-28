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
 Unit 2 - Heads or Tails (Roshambo)
 Rock Paper Scissors game where ties go to the ai (because I'm lazy)
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/

namespace AndrewBehnckeUnit6
{
    public partial class formMain : Form
    {

        private int days;
        private double med;
        private double surgical;
        private double lab;
        private double rehab;

        public formMain()
        {
            InitializeComponent();
        }

        /**
         *  Calculates the base charge
         **/
        private double calcStayCharges(int d)
        {
            try
            {
                return 350 * d;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /**
         *  Calculates the miscellaneous charges
         **/
        private double calcMiscCharges(double m, double s, double l, double r)
        {
            try
            {
                return m + s + l + r;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /**
         *  Calculates the total charges
         **/
        private double calcTotalCharges(int d, double m, double s, double l, double r)
        {
            try
            {
                return calcStayCharges(d) + calcMiscCharges(m, s, l, r);
            } catch (Exception)
            {
                return -1;
            }
        }

        /**
         *  Closes application
         **/
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         *  Calculates total based on given information, and displays it
         **/
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                days = int.Parse(tbDays.Text);
                med = double.Parse(tbMed.Text);
                surgical = double.Parse(tbSurgical.Text);
                lab = double.Parse(tbLab.Text);
                rehab = double.Parse(tbRehab.Text);
            } catch (FormatException)
            {
                MessageBox.Show("Please fill out all fields correctly");
            } catch (Exception ex)
            {
                MessageBox.Show("You broke it -  " + ex.Message);
            }

            lblCalcTotal.Text = "$" + calcTotalCharges(days, med, surgical, lab, rehab).ToString("f2");
        }
    }
}
