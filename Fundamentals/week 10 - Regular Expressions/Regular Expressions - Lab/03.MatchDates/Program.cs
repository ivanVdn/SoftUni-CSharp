using System.Text.RegularExpressions;
using static System.Text.RegularExpressions.Regex;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<d>[\d]{2})(?<s>[\.\-\/])(?<m>[A-Z][a-z]{2})(\k<s>)(?<y>[\d]{4})";
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["d"]}, Month: {match.Groups["m"]}, Year: {match.Groups["y"]}");
            }
        }
    }
}
