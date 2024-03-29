namespace _05.Orders
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var typeOfProduct = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var sum = CalculateSum(typeOfProduct, quantity);

            Console.WriteLine($"{sum:f2}");

        }

        private static double CalculateSum(string? typeOfProduct, int quantity)
        {
            var sum = typeOfProduct switch
            {
                "coffee" => quantity * 1.5,
                "water" => quantity * 1.0,
                "coke" => quantity * 1.4,
                "snacks" => quantity * 2.0,
                _ => 0
            };
            return sum;
        }
    }
}
