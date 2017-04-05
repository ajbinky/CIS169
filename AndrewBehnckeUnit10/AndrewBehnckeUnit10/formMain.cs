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
 Unit 10 - Employee and ProductionWorder Classes
 ProductionWorker extending Employee w/ demo
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/
namespace AndrewBehnckeUnit10
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
         *  Creates new production worker and shows it in new form.
         **/
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ProductionWorker bob = new ProductionWorker();
                bob.Name = tbName.Text;
                bob.Number = int.Parse(tbNumber.Text);
                bob.PayRate = double.Parse(tbPayRate.Text);
                bob.Shift = int.Parse(tbShift.Text);
                formCreatedEmployee emp = new formCreatedEmployee(bob);
                emp.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
