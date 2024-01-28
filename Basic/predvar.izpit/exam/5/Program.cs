
/*
int allMeters = 5_364;
int dayCount = 1;
while (true)
{
    string comand = Console.ReadLine();
    if (comand == "END")
    {
        Console.WriteLine("Failed!");
        Console.WriteLine($"{allMeters}");
        break;
    }
    if (dayCount >= 5)
    {
        Console.WriteLine("Failed!");
        Console.WriteLine($"{allMeters}");
        break;
    }
    int meters = int.Parse(Console.ReadLine());
    allMeters += meters;
    if (comand == "Yes")
    {
        dayCount++;
    }

    if (allMeters > 8_848)
    {
        Console.WriteLine($"Goal reached for {dayCount} days!");
        break;
    }
}


int startingMeters = 5364;
int counterOfDays = 1;
for (int i = 1; i <= 5; i++)
{
    string comand = Console.ReadLine();
    if (comand == "END") { break; }
    if (comand == "Yes") counterOfDays++;
    if (comand == "Yes" && counterOfDays > 5) { break; }
    if (comand == "No") { i--; }
    startingMeters += int.Parse(Console.ReadLine());
    if (startingMeters >= 8848) { break; }
}
if (startingMeters < 8848)
{
    Console.WriteLine("Failed!");
    Console.WriteLine($"{startingMeters}");
}
else
{ Console.WriteLine($"Goal reached for {counterOfDays} days!"); }
*/

int EverestHeight = 8848;
int BaseCampHeight = 5364;
int MaxClimbingDays = 5;

int totalClimbedMeters = 0;
int climbingDays = 0;

while (climbingDays < MaxClimbingDays)
{
    string input = Console.ReadLine();

    if (input == "END" || totalClimbedMeters >= EverestHeight)
    {
        break;
    }

    string willNightStay = input;
    int metersClimbed = int.Parse(Console.ReadLine());

    totalClimbedMeters += metersClimbed;
    climbingDays++;

    if (totalClimbedMeters >= EverestHeight)
    {
        Console.WriteLine($"Goal reached for {climbingDays} days!");
    }
    else if (climbingDays == MaxClimbingDays)
    {
        Console.WriteLine("Failed!");
        Console.WriteLine($"{totalClimbedMeters}");
    }
    else
    {
        if (willNightStay == "Yes")
        {
            totalClimbedMeters += BaseCampHeight;
        }
    }
}