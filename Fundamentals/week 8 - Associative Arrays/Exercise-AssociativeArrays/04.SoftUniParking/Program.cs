namespace _04.SoftUniParking
{

    internal class Program
    {
        static void Main()
        {
            var registeredCars = new Dictionary<string, string>();
            var n = int.Parse(Console.ReadLine() ?? string.Empty);

            for (var i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine()?.Split().ToList();
                string username;
                switch (cmd[0])
                {
                    case "register":
                        username = cmd[1];
                        var plateNumber = cmd[2];
                        if (!registeredCars.ContainsKey(username) || !registeredCars.ContainsValue(plateNumber))
                        {
                            registeredCars.Add(username,plateNumber);
                            Console.WriteLine($"{username} registered {plateNumber} successfully");
                        }
                        else if (registeredCars.Values.Contains(plateNumber))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }

                        break;
                    case "unregister":
                        username = cmd[1];
                        if (registeredCars.ContainsKey(username))
                        {
                            registeredCars.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        break;
                }
            }

            foreach (var (key, value) in registeredCars)
            {
                Console.WriteLine($"{key} => {value}");
            }
        }
    }
}
