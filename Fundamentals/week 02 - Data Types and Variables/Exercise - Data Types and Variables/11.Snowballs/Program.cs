
using System.Numerics;

int count = int.Parse(Console.ReadLine());

int curentSnow = 0;
int curentTime = 0;
int curentQuality = 0;
BigInteger curentValue = 0;
int i = 0;
for (; i < count; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
    if (value >= curentValue)
    {
        curentSnow = snowballSnow;
        curentTime = snowballTime;
        curentQuality = snowballQuality;
        curentValue = value;
    }
}
if (i != 0)
{
    Console.WriteLine($"{curentSnow} : {curentTime} = {curentValue} ({curentQuality})");
}
