namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());


            SmalestNumber(number1, number2, number3);
        }

        private static void SmalestNumber(int number1, int number2, int number3)
        {
            int number = int.MaxValue;
            if (number1 <= number2 && number1 <= number3)
            {
                number = number1;
            }
            else if (number2 <= number1 && number2 <= number3)
            {
                number = number2;
            }
            else
            {
                number = number3;
            }

            Console.WriteLine(number);
        }
    }
}
