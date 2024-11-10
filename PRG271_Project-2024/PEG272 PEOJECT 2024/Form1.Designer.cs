namespace StudentManagementSystem
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvSummary; // New grid for summary report
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnGenerateReport;

        private void InitializeComponent()
        {
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvSummary = new System.Windows.Forms.DataGridView(); // Summary grid initialization
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();

            // Initialize DataGridView properties
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();

            // Customize Form color
            this.BackColor = System.Drawing.Color.LightBlue;

            // Customize TextBox colors
            this.txtStudentID.BackColor = System.Drawing.Color.LightYellow;
            this.txtName.BackColor = System.Drawing.Color.LightYellow;
            this.txtAge.BackColor = System.Drawing.Color.LightYellow;
            this.txtCourse.BackColor = System.Drawing.Color.LightYellow;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvSummary.BackgroundColor = System.Drawing.Color.LightCoral;

            // TextBox for Student ID
            this.txtStudentID.Location = new System.Drawing.Point(30, 30);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.PlaceholderText = "Enter Student ID";

            // TextBox for Name
            this.txtName.Location = new System.Drawing.Point(30, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.PlaceholderText = "Enter Name";

            // TextBox for Age
            this.txtAge.Location = new System.Drawing.Point(30, 90);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 2;
            this.txtAge.PlaceholderText = "Enter Age";

            // TextBox for Course
            this.txtCourse.Location = new System.Drawing.Point(30, 120);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 3;
            this.txtCourse.PlaceholderText = "Enter Course";

            // DataGridView for students
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(150, 30);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(445, 200);
            this.dgvStudents.TabIndex = 4;

            // DataGridView for summary
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(150, 250); // Position below the main grid
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.Size = new System.Drawing.Size(445, 100);
            this.dgvSummary.TabIndex = 8;

            // Add Button
            this.btnAdd.Location = new System.Drawing.Point(30, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;

            // Update Button
            this.btnUpdate.Location = new System.Drawing.Point(30, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;

            // Delete Button
            this.btnDelete.Location = new System.Drawing.Point(30, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;

            // Generate Report Button
            this.btnGenerateReport.Location = new System.Drawing.Point(30, 250);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateReport.TabIndex = 8;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            this.btnGenerateReport.BackColor = System.Drawing.Color.LightSkyBlue;

            // Set form properties
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.dgvSummary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "Form1";
            this.Text = "Student Management System";

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
