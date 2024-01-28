/*
По време на обедната почивка искате да изгледате епизод от своя любим сериал. Вашата задача е да напишете програма, с която ще разберете дали имате достатъчно време да изгледате епизода. По време на почивката отделяте време за обяд и време за отдих. 
*/
/*
 * Времето за обяд ще бъде 1/8 от времето за почивка, а 
 * времето за отдих ще бъде 1/4 от времето за почивка. 
*/
/*
 Вход
От конзолата се четат 3 реда:
1.	Име на сериал – текст
2.	Продължителност на епизод  – цяло число в диапазона [10… 90]
3.	Продължителност на почивката  – цяло число в диапазона [10… 120]
*/

//input
string serialName = Console.ReadLine();
int episodeLength = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

//calculations
double lunchTime = breakDuration / 8.0;
double restTime = breakDuration / 4.0;

double totalTime = lunchTime + restTime + episodeLength;

//output
if (totalTime <= breakDuration)
{
    double time = breakDuration - totalTime;
    Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(time)} minutes free time.");
}
else
{
    double time = totalTime - breakDuration;
    Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(time)} more minutes.");
}
/*
 Изход
На конзолата да се изпише един ред:
•	Ако времето е достатъчно да изгледате епизода: 
"You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
•	Ако времето не Ви е достатъчно:
"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
Времето да се закръгли до най-близкото цяло число нагоре.

 */