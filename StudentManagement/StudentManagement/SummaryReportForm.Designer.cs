namespace StudentManagement
{
    partial class SummaryReportForm
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
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.btnGrenerateReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(114, 29);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(93, 16);
            this.lblTotalStudents.TabIndex = 0;
            this.lblTotalStudents.Text = "Total Students";
            // 
            // btnGrenerateReport
            // 
            this.btnGrenerateReport.Location = new System.Drawing.Point(95, 130);
            this.btnGrenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrenerateReport.Name = "btnGrenerateReport";
            this.btnGrenerateReport.Size = new System.Drawing.Size(145, 40);
            this.btnGrenerateReport.TabIndex = 2;
            this.btnGrenerateReport.Text = "Genrate Report";
            this.btnGrenerateReport.UseVisualStyleBackColor = true;
            this.btnGrenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 4;
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Location = new System.Drawing.Point(114, 84);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(87, 16);
            this.lblAverageAge.TabIndex = 6;
            this.lblAverageAge.Text = "Average Age";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(95, 174);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 174);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SummaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 216);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAverageAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGrenerateReport);
            this.Controls.Add(this.lblTotalStudents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SummaryReportForm";
            this.Text = "Report Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion  

        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Button btnGrenerateReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}