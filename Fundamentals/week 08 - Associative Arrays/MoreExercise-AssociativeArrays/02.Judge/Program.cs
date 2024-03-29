using System.Drawing;

namespace _02.Judge
{
    internal class Program
    {
        internal static void Main()
        {

            var contests = new Dictionary<string, Dictionary<string, int>>();
            var userPoints = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                var tokens = input.Split(" -> ");

                var username = tokens[0];
                var contest = tokens[1];
                var points = int.Parse(tokens[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = new Dictionary<string, int>();
                }

                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest][username] = points;
                }
                else
                {
                    contests[contest][username] = Math.Max(contests[contest][username], points);
                }

                if (!userPoints.ContainsKey(username))
                {
                    userPoints[username] = points;
                }
                else
                {
                    if (userPoints[username] < points)
                    {
                        userPoints[username] = points;
                    }
                    else
                    {
                        userPoints[username] += points;
                    }
                }
            }

            foreach (var kvp in contests)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");

                var position = 1;
                foreach (var participant in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{position}. {participant.Key} <::> {participant.Value}");
                    position++;
                }
            }

            Console.WriteLine("Individual standings:");

            var userPosition = 1;
            foreach (var user in userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{userPosition}. {user.Key} -> {user.Value}");
                userPosition++;
            }
        }
    }
}


