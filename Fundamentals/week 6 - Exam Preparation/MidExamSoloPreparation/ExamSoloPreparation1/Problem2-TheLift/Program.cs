namespace Problem2_TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var peopleAreWaiting = int.Parse(Console.ReadLine());
            var wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var people = 0;

            for (var i = 0; i < wagons.Length; i++)
            {
                if (peopleAreWaiting >= 4)
                {
                    peopleAreWaiting += wagons[i];
                    wagons[i] = 4;
                    peopleAreWaiting -= 4;
                }
                else
                {
                    peopleAreWaiting += wagons[i];
                    wagons[i] = peopleAreWaiting;
                    peopleAreWaiting = 0;
                }
            }

            if (peopleAreWaiting == 0 && wagons[wagons.Length - 1] < 4)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (peopleAreWaiting > 0 && wagons[wagons.Length - 1] == 4)
            {
                Console.WriteLine($"There isn't enough space! {peopleAreWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (peopleAreWaiting == 0 && wagons[wagons.Length - 1] == 4)
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
