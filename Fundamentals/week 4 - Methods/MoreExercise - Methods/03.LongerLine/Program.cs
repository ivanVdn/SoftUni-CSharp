using System;

namespace _03.LongerLine
{

    class Program
    {
        static void Main()
        {
            /*
            // test 1
                2
                4
                -1
                2
                -5
                -5
                4
                -3

            // test 2
                34
                -3
                5
                9
                -8
                10
                8
                11

            */
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double x1y1 = DistanceToCenter(x1, y1);
            double x2y2 = DistanceToCenter(x2, y2);
            double x3y3 = DistanceToCenter(x3, y3);
            double x4y4 = DistanceToCenter(x4, y4);



            double distanceLine1 = x1y1 + x2y2;
            double distanceLine2 = x3y3 + x4y4;

            if (distanceLine1 >= distanceLine2)
            {
                if (x1y1 <= x2y2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (x3y3 <= x4y4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static double DistanceToCenter(double x, double y)
        {
            return Math.Abs(x + y); // => Math.Sqrt(x * x + y * y);
        }
    }
}
