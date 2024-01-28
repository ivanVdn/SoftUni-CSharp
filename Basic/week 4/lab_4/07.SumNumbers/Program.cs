int count = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());
    result += number;
}
Console.WriteLine(result);