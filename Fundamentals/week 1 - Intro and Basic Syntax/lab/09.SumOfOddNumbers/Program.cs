
var n = int.Parse(Console.ReadLine());

int num = 0;
int sum = 0;

for (int i = 1; i <= n; i++)
{
    num = 2 * i - 1;
    sum += num;
    Console.WriteLine(num);
}
Console.WriteLine($"Sum: {sum}");