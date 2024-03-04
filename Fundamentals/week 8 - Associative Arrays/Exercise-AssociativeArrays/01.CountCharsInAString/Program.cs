namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var incomingString = Console.ReadLine()
                .Replace(" ", string.Empty);
            
            var occurrence = new Dictionary<char,int>();

            foreach (var s in incomingString)
            {
                occurrence.TryAdd(s, 0);
                occurrence[s]++;
            }

            foreach (var (key, value) in occurrence)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
