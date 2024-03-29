using System;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            BombNumbers(numbers, bomb);

            Console.WriteLine(string.Join(";", numbers));
            Console.WriteLine(numbers.Sum());
        }

        static void BombNumbers(List<int> numbers, List<int> bomb)
        {
            while (numbers.Contains(bomb[0]))
            {
                var bombIndex = numbers.IndexOf(bomb[0]);
                var leftIndex = Math.Max(0, bombIndex - bomb[1]);
                var rightIndex = Math.Min(numbers.Count - 1,bombIndex + bomb[1]);

                var bombRange = rightIndex - leftIndex + 1;

                numbers.RemoveRange(leftIndex, bombRange);
            }
        }
    }
}
