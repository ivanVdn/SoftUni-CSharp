using System.Dynamic;

namespace _04.Students
{
    internal class Program
    {
        private static void Main()
        {
            var students = new List<Student>() { };
            string? command;
            while ((command = Console.ReadLine()) != "end")
            {
                var input = command?
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (input == null) continue;
                var student = new Student
                {
                    FirstName = input?[0],
                    LastName = input?[1],
                    Age = int.Parse(input?[2] ?? string.Empty),
                    HomeTown = input?[3]
                };
                students.Add(student);
            }

            var city = Console.ReadLine();

            foreach (var student in students.Where(student => student.HomeTown == city))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
    
    public class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? HomeTown { get; set; }
        public int Grades { get; set; }
    }

}
