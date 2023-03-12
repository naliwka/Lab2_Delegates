using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lab_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            // Read list of employees from file
            using (StreamReader reader = new StreamReader("employee.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(' ');
                    employees.Add(new Employee { Name = parts[0], Salary = int.Parse(parts[1])});
                } 
            }
            // Sort employees by their salary
            List<Employee> sortedEmployees = employees.OrderBy(e => e.Salary).ToList();

            foreach (Employee employee in sortedEmployees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Salary}");
            }
        }
    }
}
