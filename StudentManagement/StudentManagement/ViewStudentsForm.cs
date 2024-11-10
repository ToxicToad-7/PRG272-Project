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
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
            // Define columns for the DataGridView
            dgvDelete.ColumnCount = 4;
            dgvDelete   .Columns[0].Name = "Student ID";
            dgvDelete.Columns[1].Name = "Name";
            dgvDelete.Columns[2].Name = "Age";
            dgvDelete.Columns[3].Name = "Course";

            // Load students when form loads
            mainForm.LoadStudents(dgvDelete);
        }
        btnGenerateReport mainForm = new btnGenerateReport();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the ID from the search text box
            string id = txtSearch.Text.Trim();

            // Check if an ID has been entered
            if (!string.IsNullOrEmpty(id))
            {
                // Check if the file exists
                if (File.Exists("students.txt"))
                {
                    // Read all lines, excluding the line that starts with the matching ID
                    var lines = File.ReadAllLines("students.txt").Where(line => !line.StartsWith(id + ",")).ToList();

                    // Check if any line was removed (i.e., the student existed)
                    if (lines.Count < File.ReadAllLines("students.txt").Length)
                    {
                        // Write the updated list back to the file
                        File.WriteAllLines("students.txt", lines);

                        // Refresh the DataGridView to reflect the deletion
                        mainForm.LoadStudents(dgvDelete);

                        MessageBox.Show("Student deleted successfully!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student ID not found.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The student data file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a student ID to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
