/* Пирамида от числа
Напишете програма, която чете цяло число n, въведено от потребителя, и отпечатва пирамида от числа като в примерите:
*/

//input
int n = int.Parse(Console.ReadLine());
int count = 0;

//calculations
for (int row = 1; row <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        count++;

        if (count > n)
        {
            break;
        }
        Console.Write($"{count} ");
    }
    if (count == n)
    {
        break;
    }
    Console.WriteLine();
}