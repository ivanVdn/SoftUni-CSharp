using System.Text;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(([+359]{4})(?<s>[ |-])[2](\k<s>)[\d]{3}(\k<s>)[\d]{4})\b";
            var input = Console.ReadLine();

            var output = new StringBuilder();

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                output.Append($"{match}, ");
            }
            Console.WriteLine(output.ToString().Trim(',', ' '));
        }
    }
}
