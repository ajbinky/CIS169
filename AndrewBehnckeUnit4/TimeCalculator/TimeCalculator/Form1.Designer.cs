namespace TimeCalculator
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
            this.lblEnterSeconds = new System.Windows.Forms.Label();
            this.tbSeconds = new System.Windows.Forms.TextBox();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lblSecondsNum = new System.Windows.Forms.Label();
            this.lblMinutesNum = new System.Windows.Forms.Label();
            this.lblHoursNum = new System.Windows.Forms.Label();
            this.lblDaysNum = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWeeks = new System.Windows.Forms.Label();
            this.lblWeeksNum = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblYearsNum = new System.Windows.Forms.Label();
            this.gbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterSeconds
            // 
            this.lblEnterSeconds.AutoSize = true;
            this.lblEnterSeconds.Location = new System.Drawing.Point(12, 9);
            this.lblEnterSeconds.Name = "lblEnterSeconds";
            this.lblEnterSeconds.Size = new System.Drawing.Size(80, 13);
            this.lblEnterSeconds.TabIndex = 0;
            this.lblEnterSeconds.Text = "Enter Seconds:";
            // 
            // tbSeconds
            // 
            this.tbSeconds.Location = new System.Drawing.Point(149, 6);
            this.tbSeconds.Name = "tbSeconds";
            this.tbSeconds.Size = new System.Drawing.Size(100, 20);
            this.tbSeconds.TabIndex = 1;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lblYearsNum);
            this.gbResults.Controls.Add(this.lblYears);
            this.gbResults.Controls.Add(this.lblWeeksNum);
            this.gbResults.Controls.Add(this.lblWeeks);
            this.gbResults.Controls.Add(this.lblSecondsNum);
            this.gbResults.Controls.Add(this.lblMinutesNum);
            this.gbResults.Controls.Add(this.lblHoursNum);
            this.gbResults.Controls.Add(this.lblDaysNum);
            this.gbResults.Controls.Add(this.lblSeconds);
            this.gbResults.Controls.Add(this.lblMinutes);
            this.gbResults.Controls.Add(this.lblHours);
            this.gbResults.Controls.Add(this.lblDays);
            this.gbResults.Location = new System.Drawing.Point(15, 32);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(234, 188);
            this.gbResults.TabIndex = 2;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // lblSecondsNum
            // 
            this.lblSecondsNum.AutoSize = true;
            this.lblSecondsNum.Location = new System.Drawing.Point(171, 150);
            this.lblSecondsNum.Name = "lblSecondsNum";
            this.lblSecondsNum.Size = new System.Drawing.Size(13, 13);
            this.lblSecondsNum.TabIndex = 7;
            this.lblSecondsNum.Text = "0";
            // 
            // lblMinutesNum
            // 
            this.lblMinutesNum.AutoSize = true;
            this.lblMinutesNum.Location = new System.Drawing.Point(171, 125);
            this.lblMinutesNum.Name = "lblMinutesNum";
            this.lblMinutesNum.Size = new System.Drawing.Size(13, 13);
            this.lblMinutesNum.TabIndex = 6;
            this.lblMinutesNum.Text = "0";
            // 
            // lblHoursNum
            // 
            this.lblHoursNum.AutoSize = true;
            this.lblHoursNum.Location = new System.Drawing.Point(171, 99);
            this.lblHoursNum.Name = "lblHoursNum";
            this.lblHoursNum.Size = new System.Drawing.Size(13, 13);
            this.lblHoursNum.TabIndex = 5;
            this.lblHoursNum.Text = "0";
            // 
            // lblDaysNum
            // 
            this.lblDaysNum.AutoSize = true;
            this.lblDaysNum.Location = new System.Drawing.Point(171, 75);
            this.lblDaysNum.Name = "lblDaysNum";
            this.lblDaysNum.Size = new System.Drawing.Size(13, 13);
            this.lblDaysNum.TabIndex = 4;
            this.lblDaysNum.Text = "0";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(6, 150);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(52, 13);
            this.lblSeconds.TabIndex = 3;
            this.lblSeconds.Text = "Seconds:";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(6, 125);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(47, 13);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "Minutes:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(6, 99);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(38, 13);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "Hours:";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(6, 75);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 226);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Cle&ar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(174, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWeeks
            // 
            this.lblWeeks.AutoSize = true;
            this.lblWeeks.Location = new System.Drawing.Point(6, 52);
            this.lblWeeks.Name = "lblWeeks";
            this.lblWeeks.Size = new System.Drawing.Size(44, 13);
            this.lblWeeks.TabIndex = 8;
            this.lblWeeks.Text = "Weeks:";
            // 
            // lblWeeksNum
            // 
            this.lblWeeksNum.AutoSize = true;
            this.lblWeeksNum.Location = new System.Drawing.Point(171, 52);
            this.lblWeeksNum.Name = "lblWeeksNum";
            this.lblWeeksNum.Size = new System.Drawing.Size(13, 13);
            this.lblWeeksNum.TabIndex = 9;
            this.lblWeeksNum.Text = "0";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(6, 29);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(37, 13);
            this.lblYears.TabIndex = 10;
            this.lblYears.Text = "Years:";
            // 
            // lblYearsNum
            // 
            this.lblYearsNum.AutoSize = true;
            this.lblYearsNum.Location = new System.Drawing.Point(171, 29);
            this.lblYearsNum.Name = "lblYearsNum";
            this.lblYearsNum.Size = new System.Drawing.Size(13, 13);
            this.lblYearsNum.TabIndex = 11;
            this.lblYearsNum.Text = "0";
            // 
            // formMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(262, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.tbSeconds);
            this.Controls.Add(this.lblEnterSeconds);
            this.Name = "formMain";
            this.Text = "Time Calculator";
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterSeconds;
        private System.Windows.Forms.TextBox tbSeconds;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.Label lblSecondsNum;
        private System.Windows.Forms.Label lblMinutesNum;
        private System.Windows.Forms.Label lblHoursNum;
        private System.Windows.Forms.Label lblDaysNum;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblYearsNum;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblWeeksNum;
        private System.Windows.Forms.Label lblWeeks;
    }
}

