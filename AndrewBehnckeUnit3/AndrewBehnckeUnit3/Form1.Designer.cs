namespace AndrewBehnckeUnit3
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
            this.tbCharge = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCharge
            // 
            this.tbCharge.Location = new System.Drawing.Point(12, 12);
            this.tbCharge.Name = "tbCharge";
            this.tbCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCharge.Size = new System.Drawing.Size(100, 23);
            this.tbCharge.TabIndex = 0;
            this.tbCharge.Text = "Bill Amount";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(118, 12);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(199, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&EXIT";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(12, 38);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(30, 15);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Tip: ";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(12, 53);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(33, 15);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 68);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: ";
            // 
            // formMain
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(286, 89);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbCharge);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formMain";
            this.Text = "Tip, Tax, and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCharge;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}

