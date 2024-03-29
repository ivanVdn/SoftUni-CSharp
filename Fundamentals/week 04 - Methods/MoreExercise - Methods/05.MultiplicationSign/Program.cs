using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace _05.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            WriteResult(num1, num2, num3);
        }

        static int IsItZero(int num1, int num2, int num3)
        {
            int zero = 0;
            if (num1 == 0)
            {
                zero++;
            }

            if (num2 == 0)
            {
                zero++;
            }

            if (num3 == 0)
            {
                zero++;
            }

            return zero;
        }

        static int IsItNegative(int num1, int num2, int num3)
        {
            int negative = 0;
            if (num1 < 0)
            {
                negative++;
            }

            if (num2 < 0)
            {
                negative++;
            }

            if (num3 < 0)
            {
                negative++;
            }

            return negative;
        }
        
        static void WriteResult(int num1, int num2, int num3)
        {
            if (IsItZero(num1, num2, num3) != 0)
            {
                Console.WriteLine("zero");
            }
            else if (IsItNegative(num1, num2, num3) % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
