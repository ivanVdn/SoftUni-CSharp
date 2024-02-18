namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var itemPrice = Console.ReadLine()?
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var entryPoint = int.Parse(Console.ReadLine());
            var typeOfItem = Console.ReadLine();
            var leftSum = 0;
            var rightSum = 0;
            if (itemPrice != null)
            {
                var entryPointValue = itemPrice[entryPoint];

                switch (typeOfItem)
                {
                    case "cheap":
                        for (var i = 0; i < itemPrice.Count; i++)
                        {
                            if ((i < entryPoint) && (itemPrice[i] < entryPointValue)) leftSum += itemPrice[i];
                            if ((i > entryPoint) && (itemPrice[i] < entryPointValue)) rightSum += itemPrice[i];
                        }
                        break;
                    case "expensive":
                        for (var i = 0; i < itemPrice.Count; i++)
                        {
                            if ((i < entryPoint) && (itemPrice[i] >= entryPointValue)) leftSum += itemPrice[i];
                            if ((i > entryPoint) && (itemPrice[i] >= entryPointValue)) rightSum += itemPrice[i];
                        }
                        break;
                }
            }

            Console.WriteLine(leftSum >= rightSum ? $"Left - {leftSum}" : $"Right - {rightSum}");
        }
    }
}
