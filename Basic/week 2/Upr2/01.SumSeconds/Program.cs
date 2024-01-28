using System.Reflection;

int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int totalSecont = firstTime + secondTime + thirdTime;
int minuts = totalSecont / 60;
int remainingSeconds = totalSecont % 60;

if (remainingSeconds < 10)
{
    Console.WriteLine($"{minuts}:0{remainingSeconds}");
}
else
{
    Console.WriteLine($"{minuts}:{remainingSeconds}");
}