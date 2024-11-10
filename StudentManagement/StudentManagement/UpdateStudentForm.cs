using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace StudentManagement
{
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
            // Define columns for the DataGridView
            dgvSearch.ColumnCount = 4;
            dgvSearch.Columns[0].Name = "Student ID";
            dgvSearch.Columns[1].Name = "Name";
            dgvSearch.Columns[2].Name = "Age";
            dgvSearch.Columns[3].Name = "Course";

            // Load students when form loads
            mainForrm.LoadStudents(dgvSearch);
        }

        btnGenerateReport mainForrm = new btnGenerateReport();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearch2.Text.Trim();
            if (File.Exists("students.txt"))
            {
                // Search for the line that starts with the ID
                var studentData = File.ReadAllLines("students.txt").FirstOrDefault(line => line.StartsWith(id + ","));
                if (studentData != null)
                {
                    // Split the found line and populate text fields
                    string[] data = studentData.Split(',');
                    if (data.Length >= 4) // Ensure there are enough fields
                    {
                        txtName.Text = data[1];
                        txtAge.Text = data[2];
                        txtCourse.Text = data[3];
                    }
                    else
                    {
                        MessageBox.Show("Student data format is incorrect.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Student not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The student data file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                // Get the selected row and Student ID
                var selectedRow = dgvSearch.SelectedRows[0];
                string studentID = selectedRow.Cells[0].Value?.ToString();

                // Get updated data from textboxes
                string updatedName = txtName.Text.Trim();
                string updatedAge = txtAge.Text.Trim();
                string updatedCourse = txtCourse.Text.Trim();

                // Validate age input
                if (!int.TryParse(updatedAge, out int age))
                {
                    MessageBox.Show("Please enter a valid age.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Read all lines from the file
                var lines = File.ReadAllLines("students.txt");

                // Update the student record in the file
                for (int i = 0; i < lines.Length; i++)
                {
                    var lineData = lines[i].Split(',');

                    // Check if the first element (Student ID) matches the selected record
                    if (lineData[0] == studentID)
                    {
                        // Update the line with new data and join with commas
                        lines[i] = $"{studentID},{updatedName},{age},{updatedCourse}";
                        break;
                    }
                }

                // Write all lines back to the file with updated data
                File.WriteAllLines("students.txt", lines);

                MessageBox.Show("Student record updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh DataGridView to show updated data
                mainForrm.LoadStudents(dgvSearch);
            }
            else
            {
                MessageBox.Show("Please select a student record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}

