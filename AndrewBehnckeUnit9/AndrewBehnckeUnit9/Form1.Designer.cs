namespace AndrewBehnckeUnit9
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 9);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(115, 9);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Make:";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(12, 25);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 2;
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(118, 25);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(100, 20);
            this.tbMake.TabIndex = 3;
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(12, 51);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(100, 23);
            this.btnCreateCar.TabIndex = 4;
            this.btnCreateCar.Text = "&Create Car";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(118, 51);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formMain
            // 
            this.AcceptButton = this.btnCreateCar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(229, 85);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateCar);
            this.Controls.Add(this.tbMake);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblYear);
            this.Name = "formMain";
            this.Text = "Car Factory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Button btnExit;
    }
}

