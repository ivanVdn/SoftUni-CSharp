﻿namespace _03.Numbers
{
    internal class Program
    {
        private static void Main()
        {
            var numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var average = numbersList.Average();
            var biggerList = numbersList.Where(t => t > average).ToList();
            biggerList.Sort();
            biggerList.Reverse();
            if (biggerList.Count > 5)
            {
                biggerList.RemoveRange(5, (biggerList.Count - 5));
            }

            if (biggerList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", biggerList));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
