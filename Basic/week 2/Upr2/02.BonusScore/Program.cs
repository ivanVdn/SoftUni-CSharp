
//input
int startupPoints = int.Parse(Console.ReadLine());
double bonusPoints = 0;
//calculations

if (startupPoints <= 100)
{
    bonusPoints = 5;
}
else if (startupPoints <= 1000)
{
    bonusPoints = startupPoints * 0.2;
}
else 
{
    bonusPoints = startupPoints * 0.1;
}

if ((startupPoints % 2) == 0)
{
    bonusPoints ++;
    //bonusPoints += 1;
    //bonusPoints = bonusPoints + 1;
}

if ((startupPoints % 10) == 5)
{
    bonusPoints += 2;
}

//output
Console.WriteLine(bonusPoints);
Console.WriteLine(startupPoints + bonusPoints);