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
 Unit 7 - Tic Tac Toe
 Randomly generated tic tac toe board
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/

namespace AndrewBehnckeUnit7
{
    public partial class formMain : Form
    {
        Random randy = new Random();
        const int size = 3;
        int[,] board = new int[size,size];
        Label[,] labels = new Label[size,size];

        public formMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
			// Change labels and fill board array
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int randomInt = randy.Next(2);
                    board[i, j] = randomInt;
                    changeLabel(labels[i, j], randomInt);
                }
            }

			// Calculate winner
            int x = countRows(1);
            int o = countRows(0);
            if (x - o == 0) lblWinner.Text = "Tie";
            if (x - o < 0) lblWinner.Text = "O Wins";
            if (x - o > 0) lblWinner.Text = "X Wins";

        }

        /**
         *  Changes the label text to either "O" or "X" depending on given int i
         **/
        private void changeLabel(Label l, int i)
        {
            if (i == 0) l.Text = "O";
            if (i == 1) l.Text = "X";
            return;
        }

		/**
         *  Used to see who the winner is
         **/
        private int countRows(int i)
        {
            int count = 0;

            // Rows
            for (int x = 0; x < size; x++)
            {
                if (board[x,0] == i && board[x,1] == i && board[x,2] == i)
                {
                    count++;
                }
            }

            // Columns
            for (int x = 0; x < size; x++)
            {
                if (board[0, x] == i && board[1, x] == i && board[2, x] == i)
                {
                    count++;
                }
            }

            // Diagonals
            if (((board[0,0] == i && board[2,2] == i) || (board[0,2] == i && board[2,0] == i)) && board[1,1] == i)
            {
                count++;
            }
            return count;
        }

		/**
         *  Put labels into 2D array
         **/
        private void formMain_Load(object sender, EventArgs e)
        {
            labels[0, 0] = lblBoard1;
            labels[0, 1] = lblBoard2;
            labels[0, 2] = lblBoard3;
            labels[1, 0] = lblBoard4;
            labels[1, 1] = lblBoard5;
            labels[1, 2] = lblBoard6;
            labels[2, 0] = lblBoard7;
            labels[2, 1] = lblBoard8;
            labels[2, 2] = lblBoard9;
        }
    }
}