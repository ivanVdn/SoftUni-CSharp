
int n = int.Parse(Console.ReadLine());

int[,] arrayFromIncomingNumbers = new int[n, 2];

for (int i = 0; i < n; i++)
{
    string[] ncomingNumber = Console.ReadLine()
        .Split(' ');
    arrayFromIncomingNumbers[i, 0] = int.Parse(ncomingNumber[0]);
    arrayFromIncomingNumbers[i, 1] = int.Parse(ncomingNumber[1]);
}

int[] array1 = new int[n];
int[] array2 = new int[n];

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        array1[i] = arrayFromIncomingNumbers[i, 0];
        array2[i] = arrayFromIncomingNumbers[i, 1];
    }
    else
    {
        array1[i] = arrayFromIncomingNumbers[i, 1];
        array2[i] = arrayFromIncomingNumbers[i, 0];
    }
}

Console.WriteLine(string.Join(" ", array1));
Console.WriteLine(string.Join(" ", array2));

