namespace Problem2_ArrayModifier
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
            while ((command = Console.ReadLine()) != "end")
            {
                var cmd = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var firstElement = 0;
                var secondElement = 0;
                switch (cmd[0])
                {
                    case "swap":
                        firstElement = list[int.Parse(cmd[1])];
                        secondElement = list[int.Parse(cmd[2])];

                        if (int.Parse(cmd[2]) > int.Parse(cmd[1]))
                        {
                            list.RemoveAt(int.Parse(cmd[2]));
                            list.Insert(int.Parse(cmd[2]), firstElement);
                            list.RemoveAt(int.Parse(cmd[1]));
                            list.Insert(int.Parse(cmd[1]), secondElement);
                        }
                        else
                        {
                            list.RemoveAt(int.Parse(cmd[1]));
                            list.Insert(int.Parse(cmd[1]), secondElement);
                            list.RemoveAt(int.Parse(cmd[2]));
                            list.Insert(int.Parse(cmd[2]), firstElement);
                        }
                        break;
                    case "multiply":
                        firstElement = list[int.Parse(cmd[1])];
                        secondElement = list[int.Parse(cmd[2])];
                        var sum = firstElement * secondElement;
                        list.RemoveAt(int.Parse(cmd[1]));
                        list.Insert(int.Parse(cmd[1]), sum);
                        break;
                    case "decrease":
                        for (var i = 0; i < list.Count; i++)
                        {
                            list[i] = list[i] - 1;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
