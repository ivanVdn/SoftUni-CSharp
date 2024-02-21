
uint startingYield = uint.Parse(Console.ReadLine());
int dayOfWork = 0;
int sum = 0;


while  (startingYield >= 100)
{
    sum += (int)startingYield;
    startingYield -= 10;
    sum -= 26;
    dayOfWork++;
}
if (sum >= 26)
{
    sum -= 26;
}

Console.WriteLine(dayOfWork);
Console.WriteLine(sum);