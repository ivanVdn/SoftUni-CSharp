namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine() ?? string.Empty);

            var result = new Dictionary<string, List<string>>();

            for (var i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();

                if (word == null) continue;
                
                if (!result.ContainsKey(word))
                {
                    result[word] = new List<string>();
                }
                result[word].Add(synonym);
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
