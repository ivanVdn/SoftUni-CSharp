
string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

int input = int.Parse(Console.ReadLine());

if (input < 1 || input > 7)
{
    Console.WriteLine("Invalid day!");
}
else
{
    Console.WriteLine(dayOfWeek[input - 1]);    
}