namespace Problem1_ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = "";
            double sum = 0;
            while (true)
            {
                command = Console.ReadLine();

                if ((command == "special") || command == "regular")
                {
                    break;
                }

                if (command == null) continue;
                var pcParts = double.Parse(command);

                if (pcParts < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }


                sum += pcParts;
            }


            var taxes = sum * 0.2;
            var sumWithTaxes = sum + taxes;
            if (command == "special")
            {
                var discount = sumWithTaxes * 0.1;
                sumWithTaxes -= discount;
            }
            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {sumWithTaxes:f2}$");
            }
        }
    }
}