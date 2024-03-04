using System.Numerics;

namespace _02.BigFactorial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1 * 2 * 3 * 4 * 5
            var input = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (var i = 2; i <= input; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
