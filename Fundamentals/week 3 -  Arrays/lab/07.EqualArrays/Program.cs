
int[] firstArr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] secondArr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;
if (firstArr.Length != secondArr.Length)
{
    Console.WriteLine("Arrays are not identical. Found difference at 0 index");
    return;
}

for (int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i] != secondArr[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        return;
    }
    else
    {
        sum += firstArr[i];
    }
}
Console.WriteLine($"Arrays are identical. Sum: {sum}");