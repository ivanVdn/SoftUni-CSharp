namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfCities = int.Parse(Console.ReadLine());

            decimal total = 0;
            for (var i = 1; i <= numberOfCities; i++)
            {
                var cityName = Console.ReadLine();
                var income = decimal.Parse(Console.ReadLine());
                var expenses = decimal.Parse(Console.ReadLine());

                               
                if (i % 3 == 0 && i % 5 != 0)
                {
                    expenses *= 1.5m;
                }

                if (i % 5 == 0 )
                {
                    income *= 0.9m;
                }

                var profit = income - expenses;

                Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");
                total += profit;
            }

            Console.WriteLine($"Burger Bus total profit: {total:f2} leva.");
        }
    }
}
