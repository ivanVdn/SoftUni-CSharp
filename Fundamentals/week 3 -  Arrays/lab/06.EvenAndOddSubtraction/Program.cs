int[] items = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int evenSum = 0;
int oddSum = 0;

for (int i = 0; i < items.Length; i++)
{
    if (items[i] % 2 == 0)
    {
        evenSum += items[i];
    }
    else
    {
        oddSum += items[i];
    }
}
Console.WriteLine(evenSum - oddSum);
