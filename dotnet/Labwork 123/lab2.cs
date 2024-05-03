using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public int DepartmentID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}

public class LambdaExp
{
    public static void run2()
    {
        // Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, DepartmentID = 101, Name = "Samip", Address = "Kathmandu" },
            new Student { Id = 2, DepartmentID = 102, Name = "John", Address = "456 Avenue" },
            new Student { Id = 3, DepartmentID = 101, Name = "Bob", Address = "789 Boulevard" },
            // Add more students as needed
        };

        // Filter students by department ID using a lambda expression
        int departmentIDToFilter = 101;
        var filteredStudents = students.Where(s => s.DepartmentID == departmentIDToFilter);

        // Display the filtered students
        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Address: {student.Address}");
        }
    }
}