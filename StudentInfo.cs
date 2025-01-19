using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MailApp.Models; 


namespace MailApp
{
    public partial class StudentInfo : Form
    {
        private readonly StudentDataManager studentManager = new StudentDataManager();

        public StudentInfo()
        {
            InitializeComponent();
            StudentsDataGridView.MultiSelect = true;
        }

        // Save student data
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentID = StudentIDTextBox.Text,
                Name = NameTextBox.Text,
                CellPhoneNumber = CellPhoneNumberTextBox.Text,
                CellPhoneCarrier = CellPhoneCarrierTextBox.Text,
                EmailAddress = EmailAddressTextBox.Text
            };

            // Load existing data, add new student, and save
            var students = studentManager.RestoreStudentData();
            students.Add(student);
            studentManager.SaveStudentData(students);

            MessageBox.Show("Student data saved.");
            ClearInputFields();
        }

        // Restore student data and update DataGridView
        private void RestoreButton_Click(object sender, EventArgs e)
        {
            var students = studentManager.RestoreStudentData();
            UpdateDataGridView(students);
            ClearInputFields();
        }

        // Delete selected student(s)
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var students = studentManager.RestoreStudentData();

            if (StudentsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one student to delete.");
                return;
            }

            foreach (DataGridViewRow selectedRow in StudentsDataGridView.SelectedRows)
            {
                if (selectedRow.DataBoundItem is Student selectedStudent)
                {
                    students.RemoveAll(student => student.StudentID == selectedStudent.StudentID);
                }
            }

            studentManager.SaveStudentData(students);
            UpdateDataGridView(students);

            MessageBox.Show("Selected student(s) deleted successfully.");
        }

       

        // Helper method to clear input fields
        private void ClearInputFields()
        {
            StudentIDTextBox.Clear();
            NameTextBox.Clear();
            CellPhoneNumberTextBox.Clear();
            CellPhoneCarrierTextBox.Clear();
            EmailAddressTextBox.Clear();
        }

        // Helper method to update the DataGridView
        private void UpdateDataGridView(List<Student> students)
        {
            StudentsDataGridView.DataSource = null;
            StudentsDataGridView.DataSource = students;
        }

        private void SendButton_Click(object sender, EventArgs e)
                    {
                var selectedStudents = StudentsDataGridView.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(row => row.DataBoundItem is Student)
                    .Select(row => (Student)row.DataBoundItem)
                    .ToList();

                if (selectedStudents.Any())
                {
                    using (var form1 = new Form1(selectedStudents))  // Pass the selected students to Form1
                    {
                        form1.ShowDialog(); // Open Form1 for email/SMS sending
                    }
                }
                else
                {
                    MessageBox.Show("Please select at least one student to send an email or SMS.");
                }
            }

        
    }
}

