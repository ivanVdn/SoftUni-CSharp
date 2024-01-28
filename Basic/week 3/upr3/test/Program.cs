//input
/**/
int n = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

if (n > z)
{
    while (n != z)
    {
        z++;
        Console.WriteLine(z);
    }
} 
else 
{
    Console.WriteLine("OK!");
}


/*
int a = int.Parse(Console.ReadLine());


//Console.WriteLine($"The first {a} powers of 2 are:");
for (int i = 0; i <= a; i++)
{
    double b = Math.Pow(2, i);
    Console.WriteLine($"2 to the power of {i} is {b};");
}
Console.WriteLine();
*/