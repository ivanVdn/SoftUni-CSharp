using System.ComponentModel;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line – string – "add"(+), "multiply"(*), "subtract"(-), "divide"(/).
            //•	On the second line – a number.
            //•	On the third line – another number.

            string operation = Console.ReadLine();

            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

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

        static void Add(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }

        static void Multiply(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        static void Subtract(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
        
        static void Divide(double firstNumber, double secondNumber)
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
