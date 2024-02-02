
int firstChar = int.Parse(Console.ReadLine());
int lastChar = int.Parse(Console.ReadLine());

for (int i = firstChar; i <= lastChar; i++)
{
    char curentChar = (char)i;
    Console.Write($"{curentChar} ");
}