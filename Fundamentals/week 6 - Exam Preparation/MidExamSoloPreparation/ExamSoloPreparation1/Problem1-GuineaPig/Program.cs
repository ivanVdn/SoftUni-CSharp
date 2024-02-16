using Microsoft.VisualBasic;

namespace Problem1_GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var food = double.Parse(Console.ReadLine());            // храна
            var hay = double.Parse(Console.ReadLine());             // сено
            var cover = double.Parse(Console.ReadLine());           // покривка на количесвото
            var weight = double.Parse(Console.ReadLine());          // тегло на животинчето
            var day = 0;
            for (var i = 1; i <= 30; i++)
            {
                food -= 0.3;

                if (i % 2 == 0)
                {
                    hay -= (food * 0.05);
                }

                if (i % 3 == 0)
                {
                    cover -= (weight / 3);
                }

                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    break;
                }

                day = i;
            }

            Console.WriteLine(day == 30
                ? $"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}."
                : $"Merry must go to the pet store!");
        }
    }
}
