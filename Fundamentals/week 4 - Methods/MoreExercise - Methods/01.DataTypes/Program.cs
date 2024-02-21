namespace _01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SwitchTypeOfInput(input);
        }

        private static void SwitchTypeOfInput(string? input)
        {
            switch (input)
            {
                case "int":
                    int intInput = int.Parse(Console.ReadLine());
                    Console.WriteLine(intInput * 2);
                    break;
                case "real":
                    double doubleInput = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{doubleInput * 1.5:f2}");
                    break;
                case "string":
                    string stringInput = Console.ReadLine();
                    Console.WriteLine($"${stringInput}$");
                    break;
            }
        }
    }
}
