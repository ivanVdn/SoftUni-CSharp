using System.Diagnostics.Metrics;
using System.Reflection;

namespace Problem3_HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var neighborhood = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();
            var position = 0;

            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                var cmd = command.Split().ToArray();
                var jump = int.Parse(cmd[1]);
                position += jump;

                if (position > neighborhood.Count - 1)
                {
                    position = 0;
                }

                if (neighborhood[position] <= 0)
                {
                    Console.WriteLine($"Place {position} already had Valentine's day.");
                }
                else
                {
                    neighborhood[position] -= 2;
                    if (neighborhood[position] == 0)
                    {
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                }

            }

            Console.WriteLine($"Cupid's last position was {position}.");
            var count = neighborhood.Count(neighbor => neighbor != 0);

            Console.WriteLine(count != 0 ? $"Cupid has failed {count} places." : "Mission was successful.");
        }
    }
}

