namespace _05.LongestIncreasingSubsequence_LIS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startingList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            var foundList = new List<int>();

            int prevuNumber = 0;
            int nextuNumber = 0;

            for (var i = 1; i < startingList.Count; i++)
            {
                prevuNumber = startingList[i-1];
                nextuNumber = startingList[i];
                if ()
            }
        }
    }
}
