using System;
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
