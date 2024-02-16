namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program to sum all of the adjacent equal numbers in a list of decimal numbers, starting from left to right.
               •	After two numbers are summed, the result could be equal to some of its neighbors and should be summed as well (see the examples below)
               •	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available)
               */

            List<double> numberList = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            //5 4 2 1 1 4

            for (int i = 0; i < numberList.Count - 1; i++)
            {
                double current = numberList[i];
                double next = numberList[i + 1];

                if (current == next)
                {
                    numberList[i] += next;
                    numberList.Remove(next);
                    i = -1;

                    //break;
                }
            }

            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
