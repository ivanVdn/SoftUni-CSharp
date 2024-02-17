
var hour = int.Parse(Console.ReadLine());
var minute = int.Parse(Console.ReadLine());

minute += 30;

if (minute > 60)
{
    minute -= 60;
    hour += 1;
}
if (hour >= 24)
{ 
    hour = 0;
}

Console.WriteLine($"{hour}:{minute:d2}");