namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 British Pound = 1.31 Dollars
            decimal BP = decimal.Parse(Console.ReadLine());
            decimal USD = BP * 1.31m;
            Console.WriteLine($"{USD:f3}");
        }
    }
}
