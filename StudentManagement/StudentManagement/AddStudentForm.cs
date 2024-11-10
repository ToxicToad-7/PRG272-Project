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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get values from input fields
            string id = txtStudentID.Text;
            string name = txtName.Text;
            string ageText = txtAge.Text;
            string course = txtCourse.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(ageText) || string.IsNullOrWhiteSpace(course) ||
                !int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Please fill out all fields correctly. Age must be a number.");
                return;
            }
            // Check for duplicate ID
            if (File.Exists("students.txt"))
            {
                var existingRecords = File.ReadAllLines("students.txt");
                if (existingRecords.Any(line => line.StartsWith(id + ",")))
                {
                    MessageBox.Show("A student with this ID already exists.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Save student details to a file
            string studentRecord = $"{id},{name},{age},{course}";
            File.AppendAllText("students.txt", studentRecord + Environment.NewLine);

            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields(); // Clear fields after saving
        }

        // Clear input fields after saving
        private void ClearFields()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCourse.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void btnAExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

     
