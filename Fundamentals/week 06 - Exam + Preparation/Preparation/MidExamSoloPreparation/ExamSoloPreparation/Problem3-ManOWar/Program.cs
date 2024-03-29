namespace Problem3_ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pirateShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            var warShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            var healthCapacity = int.Parse(Console.ReadLine());


            string command;
            while ((command = Console.ReadLine()) != "Retire")
            {
                var cmd = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                switch (cmd[0])
                {
                    case "Fire":
                        var index = int.Parse(cmd[1]);
                        if (index < 0 || index >= warShip.Count)break;
                        var damage = int.Parse(cmd[2]); 
                        var element = warShip[index];

                        element -= damage;

                        if (element <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                        else
                        {
                            warShip[index] = element;
                        }
                        break;
                    case "Defend":
                        var startIndex = int.Parse(cmd[1]);
                        var endIndex = int.Parse(cmd[2]);


                        if (startIndex < 0 || startIndex > pirateShip.Count - 1 || endIndex < 0 || endIndex > pirateShip.Count - 1) break;
                        damage = int.Parse(cmd[3]);

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Repair":
                        index = int.Parse(cmd[1]);
                        if (index < 0 || index >= pirateShip.Count) break;
                        var health = int.Parse(cmd[2]);
                        element = pirateShip[index];


                        if (element <= healthCapacity)
                        {
                            element += health;
                            if (element > healthCapacity)
                            {
                                element = healthCapacity;
                            }
                        }
                        pirateShip[index] = element;
                        break;
                    case "Status":
                        var count = 0;
                        var minHealth = healthCapacity * 0.2;

                        foreach (var section in pirateShip)
                        {
                            if (section < minHealth)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"{count} sections need repair.");
                        break;
                }
            }

            var pirateShipSum =  pirateShip.Sum();
            var warshipSum =  warShip.Sum();

            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warshipSum}");

        }
    }
}