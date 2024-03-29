using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        internal static void Main()
        {
            var pattern = @"\%(?<customer>[A-Z][a-z]+)\%(?:[^|$%.])*\<(?<product>\w+)\>(?:[^|$%.])*\|(?<count>\d+)\|(?:[^|$%.])*?(?<price>\d+\.\d+|\d+)\$";
            var total = 0.0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of shift" ) break;
                if (input == null) continue;
                var matches = Regex.Matches(input, pattern);
                for (var i = 0; i < matches.Count; i++)
                {
                    var match = matches[i];
                    total += double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["count"].Value);
                    Console.WriteLine(
                        $"{match.Groups["customer"].Value}: {match.Groups["product"].Value} - {double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["count"].Value):f2}");
                }
            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
