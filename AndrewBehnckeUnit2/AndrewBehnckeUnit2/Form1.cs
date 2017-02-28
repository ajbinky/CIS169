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

namespace AndrewBehnckeUnit2
{
    public partial class formMain : Form
    {

        Random randy = new Random();
        String rock = "http://geology.com/articles/difficult-rocks/difficult-rock-identification.jpg";
        String paper = "http://www.ibidworld.com/images/papper%20and%20paper%20product/paper.jpg";
        String scissors = "http://www.clipartbest.com/cliparts/jix/Lke/jixLke5iE.gif";

        public formMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnRock_Click(object sender, EventArgs e)
        {
            pbUser.ImageLocation = rock;
            pbUser.Visible = true;
            int ai = randy.Next() % 3;
            switch(ai)
            {
                case 0:
                    pbAi.ImageLocation = rock;
                    break;
                case 1:
                    pbAi.ImageLocation = paper;
                    break;
                case 2:
                    pbAi.ImageLocation = scissors;
                    break;
            }
            pbAi.Visible = true;
            if (game(0, ai))
            {
                int score = int.Parse(lblUserScore.Text);
                score++;
                lblUserScore.Text = score.ToString();
            }
            else
            {
                int score = int.Parse(lblAiScore.Text);
                score++;
                lblAiScore.Text = score.ToString();
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            pbUser.ImageLocation = paper;
            pbUser.Visible = true;
            int ai = randy.Next() % 3;
            switch (ai)
            {
                case 0:
                    pbAi.ImageLocation = rock;
                    break;
                case 1:
                    pbAi.ImageLocation = paper;
                    break;
                case 2:
                    pbAi.ImageLocation = scissors;
                    break;
            }
            pbAi.Visible = true;
            if (game(1, ai))
            {
                int score = int.Parse(lblUserScore.Text);
                score++;
                lblUserScore.Text = score.ToString();
            }
            else
            {
                int score = int.Parse(lblAiScore.Text);
                score++;
                lblAiScore.Text = score.ToString();
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            pbUser.ImageLocation = scissors;
            pbUser.Visible = true;
            int ai = randy.Next() % 3;
            switch (ai)
            {
                case 0:
                    pbAi.ImageLocation = rock;
                    break;
                case 1:
                    pbAi.ImageLocation = paper;
                    break;
                case 2:
                    pbAi.ImageLocation = scissors;
                    break;
            }
            pbAi.Visible = true;
            if (game(2, ai))
            {
                int score = int.Parse(lblUserScore.Text);
                score++;
                lblUserScore.Text = score.ToString();
            } else
            {
                int score = int.Parse(lblAiScore.Text);
                score++;
                lblAiScore.Text = score.ToString();
            }
        }

        /**
         * Parameters
         *      int user - 0 (rock), 1 (paper), 2, (scissors)
         *      int ai - 0 (rock), 1 (paper), 2, (scissors)
         * Returns
         *      true if user beats ai
         *      false if ai beats user
         *      
         * Ties count as a loss because I don't want to change the return type right now.
         **/
        private bool game(int user, int ai)
        {
            if (user == ai)
            {
                return false;
            }
            switch(user)
            {
                case 0:
                    if (ai == 2)
                    {
                        return true;
                    }
                    break;
                case 1:
                    if (ai == 0)
                    {
                        return true;
                    }
                    break;
                case 2:
                    if (ai == 1)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}
