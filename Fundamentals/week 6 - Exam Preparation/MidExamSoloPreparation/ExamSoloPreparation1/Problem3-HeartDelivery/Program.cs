namespace Problem3_HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var neighborhood = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();
            var position = 0;
            var counter = 0;

            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                var cmd = command.Split().ToArray();
                var jump = int.Parse(cmd[1]);


                for (var i = 0; i < neighborhood.Count; i++)
                {
                    var currentPosition = position + jump;

                    if (i != currentPosition) continue;

                    if (neighborhood[currentPosition] == 0)
                    {
                        Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                        continue;
                    }

                    if ((currentPosition) > neighborhood.Count)
                    {
                        currentPosition = 0;
                        Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                        continue;
                    }

                    if (neighborhood[currentPosition] > 0 && currentPosition <= neighborhood.Count)
                    {
                        neighborhood[currentPosition] -= 2;
                        Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                        counter++;
                    }

                    position = currentPosition;
                }
            }
            
                



            Console.WriteLine($"Cupid's last position was {position}.");
            Console.WriteLine($"Cupid has failed {counter} places.");
        }
    }
}
