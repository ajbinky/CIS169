using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewBehnckeUnit7
{
    public partial class formMain : Form
    {
        Random randy = new Random();
        Label[] lbl = new Label[9];
        const int size = 3;
        int[,] board = new int[size,size];

        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i] = new Label
                {
                    Location = new Point((25*i), (25*i)),
                    Text = "Label " + i,
                    AutoSize = true
                    
                };
            }

            foreach (Label l in lbl)
            {
                this.Controls.Add(l);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = randy.Next(2);
                }
            }
        }
    }
}