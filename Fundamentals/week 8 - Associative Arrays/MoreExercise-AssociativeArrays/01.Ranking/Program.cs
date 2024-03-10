using System;

namespace _01.Ranking
{
    internal class Program
    {
        internal static void Main()
        {
            var listOfContests = new Dictionary<string?, string?>();
            var students = new Dictionary<string?, Dictionary<string?, int>>();

            string? command;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                var cmd = command?
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var contestName = cmd?[0];
                var password = cmd?[1];

                listOfContests.Add(contestName, password);
            }

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                var cmd = command?
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var contestName = cmd?[0];
                var password = cmd?[1];
                var username = cmd?[2];
                var points = int.Parse(cmd?[3]);

                if (!listOfContests.ContainsKey(contestName) || listOfContests[contestName] != password) continue;
                if (!students.ContainsKey(username))
                {
                    students[username] = new Dictionary<string?, int>();
                }

                if (!students[username].ContainsKey(contestName))
                {
                    students[username][contestName] = 0;
                }

                if (points > students[username][contestName])
                {
                    students[username][contestName] = points;
                }
            }

            var totalPoints = new Dictionary<string?, int>();
            foreach (var user in students)
            {
                totalPoints[user.Key] = user.Value.Values.Sum();
            }

            var bestCandidate = totalPoints.MaxBy(x => x.Value).Key;
            var bestCandidatePoints = totalPoints.MaxBy(x => x.Value).Value;

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidatePoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var (key, value) in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {key} -> {value}");
                }
            }

        }
    }
}
