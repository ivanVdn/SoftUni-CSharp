namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var inputNumbers = Console.ReadLine()?
                .Split()
                .Select(double.Parse)
                .ToArray();

            var numbers = new SortedDictionary<double, int>();
            
            foreach (var number in inputNumbers)
            {
                var currentNumber = number;
                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(number, 0);
                }
                numbers[currentNumber]++;
            }

            foreach (var kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
