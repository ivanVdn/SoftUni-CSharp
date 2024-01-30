int[] incomingsArr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int currentPosition = 0; currentPosition < incomingsArr.Length; currentPosition++)
{
    if (incomingsArr.Length == 1)
    {
        Console.WriteLine(0);
        return;
    }

    int leftSum = 0;
    int rightSum = 0;

    for (int i = currentPosition; i > 0; i--)
    {
        leftSum += incomingsArr[i - 1];
    }

    for (int i = currentPosition; i < incomingsArr.Length - 1; i++)
    {
        rightSum += incomingsArr[i + 1];
    }

    if (leftSum == rightSum)
    {
        Console.WriteLine(currentPosition);
        return;
    }
}
Console.WriteLine("no");