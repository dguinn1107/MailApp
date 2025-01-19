using System;
using System.Collections.Generic;
using System.IO;
using MailApp.Models;

namespace MailApp
{
    internal class StudentDataManager
    {
        private const string FilePath = "students.txt";

        // Method to restore student data from the file
        public List<Student> RestoreStudentData()
        {
            var students = new List<Student>();

            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length == 5)
                    {
                        students.Add(new Student
                        {
                            StudentID = data[0],
                            Name = data[1],
                            CellPhoneNumber = data[2],
                            CellPhoneCarrier = data[3],
                            EmailAddress = data[4]
                        });
                    }
                }
            }

            return students;
        }

        // Method to save student data to the file
        public void SaveStudentData(List<Student> students)
        {
            var lines = new List<string>();
            foreach (var student in students)
            {
                lines.Add($"{student.StudentID},{student.Name},{student.CellPhoneNumber},{student.CellPhoneCarrier},{student.EmailAddress}");
            }

            File.WriteAllLines(FilePath, lines);
        }
    }
}
