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

Unit 4 - Time Calculator

Takes user input for number of seconds and calculates how many seconds, minutes, hours etc. there are.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace TimeCalculator
{
    public partial class formMain : Form
    {

        private const int minute = 60;
        private const int hour = 3600;
        private const int day = 216000;
        private const int week = 604800;
        private const int year = 31557600;
        

        public formMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int input = int.Parse(tbSeconds.Text);

                if (input == year)
                {
                    clear();
                    lblMinutesNum.Text = "525,600";
                    lblSeconds.Text = "Moments of the year:";
                    lblSecondsNum.Text = "525,000";
                } else {
                    clear();
                    int years = input / year;
                    input %= year;
                    int weeks = input / week;
                    input %= week;
                    int days = input / day;
                    input %= day;
                    int hours = input / hour;
                    input %= hour;
                    int minutes = input / minute;
                    input %= minute;
                    int seconds = input;

                    lblYearsNum.Text = years.ToString();
                    lblWeeksNum.Text = weeks.ToString();
                    lblDaysNum.Text = days.ToString();
                    lblHoursNum.Text = hours.ToString();
                    lblMinutesNum.Text = minutes.ToString();
                    lblSecondsNum.Text = seconds.ToString();

                    tbSeconds.Focus();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbSeconds.Text = "";
                tbSeconds.Focus();
            }
        }

        private void clear()
        {
            lblYearsNum.Text = "0";
            lblWeeksNum.Text = "0";
            lblDaysNum.Text = "0";
            lblHoursNum.Text = "0";
            lblMinutesNum.Text = "0";
            lblSeconds.Text = "Seconds:";
            lblSecondsNum.Text = "0";
            tbSeconds.Text = "";
            tbSeconds.Focus();
        }

    }
}
