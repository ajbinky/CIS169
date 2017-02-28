namespace AndrewBehnckeUnit2
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAi = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbAi = new System.Windows.Forms.PictureBox();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblAiScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(12, 168);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "&Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(12, 197);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "&Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(12, 226);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 23);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "&Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            // 
            // lblAi
            // 
            this.lblAi.AutoSize = true;
            this.lblAi.Location = new System.Drawing.Point(243, 9);
            this.lblAi.Name = "lblAi";
            this.lblAi.Size = new System.Drawing.Size(29, 13);
            this.lblAi.TabIndex = 5;
            this.lblAi.Text = "CPU";
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(12, 25);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(130, 137);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 6;
            this.pbUser.TabStop = false;
            this.pbUser.Visible = false;
            // 
            // pbAi
            // 
            this.pbAi.Location = new System.Drawing.Point(142, 25);
            this.pbAi.Name = "pbAi";
            this.pbAi.Size = new System.Drawing.Size(130, 137);
            this.pbAi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAi.TabIndex = 7;
            this.pbAi.TabStop = false;
            this.pbAi.Visible = false;
            // 
            // lblUserScore
            // 
            this.lblUserScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Location = new System.Drawing.Point(119, 9);
            this.lblUserScore.Margin = new System.Windows.Forms.Padding(3);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblUserScore.Size = new System.Drawing.Size(23, 13);
            this.lblUserScore.TabIndex = 8;
            this.lblUserScore.Text = "0";
            // 
            // lblAiScore
            // 
            this.lblAiScore.AutoSize = true;
            this.lblAiScore.Location = new System.Drawing.Point(139, 9);
            this.lblAiScore.Margin = new System.Windows.Forms.Padding(3);
            this.lblAiScore.Name = "lblAiScore";
            this.lblAiScore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAiScore.Size = new System.Drawing.Size(23, 13);
            this.lblAiScore.TabIndex = 9;
            this.lblAiScore.Text = "0";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAiScore);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.pbAi);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.lblAi);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "formMain";
            this.Text = "Roshambo";
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAi;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbAi;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblAiScore;
    }
}

