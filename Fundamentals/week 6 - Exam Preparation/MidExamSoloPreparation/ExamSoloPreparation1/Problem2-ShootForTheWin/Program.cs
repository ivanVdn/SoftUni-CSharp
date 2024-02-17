namespace Problem2_ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            var count = 0;
            var command = " ";
            while ((command = Console.ReadLine()) != "End")
            {
                if (int.Parse(command) < 0 || int.Parse(command) >= inputList.Count) { continue; }
                count++;
                for (var i = 0; i < inputList.Count; i++)
                {
                    var current = 0;

                    if (int.Parse(command) == i)
                    {
                        current = inputList[i];
                        inputList[i] = -1;
                    }

                    for (var j = 0; j < inputList.Count; j++)
                    {
                        if (current < inputList[j] && inputList[j] != -1)
                        {
                            inputList[j] -= current;
                        }
                        else if (current >= inputList[j] && inputList[j] != -1)

                        {
                            inputList[j] += current;
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {count} -> " + string.Join(" ", inputList));
        }
    }
}