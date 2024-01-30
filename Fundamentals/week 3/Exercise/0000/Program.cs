namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersToCheck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (numbersToCheck.Length <= 1)
            {
                Console.WriteLine("0");
                return;
            }
            else
            {
                int index = 0;
                int leftSum = 0;

                for (int i = 1; i < numbersToCheck.Length; i++)
                {

                    leftSum += numbersToCheck[i - 1];
                    int rightSum = 0;

                    for (int j = numbersToCheck.Length - 1 ; j > i; j--)
                    {
                        rightSum += numbersToCheck[j]; 
                    }
                    if (leftSum == rightSum)
                    {
                        index = i;
                        break;
                    }
                }

                if (index != 0)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}