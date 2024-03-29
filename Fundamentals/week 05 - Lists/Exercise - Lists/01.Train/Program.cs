namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wagonsList = Console.ReadLine()?
                .Split()
                .Select(int.Parse)
                .ToList();

            var wagonCapacity = int.Parse(Console.ReadLine()!);

            string? input;
            while ((input = Console.ReadLine()) != "end")
            {
                string?[]? command = input?.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if ((command?[0] == "Add" && int.Parse(command[1]) <= wagonCapacity))
                {
                    wagonsList?.Add(int.Parse(command[1]));
                }
                else if (int.Parse(command?[0]) <= wagonCapacity)
                {
                    for (var i = 0; i < wagonsList.Count; i++)
                    {
                        if (wagonCapacity - wagonsList[i] >= int.Parse(command?[0]))
                        {
                            wagonsList[i] += int.Parse(command?[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagonsList));
        }
    }
}
