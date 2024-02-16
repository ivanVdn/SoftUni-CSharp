namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] < 0)
                {
                    numbersList.RemoveAt(i);
                    i = -1;
                }
            }

            numbersList.Reverse();
            if (numbersList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbersList));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
