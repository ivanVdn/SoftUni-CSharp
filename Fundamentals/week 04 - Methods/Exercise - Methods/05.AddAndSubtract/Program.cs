namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            SumOfFirstAndSecondNumber(firstNumber, secondNumber, thirdNumber);


        }

        static void SumOfFirstAndSecondNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int result = firstNumber + secondNumber;


            SubtractThirdNumber(thirdNumber, result);
        }

        private static void SubtractThirdNumber(int thirdNumber, int result)
        {
            result -= thirdNumber;
            Console.WriteLine(result);
        }
    }
}
