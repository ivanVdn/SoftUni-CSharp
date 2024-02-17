namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int[] roundetNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundetNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundetNumbers[i]}");
            }
        }
    }
}
