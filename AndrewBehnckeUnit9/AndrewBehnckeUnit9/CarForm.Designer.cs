namespace AndrewBehnckeUnit9
{
    partial class CarForm
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
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(12, 65);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(75, 23);
            this.btnAccelerate.TabIndex = 0;
            this.btnAccelerate.Text = "&Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(93, 65);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(75, 23);
            this.btnBrake.TabIndex = 1;
            this.btnBrake.Text = "&Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 65);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(12, 9);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(237, 53);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "label1";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 100);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnAccelerate);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSpeed;
    }
}