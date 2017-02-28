namespace AndrewBehnckeUnit6
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
            this.lblDays = new System.Windows.Forms.Label();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.lblMed = new System.Windows.Forms.Label();
            this.tbMed = new System.Windows.Forms.TextBox();
            this.lblSurgical = new System.Windows.Forms.Label();
            this.tbSurgical = new System.Windows.Forms.TextBox();
            this.lblLab = new System.Windows.Forms.Label();
            this.tbLab = new System.Windows.Forms.TextBox();
            this.lblRehab = new System.Windows.Forms.Label();
            this.tbRehab = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCalcTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(12, 15);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days:";
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(172, 12);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(100, 20);
            this.tbDays.TabIndex = 1;
            this.tbDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(12, 41);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(104, 13);
            this.lblMed.TabIndex = 2;
            this.lblMed.Text = "Medication Charges:";
            // 
            // tbMed
            // 
            this.tbMed.Location = new System.Drawing.Point(172, 38);
            this.tbMed.Name = "tbMed";
            this.tbMed.Size = new System.Drawing.Size(100, 20);
            this.tbMed.TabIndex = 3;
            this.tbMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSurgical
            // 
            this.lblSurgical.AutoSize = true;
            this.lblSurgical.Location = new System.Drawing.Point(12, 67);
            this.lblSurgical.Name = "lblSurgical";
            this.lblSurgical.Size = new System.Drawing.Size(90, 13);
            this.lblSurgical.TabIndex = 4;
            this.lblSurgical.Text = "Surgical Charges:";
            // 
            // tbSurgical
            // 
            this.tbSurgical.Location = new System.Drawing.Point(172, 64);
            this.tbSurgical.Name = "tbSurgical";
            this.tbSurgical.Size = new System.Drawing.Size(100, 20);
            this.tbSurgical.TabIndex = 5;
            this.tbSurgical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Location = new System.Drawing.Point(12, 93);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(54, 13);
            this.lblLab.TabIndex = 6;
            this.lblLab.Text = "Lab Fees:";
            // 
            // tbLab
            // 
            this.tbLab.Location = new System.Drawing.Point(172, 90);
            this.tbLab.Name = "tbLab";
            this.tbLab.Size = new System.Drawing.Size(100, 20);
            this.tbLab.TabIndex = 7;
            this.tbLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRehab
            // 
            this.lblRehab.AutoSize = true;
            this.lblRehab.Location = new System.Drawing.Point(12, 119);
            this.lblRehab.Name = "lblRehab";
            this.lblRehab.Size = new System.Drawing.Size(126, 13);
            this.lblRehab.TabIndex = 8;
            this.lblRehab.Text = "Physical Rehab Charges:";
            // 
            // tbRehab
            // 
            this.tbRehab.Location = new System.Drawing.Point(172, 116);
            this.tbRehab.Name = "tbRehab";
            this.tbRehab.Size = new System.Drawing.Size(100, 20);
            this.tbRehab.TabIndex = 9;
            this.tbRehab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 149);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // lblCalcTotal
            // 
            this.lblCalcTotal.Location = new System.Drawing.Point(52, 149);
            this.lblCalcTotal.Name = "lblCalcTotal";
            this.lblCalcTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCalcTotal.Size = new System.Drawing.Size(223, 23);
            this.lblCalcTotal.TabIndex = 11;
            this.lblCalcTotal.Text = "$0.00";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 175);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCalcTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbRehab);
            this.Controls.Add(this.lblRehab);
            this.Controls.Add(this.tbLab);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.tbSurgical);
            this.Controls.Add(this.lblSurgical);
            this.Controls.Add(this.tbMed);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.tbDays);
            this.Controls.Add(this.lblDays);
            this.Name = "formMain";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.TextBox tbMed;
        private System.Windows.Forms.Label lblSurgical;
        private System.Windows.Forms.TextBox tbSurgical;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.TextBox tbLab;
        private System.Windows.Forms.Label lblRehab;
        private System.Windows.Forms.TextBox tbRehab;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCalcTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

