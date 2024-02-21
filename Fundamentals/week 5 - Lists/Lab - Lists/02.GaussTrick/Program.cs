namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nummberList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();


            int current = 0;
            for (int i = 0; i < nummberList.Count / 2; i++)
            {
                current = nummberList[i] + nummberList[nummberList.Count - i - 1];
                newList.Add(current);
            }

            if (nummberList.Count % 2 != 0)
            {
                newList.Add(nummberList[nummberList.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", newList));

        }
    }
}
