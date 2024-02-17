namespace Problem1_BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var daysOfWork = int.Parse(Console.ReadLine());
            var plunderOfOneDay = int.Parse(Console.ReadLine());
            var expectedPlunder = double.Parse(Console.ReadLine());

            double plunder = 0;


            for (var i = 1; i <= daysOfWork; i++)
            {
                plunder += plunderOfOneDay;

                if (i % 3 == 0)
                {
                    plunder += plunderOfOneDay * 0.5;
                }

                if (i % 5 == 0)
                {
                    plunder *= 0.7;
                }
            }

            var percentage = (plunder / expectedPlunder) * 100;


            if (plunder < expectedPlunder)
            {
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
            else
            {
                Console.WriteLine($"Ahoy! {plunder:f2} plunder gained.");
            }
        }
    }
}
