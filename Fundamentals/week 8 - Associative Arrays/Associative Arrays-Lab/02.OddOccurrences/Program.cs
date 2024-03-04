namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()?
                .Split()
                .Select(x => x.ToLower())
                .ToArray();

            var result = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }

                result[item]++;
            }

            foreach (var kvp in result.Where(kvp => kvp.Value % 2 != 0))
            {
                Console.Write($"{kvp.Key} ");
            }
        }
    }
}
