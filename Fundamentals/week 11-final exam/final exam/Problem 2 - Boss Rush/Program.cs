using System.Text.RegularExpressions;

namespace Problem_2___Boss_Rush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\|(?<name>[A-Z]{4,})\|:\#(?<title>[A-Za-z]+ [A-Za-z]+)\#";
            var numberOfImputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfImputs; i++)
            {
                var input = Console.ReadLine();
                var matches = Regex.Matches(input, pattern);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"{match.Groups["name"]}, The {match.Groups["title"]}\n>> Strength: {match.Groups["name"].Length}\n>> Armor: {match.Groups["title"].Length}");
                    }
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
