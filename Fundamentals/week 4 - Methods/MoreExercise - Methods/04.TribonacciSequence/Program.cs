namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 1;
            int third = 2;

            int num = int.Parse(Console.ReadLine());

            PrintFirstTriElements(num, first, second, third);

            Console.WriteLine();
        }

        private static void PrintFirstTriElements(int num, int first, int second, int third)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(first + " ");

                int next = first + second + third;

                first = second;
                second = third;
                third = next;
            }
        }
    }
}
