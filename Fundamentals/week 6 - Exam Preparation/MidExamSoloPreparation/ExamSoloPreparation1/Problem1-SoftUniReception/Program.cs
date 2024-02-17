namespace Problem1_SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employOneStudents = int.Parse(Console.ReadLine());
            var employTwoStudents = int.Parse(Console.ReadLine());
            var employThreeStudents = int.Parse(Console.ReadLine());
            var incomingStudents = int.Parse(Console.ReadLine());
            
            var sumOfStudentPerHour = employOneStudents + employTwoStudents + employThreeStudents;

            var time = 1;
            
                while (incomingStudents > 0)
                {
                    if (time % 4 == 0 && time != 0)
                    {
                        time += 1;
                        continue;
                    }
                    incomingStudents -= sumOfStudentPerHour;
                    time++;
                }

            Console.WriteLine($"Time needed: {time - 1}h.");
        }
    }
}
