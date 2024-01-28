int count = int.Parse(Console.ReadLine());
int oddSum = 0;
int evenSum = 0;

for (int i = 0; i < count; i++)
{
    int Number = int.Parse(Console.ReadLine());
    if (i % 2 == 0) 
    { 
        evenSum += Number;
        
    }
    //else
    if (i % 2 != 0) 
    { 
        oddSum += Number;
        
    }
}

if (oddSum == evenSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {evenSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
}