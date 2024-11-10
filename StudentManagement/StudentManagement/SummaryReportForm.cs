using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentManagement
{
    public partial class SummaryReportForm : Form
    {
        public SummaryReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (File.Exists("students.txt"))
            {
                var lines = File.ReadAllLines("students.txt");

                // Calculate total students and average age
                int totalStudents = lines.Length;
                int ageSum = 0;
                int validAgeCount = 0;

                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    // Ensure the line has an age field and that it’s a valid integer
                    if (parts.Length >= 3 && int.TryParse(parts[2], out int age))
                    {
                        ageSum += age;
                        validAgeCount++;
                    }
                }

                // Calculate the average age if there are valid entries
                double averageAge = validAgeCount > 0 ? (double)ageSum / validAgeCount : 0;

                // Display the report in labels or text boxes
                lblTotalStudents.Text = "Total Students: " + totalStudents;
                lblAverageAge.Text = "Average Age: " + averageAge.ToString("0.00");

                // Prepare the report content for the summary file
                string reportContent = $"Total Students: {totalStudents}\nAverage Age: {averageAge:F2}";

                // Save the report to summary.txt
                File.WriteAllText("summary.txt", reportContent);

                MessageBox.Show("Report generated successfully and saved to summary.txt.", "Report Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No students found to generate a report.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
