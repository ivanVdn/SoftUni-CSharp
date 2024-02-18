namespace Problem1_Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var energy = int.Parse(Console.ReadLine());

            var command = "";
            var count = 0;
            var isTrue = false;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                if (energy < int.Parse(command) || (energy <= 0))
                {
                    isTrue = true;
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    break;
                }

                energy -= int.Parse(command);
                count++;


                if (count % 3 == 0)
                {
                    energy += count;
                }

            }

            if (!isTrue)
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
            }
        }
    }
}

