using System.ComponentModel;

namespace _03.Calculations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //•	On the first line – string – "add"(+), "multiply"(*), "subtract"(-), "divide"(/).
            //•	On the second line – a number.
            //•	On the third line – another number.

            var operation = Console.ReadLine();

            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }

        }

        private static void Add(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }

        private static void Multiply(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        private static void Subtract(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }

        private static void Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            else
            {
                Console.WriteLine("ERROR: cannot divide to zero");
            }
        }
    }
}
