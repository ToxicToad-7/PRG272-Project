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
    public partial class btnGenerateReport : Form
    {
        public btnGenerateReport()
        {
            InitializeComponent();
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Open SummaryReportForm as a modal dialog
            SummaryReportForm summaryReportForm = new SummaryReportForm();
            summaryReportForm.ShowDialog();

            // Show the main form again when SummaryReportForm is closed
            this.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Open AddStudentForm as a modal dialog
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();

            // Show the main form again when AddStudentForm is closed
            this.Show();
        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Open ViewStudentsForm as a modal dialog
            ViewStudentsForm viewStudentsForm = new ViewStudentsForm();
            viewStudentsForm.ShowDialog();

            // Show the main form again when ViewStudentsForm is closed
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Open UpdateStudentForm as a modal dialog
            UpdateStudentForm updateStudentForm = new UpdateStudentForm();
            updateStudentForm.ShowDialog();

            // Show the main form again when UpdateStudentForm is closed
            this.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadStudents(dgvStudents);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create a new instance of AddStudentForm
            AddStudentForm addStudentForm = new AddStudentForm();
            // Show the AddStudentForm as a dialog
            addStudentForm.ShowDialog();
            
            this.Show();
        }

        //this is to open the delete form
        private void btnViewStudents_Click(object sender, EventArgs e)//
        {
            this.Hide();

            // Open the ViewStudentsForm
            ViewStudentsForm viewForm = new ViewStudentsForm();
            viewForm.ShowDialog();
            
            this.Show();
        }
 
       
        // Method to load students from the file and display in DataGridView
        public void LoadStudents(DataGridView dgvStudents)
        {
            // Clear existing rows
            dgvStudents.Rows.Clear();

            try
            {
                // Check if file exists
                if (!File.Exists("students.txt"))
                {
                    MessageBox.Show("No student records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Read each line from the file and add to the DataGridView
                foreach (string line in File.ReadAllLines("students.txt"))
                {
                    // Split the line by commas to get student details
                    string[] studentDetails = line.Split(',');

                    // Ensure the line has the correct format before adding to DataGridView
                    if (studentDetails.Length == 4)
                    {
                        dgvStudents.Rows.Add(studentDetails[0], studentDetails[1], studentDetails[2], studentDetails[3]);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect format in students.txt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
