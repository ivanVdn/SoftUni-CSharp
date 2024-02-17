using System.Reflection.Metadata.Ecma335;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            DivideFactorials(firstNumber, secondNumber, out var result);
        }
        
        static void DivideFactorials(int firstNumber, int secondNumber, out double result)
        {
            FirstNumberFactorial(firstNumber, out double sum1);
            SecondNumberFactorial(secondNumber, out double sum2);

            result = sum1 / sum2;
            Console.WriteLine($"{result:f2}");
        }
        
        static double FirstNumberFactorial(double firstNumber, out double sum1)
        {
            sum1 = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                sum1 = sum1 * i;
            }

            return sum1;
        }

        static double SecondNumberFactorial(double secondNumber, out double sum2)
        {
            sum2 = 1;
            for (int i = 1; i <= secondNumber; i++)
            {
                sum2 = sum2 * i;
            }

            return sum2;
        }
    }
}
