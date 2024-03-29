namespace _05.Students2._0
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
                    .Split(" ")
                    .ToList();
                var firstName = input?[0];
                var lastName = input?[1];
                var age = int.Parse(input?[2] ?? string.Empty);
                var homeTown = input?[3];

                var isExist = IsExist(students, firstName, lastName, age, homeTown);

                if (isExist)
                {
                    students.Add(new Student
                    {
                        FirstName = input?[0],
                        LastName = input?[1],
                        Age = int.Parse(input?[2] ?? string.Empty),
                        HomeTown = input?[3]
                    });
                }
            }

            var city = Console.ReadLine();

            foreach (var student in students.Where(student => student.HomeTown == city))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        private static bool IsExist(List<Student> students, string? firstName, string? lastName, int age, string? homeTown)
        {
            var isExist = true;

            foreach (var s in students.Where(s => s.FirstName == firstName && s.LastName == lastName))
            {
                isExist = false;
                s.Age = age;
                s.HomeTown = homeTown;
                continue;
            }

            return isExist;
        }
    }

    public class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? HomeTown { get; set; }

    }

}
