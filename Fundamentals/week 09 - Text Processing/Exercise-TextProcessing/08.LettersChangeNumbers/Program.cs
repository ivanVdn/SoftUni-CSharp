using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        internal static void Main()
        {
            var data = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = 0.0;

            foreach (var item in data)
            {
                var prefix = item[0];
                var suffix = item[^1];

                var score = double.Parse(item.Substring(1, item.Length - 2));

                if (char.IsUpper(prefix)) 
                { score /= prefix - 'A' + 1; }
                else 
                { score *= prefix - 'a' + 1; }

                if (char.IsUpper(suffix)) 
                { score -= suffix - 'A' + 1; }
                else 
                { score += suffix - 'a' + 1; }

                result += score;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
