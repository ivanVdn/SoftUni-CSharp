using System.ComponentModel.DataAnnotations;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main()
        {
            var resources = new Dictionary<string, long>();

            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop") break;

                var quantity = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;
            }

            foreach (var (key, value) in resources)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
