
var input = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int product = input * i;
    Console.WriteLine($"{input} X {i} = {product}");
}