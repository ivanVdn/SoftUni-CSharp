namespace Problem2_TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var initialLoot = input
                .Split("|")
                .ToList();
            var isPrinted = false;
            string command;
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                var cmd = command
                    .Split(" ")
                    .ToList();

                switch (cmd[0])
                {
                    case "Loot":
                        for (var i = 1; i < cmd.Count; i++)
                        {
                            if (!initialLoot.Contains(cmd[i]))
                            {
                                initialLoot.Insert(0, cmd[i]);
                            }
                        }
                        break;
                    case "Drop":
                        if (int.Parse(cmd[1]) < 0 || int.Parse(cmd[1]) > initialLoot.Count - 1) { break; }
                        var item = initialLoot[int.Parse(cmd[1])];
                        initialLoot.RemoveAt(int.Parse(cmd[1]));
                        initialLoot.Add(item);
                        break;
                    case "Steal":
                        var count = int.Parse(cmd[1]);
                        List<string> remuved = new List<string>();

                        for (var i = 0; i < count; i++)
                        {
                            if (initialLoot.Count != 0)
                            {
                                var lastIndex = initialLoot.Count - 1;
                                var renuvedItem = initialLoot[lastIndex];
                                initialLoot.RemoveAt(lastIndex);
                                remuved.Add(renuvedItem);
                            }
                        }

                        if (remuved.Count != 0)
                        {
                            remuved.Reverse();
                            Console.WriteLine(string.Join(", ", remuved));
                        }

                        
                        //var firstPosition = initialLoot.Count - count;
                        //var lastPosition = initialLoot.Count;
                        //var output = "";

                        //if (count > initialLoot.Count)
                        //{
                        //    count = initialLoot.Count;
                        //}

                        //for (var i = firstPosition; i < lastPosition; i++)
                        //{
                        //    output += (initialLoot[i] + ", ");
                        //}
                        //initialLoot.RemoveRange(firstPosition, count);
                        //var trim = output.Trim(',',' ');
                        //Console.WriteLine(string.Join("", trim));

                        break;
                }

                if (initialLoot.Count == 0)
                {
                    Console.WriteLine("Failed treasure hunt.");
                    isPrinted = true;
                    break;
                }
            }

            double allSum = 0;
            var n = 0;
            foreach (var item in initialLoot)
            {
                double sum = item.Length;
                allSum += sum;
                n++;
            }
            allSum /= n;
            if (!isPrinted)
            {
                Console.WriteLine($"Average treasure gain: {allSum:f2} pirate credits.");
            }

        }
    }
}
