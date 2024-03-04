namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name,new List<double>());
                }
                students[name].Add(grade);
            }

            foreach (var (key, value) in students)
            {
                if (value.Average() >= 4.5)
                {
                    Console.WriteLine($"{key} -> {value.Average():f2}");
                }
            }
        }
    }
}
