﻿namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kiwi orange banana apple
            // pizza cake pasta chips

            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
                .Split()
                .Where(x => x.Length %2 == 0)
                .ToList()));
        }
    }
}
