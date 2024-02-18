
long numberOfRow = long.Parse(Console.ReadLine());

long[] currenttRow = new long[numberOfRow];
currenttRow[0] = 1;

for (int i = 0; i < numberOfRow; i++)
{
    long prevElement = 1;
    
    for (int j = 1; j <= i; j++)
    {
        long temp = currenttRow[j];
        currenttRow[j] += prevElement;
        prevElement = temp;
    }

    for (int k = 0; k <= i; k++)
    {
        Console.Write(currenttRow[k] + " ");
    }

    Console.WriteLine();
}
