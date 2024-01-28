//input
int count = int.Parse(Console.ReadLine());


//calculations
int sum = 0;
int maxNumber = int.MinValue;
for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;
    if (maxNumber < number)
    {
        maxNumber = number;
    }

}
int diff = sum - maxNumber;


//output

if (diff == maxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {diff}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(diff - maxNumber)}");
}