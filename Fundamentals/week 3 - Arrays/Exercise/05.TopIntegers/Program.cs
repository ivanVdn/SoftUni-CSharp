
int[] intArr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int length = intArr.Length;

for (int i = 0; i < length - 1; i++)
{
    bool isUpperInteger = true;

    for (int j = i + 1; j < length; j++)
    {
        if (intArr[i] <= intArr[j])
        {
            isUpperInteger = false;
            break;
        }
    }

    if (isUpperInteger)
    {
        Console.Write(intArr[i] + " ");
    }
}

Console.Write(intArr[length - 1] + " ");
