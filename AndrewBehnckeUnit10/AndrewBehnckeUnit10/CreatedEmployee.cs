﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewBehnckeUnit10
{
    /**
     *  New form created to display the info from a created ProductionWorker
     **/
    public partial class formCreatedEmployee : Form
    {
        /**
         *  Something something constructor
         **/
        public formCreatedEmployee(ProductionWorker pw)
        {
            InitializeComponent();
            this.lblName.Text = "Name: " + pw.Name;
            this.lblNumber.Text = "Employee Number: " + pw.Number;
            this.lblShift.Text = "Shift: " + pw.Shift;
            this.lblPayRate.Text = "Pay Rate: " + pw.PayRate.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
