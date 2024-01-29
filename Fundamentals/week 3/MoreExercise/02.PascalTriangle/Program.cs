
int numberOfRow = int.Parse(Console.ReadLine());
int[] firstRow = { 1 };

for (int i = 0; i < numberOfRow; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(firstRow[0] + " ");
    }
    Console.WriteLine();
}
