namespace _05.Courses
{
    internal class Program
    {
        static void Main()
        {
            var students = new List<string>();
            var courses = new Dictionary<string, List<string>>();
            string? command;
            while ((command = Console.ReadLine()) != "end")
            {
                var cmd = command?
                    .Split(" : ")
                    .ToList();
                var courseName = cmd?[0];
                var studentName = cmd?[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);

            }

            foreach (var (key , value) in courses)
            {
                Console.WriteLine($"{key}: {value.Count}");
                foreach (var v in value)
                {
                    Console.WriteLine($"-- {v}");
                }
            }

        }
    }
}
