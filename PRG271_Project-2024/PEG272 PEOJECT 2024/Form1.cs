using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        private string studentFilePath = @"C:\Users\kathl\OneDrive\Documents\PRG272 - 2024\PROJECT\PEG272 PEOJECT 2024\students.txt";
        private string summaryFilePath = @"C:\Users\kathl\OneDrive\Documents\PRG272 - 2024\PROJECT\PEG272 PEOJECT 2024\summary.txt";

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return false;
            }
            return true;
        }

        private void LoadStudentData()
        {
            if (File.Exists(studentFilePath))
            {
                var lines = File.ReadAllLines(studentFilePath);
                var students = lines.Select(line => line.Split(',')).Select(fields => new
                {
                    ID = fields[0],
                    Name = fields[1],
                    Age = fields[2],
                    Course = fields[3]
                }).ToList();

                dgvStudents.DataSource = students;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            var studentData = $"{txtStudentID.Text},{txtName.Text},{txtAge.Text},{txtCourse.Text}";
            File.AppendAllText(studentFilePath, studentData + Environment.NewLine);
            MessageBox.Show("Student added successfully!");
            LoadStudentData();
            ClearFieldsAndHighlightGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            var lines = File.ReadAllLines(studentFilePath).ToList();
            bool studentFound = false;

            for (int i = 0; i < lines.Count; i++)
            {
                var fields = lines[i].Split(',');
                if (fields[0] == txtStudentID.Text)
                {
                    lines[i] = $"{txtStudentID.Text},{txtName.Text},{txtAge.Text},{txtCourse.Text}";
                    studentFound = true;
                    break;
                }
            }

            if (studentFound)
            {
                File.WriteAllLines(studentFilePath, lines);
                MessageBox.Show("Student updated successfully!");
                LoadStudentData();
                ClearFieldsAndHighlightGrid();
            }
            else
            {
                MessageBox.Show("Student ID not found.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(studentFilePath).ToList();
            lines = lines.Where(line => line.Split(',')[0] != txtStudentID.Text).ToList();

            if (lines.Count < File.ReadAllLines(studentFilePath).Length)
            {
                File.WriteAllLines(studentFilePath, lines);
                MessageBox.Show("Student deleted successfully!");
                LoadStudentData();
                ClearFieldsAndHighlightGrid();
            }
            else
            {
                MessageBox.Show("Student ID not found.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(studentFilePath);
            int totalStudents = lines.Length;
            double averageAge = lines.Select(line => int.Parse(line.Split(',')[2])).Average();

            string report = $"Total Students: {totalStudents}\nAverage Age: {averageAge:F2}";
            File.WriteAllText(summaryFilePath, report);

            var summaryData = new[]
            {
                new { TotalStudents = totalStudents, AverageAge = averageAge }
            };
            dgvSummary.DataSource = summaryData;

            MessageBox.Show("Summary report generated successfully!");
        }

        private void ClearFieldsAndHighlightGrid()
        {
            txtStudentID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCourse.Clear();
            dgvStudents.BorderStyle = BorderStyle.Fixed3D;
            dgvStudents.GridColor = System.Drawing.Color.Green;
        }
    }
}
