using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add students to the list
            List<Student> students = new List<Student>()
            {
                new Student { Name = "Samantha", Grade = 66 },
                new Student { Name = "Linda", Grade = 98 },
                new Student { Name = "John", Grade = 75 },
                new Student { Name = "Kate", Grade = 91 },
                new Student { Name = "Tom", Grade = 90 }
            };
            // Filter out students with a score greater than 85
            List<Student> filteredStudents = students.Where(s => s.Grade > 85).ToList();
            // Display the list of filtered students
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }
        }
    }
}
