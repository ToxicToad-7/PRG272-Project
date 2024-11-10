Code Documentation for StudentManagementSystem
=====================================================================================================================================================================
Form1.cs
=====================================================================================================================================================================
1. Form1.cs (Main functionality of the Student Management System)
This file contains the main logic for handling student data (adding, updating, deleting) and displaying it in a DataGridView. It also handles the generation of a summary report.

private string studentFilePath & private string summaryFilePath:
These store the file paths for the student data (students.txt) and the summary report (summary.txt). The file paths are hard-coded and point to specific locations on the user’s machine.

public Form1() Constructor:
This is the constructor where the Form1_Load event handler is registered to load the student data when the form is loaded.

private void Form1_Load(object sender, EventArgs e) Method:
This method is triggered when the form is loaded. It calls LoadStudentData to load the student data from the students.txt file into the DataGridView (dgvStudents).

private bool ValidateFields() Method:
This method ensures that all the required fields (Student ID, Name, Age, and Course) are filled before any action is performed. It returns false if any field is empty and displays an error message.

private void LoadStudentData() Method:
This method reads the student data from the students.txt file (if it exists), splits each line by commas, and converts the data into a list of anonymous objects (with properties for ID, Name, Age, and Course). This data is then bound to the dgvStudents DataGridView.

private void btnAdd_Click(object sender, EventArgs e) Method:
This method is triggered when the "Add" button is clicked. It validates the input fields, appends the student data (Student ID, Name, Age, and Course) to the students.txt file, and then reloads the data into the DataGridView. It also clears the input fields and applies styling to the grid.

private void btnUpdate_Click(object sender, EventArgs e) Method:
This method is triggered when the "Update" button is clicked. It validates the input fields and updates the student’s information in the students.txt file based on the Student ID. If the student is found, the file is updated, and the DataGridView is refreshed. If not, an error message is shown.

private void btnDelete_Click(object sender, EventArgs e) Method:
This method is triggered when the "Delete" button is clicked. It deletes the student’s record based on the Student ID. The student record is removed from the students.txt file, and the DataGridView is refreshed. If the Student ID is not found, an error message is displayed.

private void btnGenerateReport_Click(object sender, EventArgs e) Method:
This method is triggered when the "Generate Report" button is clicked. It calculates the total number of students and the average age from the students.txt file and writes this information to the summary.txt file. The summary is also displayed in a new DataGridView (dgvSummary).

private void ClearFieldsAndHighlightGrid() Method:
This method clears all input fields (txtStudentID, txtName, txtAge, txtCourse) and applies a green border style and grid color to the dgvStudents DataGridView.

=====================================================================================================================================================================
Form1.Designer.cs
=====================================================================================================================================================================
2. Form1.Designer.cs (Form UI Layout and Controls Setup)
This file contains the setup for the user interface, including the initialization and properties of various controls such as text boxes, buttons, and DataGridViews.

Controls Initialization:
This section initializes all the necessary UI controls:

txtStudentID, txtName, txtAge, txtCourse: Textboxes for the user to input student data.
dgvStudents, dgvSummary: DataGridViews to display student data and summary report respectively.
Buttons like btnAdd, btnUpdate, btnDelete, btnGenerateReport to trigger various actions like adding, updating, deleting, and generating reports.
Control Styling:
The UI controls (TextBoxes, DataGridViews, and Buttons) are styled with specific colors like LightYellow, LightGreen, LightBlue, and LightCoral for a visually appealing interface.

Layout:
The controls are positioned using Location properties, specifying where each control should appear on the form. The Size properties define the size of each control, and TabIndex specifies the order of tabbing between controls.

=====================================================================================================================================================================
Program.cs
=====================================================================================================================================================================
3. Program.cs (Application Entry Point)
This file contains the entry point for the application. It initializes the application and runs the Form1 form.

[STAThread] Attribute:
Indicates that the application will use a single-threaded apartment model, which is required for Windows Forms applications.

Application.Run(new Form1()):