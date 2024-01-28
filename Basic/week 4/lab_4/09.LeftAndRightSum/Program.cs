int count = int.Parse(Console.ReadLine());
int leftSum = 0;
int rightSum = 0;

for (int i = 1; i <= count*2; i++)
{
    int Number = int.Parse(Console.ReadLine());
    if (i <= count)
    {
        leftSum += Number;
    }
    else
    {
        rightSum += Number;
    }
}

if (rightSum == leftSum)
{
    Console.WriteLine($"Yes, sum = {rightSum}");
}
else
{
    int diff = Math.Abs(leftSum - rightSum);
    Console.WriteLine($"No, diff = {diff}");
}