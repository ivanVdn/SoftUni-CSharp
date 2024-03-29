namespace _02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstPointX = double.Parse(Console.ReadLine());
            double firstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());

            double distance1 = Math.Sqrt(firstPointX * firstPointX + firstPointY * firstPointY);
            double distance2 = Math.Sqrt(secondPointX * secondPointX + secondPointY * secondPointY);

            if (distance1 <= distance2)
            {
                Console.WriteLine($"({firstPointX}, {firstPointY})");
            }
            else
            {
                Console.WriteLine($"({secondPointX}, {secondPointY})");
            }
        }
    }
}
