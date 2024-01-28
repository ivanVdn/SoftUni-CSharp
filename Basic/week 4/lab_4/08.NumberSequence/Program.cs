int count = int.Parse(Console.ReadLine());
int maxNumber = int.MinValue;
int minNumber = int.MaxValue;

for (int i = 0; i < count; i++)
{
    int Number = int.Parse(Console.ReadLine());
    if (Number < minNumber) { minNumber = Number; }
    if (Number > maxNumber) { maxNumber = Number; }    
}
Console.WriteLine($"Max number: {maxNumber}");
Console.WriteLine($"Min number: {minNumber}");