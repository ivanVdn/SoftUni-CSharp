using System.Collections.Generic;
using System.Diagnostics;

namespace _04.Students
{


    internal class Student
    {
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public double Grade { get; set; }

        public Student(string? firstName, string? secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string GetString()
        {
            return $"{FirstName} {SecondName}: {Grade:f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>();

            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var studentInfo = Console.ReadLine()?
                    .Split()
                    .ToList();
                

                students.Add(new Student(studentInfo?[0], studentInfo?[1], double.Parse(studentInfo?[2])));
            }

            var orderedStudents = students.OrderByDescending(s => s.Grade);

            foreach (var s in orderedStudents)
            {
                Console.WriteLine(s.GetString());
            }
        }
    }

}
