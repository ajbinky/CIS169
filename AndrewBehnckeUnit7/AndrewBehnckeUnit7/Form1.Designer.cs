namespace AndrewBehnckeUnit7
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblBoard1 = new System.Windows.Forms.Label();
            this.lblBoard2 = new System.Windows.Forms.Label();
            this.lblBoard3 = new System.Windows.Forms.Label();
            this.lblBoard6 = new System.Windows.Forms.Label();
            this.lblBoard5 = new System.Windows.Forms.Label();
            this.lblBoard4 = new System.Windows.Forms.Label();
            this.lblBoard9 = new System.Windows.Forms.Label();
            this.lblBoard8 = new System.Windows.Forms.Label();
            this.lblBoard7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 188);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(99, 188);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.Location = new System.Drawing.Point(12, 159);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(159, 26);
            this.lblWinner.TabIndex = 2;
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoard1
            // 
            this.lblBoard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard1.Location = new System.Drawing.Point(12, 9);
            this.lblBoard1.Name = "lblBoard1";
            this.lblBoard1.Size = new System.Drawing.Size(50, 50);
            this.lblBoard1.TabIndex = 3;
            this.lblBoard1.Text = "X";
            this.lblBoard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoard2
            // 
            this.lblBoard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard2.Location = new System.Drawing.Point(68, 9);
            this.lblBoard2.Name = "lblBoard2";
            this.lblBoard2.Size = new System.Drawing.Size(50, 50);
            this.lblBoard2.TabIndex = 4;
            this.lblBoard2.Text = "X";
            this.lblBoard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoard3
            // 
            this.lblBoard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard3.Location = new System.Drawing.Point(124, 9);
            this.lblBoard3.Name = "lblBoard3";
            this.lblBoard3.Size = new System.Drawing.Size(50, 50);
            this.lblBoard3.TabIndex = 5;
            this.lblBoard3.Text = "X";
            this.lblBoard3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoard6
            // 
            this.lblBoard6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard6.Location = new System.Drawing.Point(124, 59);
            this.lblBoard6.Name = "lblBoard6";
            this.lblBoard6.Size = new System.Drawing.Size(50, 50);
            this.lblBoard6.TabIndex = 8;
            this.lblBoard6.Text = "X";
            this.lblBoard6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoard5
            // 
            this.lblBoard5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard5.Location = new System.Drawing.Point(68, 59);
            this.lblBoard5.Name = "lblBoard5";
            this.lblBoard5.Size = new System.Drawing.Size(50, 50);
            this.lblBoard5.TabIndex = 7;
            this.lblBoard5.Text = "X";
            this.lblBoard5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoard4
            // 
            this.lblBoard4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard4.Location = new System.Drawing.Point(12, 59);
            this.lblBoard4.Name = "lblBoard4";
            this.lblBoard4.Size = new System.Drawing.Size(50, 50);
            this.lblBoard4.TabIndex = 6;
            this.lblBoard4.Text = "X";
            this.lblBoard4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoard9
            // 
            this.lblBoard9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard9.Location = new System.Drawing.Point(124, 109);
            this.lblBoard9.Name = "lblBoard9";
            this.lblBoard9.Size = new System.Drawing.Size(50, 50);
            this.lblBoard9.TabIndex = 11;
            this.lblBoard9.Text = "X";
            this.lblBoard9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoard8
            // 
            this.lblBoard8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard8.Location = new System.Drawing.Point(68, 109);
            this.lblBoard8.Name = "lblBoard8";
            this.lblBoard8.Size = new System.Drawing.Size(50, 50);
            this.lblBoard8.TabIndex = 10;
            this.lblBoard8.Text = "X";
            this.lblBoard8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoard7
            // 
            this.lblBoard7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard7.Location = new System.Drawing.Point(12, 109);
            this.lblBoard7.Name = "lblBoard7";
            this.lblBoard7.Size = new System.Drawing.Size(50, 50);
            this.lblBoard7.TabIndex = 9;
            this.lblBoard7.Text = "X";
            this.lblBoard7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMain
            // 
            this.AcceptButton = this.btnNewGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(183, 219);
            this.Controls.Add(this.lblBoard9);
            this.Controls.Add(this.lblBoard8);
            this.Controls.Add(this.lblBoard7);
            this.Controls.Add(this.lblBoard6);
            this.Controls.Add(this.lblBoard5);
            this.Controls.Add(this.lblBoard4);
            this.Controls.Add(this.lblBoard3);
            this.Controls.Add(this.lblBoard2);
            this.Controls.Add(this.lblBoard1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Name = "formMain";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblBoard1;
        private System.Windows.Forms.Label lblBoard2;
        private System.Windows.Forms.Label lblBoard3;
        private System.Windows.Forms.Label lblBoard6;
        private System.Windows.Forms.Label lblBoard5;
        private System.Windows.Forms.Label lblBoard4;
        private System.Windows.Forms.Label lblBoard9;
        private System.Windows.Forms.Label lblBoard8;
        private System.Windows.Forms.Label lblBoard7;
    }
}

