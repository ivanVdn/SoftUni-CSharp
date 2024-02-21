using System;

namespace Problem3_MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var cmd = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                switch (cmd[0])
                {
                    case "Shoot":
                        var index = int.Parse(cmd[1]);
                        var power = int.Parse(cmd[2]);

                        if (index < 0 || index >= list.Count)
                        {
                            break;
                        }
                        var element = list[index];
                        element -= power;

                        if (element > 0)
                        {
                            list.RemoveAt(index);
                            list.Insert(index, element);
                        }
                        else
                        {
                            list.RemoveAt(index);
                        }
                        break;
                    case "Add":
                        index = int.Parse(cmd[1]);
                        element = int.Parse(cmd[2]);

                        if (index < 0 || index >= list.Count)
                        {
                            Console.WriteLine("Invalid placement!");
                            break;
                        }

                        list.Insert(index, element);
                        break;
                    case "Strike":
                        index = int.Parse(cmd[1]);
                        var radius = int.Parse(cmd[2]);

                        if (((index - radius) >= 0 && (index + radius) <= list.Count - 1))
                        {
                            list.RemoveRange(index, radius);
                            list.RemoveRange(index - radius, radius + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                            break;
                        }
                        break;

                }
            }
            Console.WriteLine(string.Join("|", list));
        }
    }
}
