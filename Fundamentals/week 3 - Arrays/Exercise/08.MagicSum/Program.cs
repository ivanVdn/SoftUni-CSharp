
/*
Създайте програма, която отпечатва всички уникални двойки в масив от цели числа, чиято сума е равна на дадено число.

1 7 6 2 19 23
8

14 20 60 13 7 19 8
27

*/

int[] incoming = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int number = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < incoming.Length; i++)
{
    sum = 0;
    for (int j = i + 1; j < incoming.Length; j++)
    {
        sum = incoming[i] + incoming[j];
        if (sum == number)
        {
            Console.WriteLine(incoming[i] + " " + incoming[j]);
        }
    }
}