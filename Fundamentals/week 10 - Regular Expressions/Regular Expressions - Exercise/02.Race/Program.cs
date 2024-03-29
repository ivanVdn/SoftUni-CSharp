using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var racers = Console.ReadLine()?
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, _ => 0);

            var pattern = @"[A-Za-z0-9]";

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of race") break;
                    
                if (input == null) return;
                var matches = Regex.Matches(input, pattern);

                var name = string.Empty;
                var kilometers = 0;

                for (var i = 0; i < matches.Count; i++)
                {
                    var a = matches[i].Value[0];
                    if (char.IsDigit(a))
                    {
                        kilometers += int.Parse(a.ToString());
                    }
                    else
                    {
                        name += a;
                    }
                }
                if (racers != null && racers.ContainsKey(name))
                {
                    racers[name] += kilometers;
                }
            }

            if (racers == null) return;
            var orderedRacers = racers.OrderByDescending(x => x.Value);

            Console.WriteLine($"1st place: {orderedRacers.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {orderedRacers.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {orderedRacers.ElementAt(2).Key}");

        }
    }
}