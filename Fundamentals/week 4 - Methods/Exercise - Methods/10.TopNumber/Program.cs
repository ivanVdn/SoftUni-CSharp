using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            if (IsDivisibleByEight(number) && IsHoldOddDigit(number))
            {
                return true;
            }

            return false;
        }

        static bool IsHoldOddDigit(int number)
        {
            //while (number > 0)
            for (int i = 1;i <= number; i++)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsDivisibleByEight(int number)
        {
            int sumOfDigits = 0;
            string counter = number.ToString();

            for (int i = 0; i < counter.Length; i++)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            } 
            return sumOfDigits % 8 == 0;
        }
    }
}
