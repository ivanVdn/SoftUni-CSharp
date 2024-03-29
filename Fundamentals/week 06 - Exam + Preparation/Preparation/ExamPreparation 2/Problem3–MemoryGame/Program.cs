using System.Data;

namespace Problem3_MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var count = 0;
            var command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                count++;
                var cmd = command.Split().ToList();
                var firstIndex = int.Parse(cmd[0]);
                var secondIndex = int.Parse(cmd[1]);
                if (firstIndex < 0 || secondIndex < 0 || firstIndex >= listOfElements.Count ||
                    secondIndex >= listOfElements.Count || firstIndex == secondIndex)
                {
                    var symbol = $"-{count}a";
                    listOfElements.Insert((listOfElements.Count / 2), symbol);
                    listOfElements.Insert((listOfElements.Count / 2), symbol);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (listOfElements[firstIndex] == listOfElements[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {listOfElements[firstIndex]}!");
                    if (firstIndex > secondIndex)
                    {
                        listOfElements.RemoveAt(firstIndex);
                        listOfElements.RemoveAt(secondIndex);
                    }
                    else
                    {
                        listOfElements.RemoveAt(secondIndex);
                        listOfElements.RemoveAt(firstIndex);
                    }

                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (listOfElements.Count == 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    return;
                }
            }

            Console.WriteLine($"Sorry you lose :( ");
            Console.WriteLine(string.Join(" ", listOfElements));

        }
    }
}
