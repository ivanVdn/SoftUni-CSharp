namespace _04.PrintingTriangle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (var i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }

            for (var i = number - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int start, int end)
        {
            for (var i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
