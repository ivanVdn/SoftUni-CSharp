using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            var total = 0.0;

            Console.WriteLine("Bought furniture:");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Purchase")
                    break;

                var matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    total += double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value);
                    Console.WriteLine(match.Groups["name"].Value);
                }
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}