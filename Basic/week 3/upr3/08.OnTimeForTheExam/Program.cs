/*
Студент трябва да отиде на изпит в определен час (например в 9:30 часа). Той идва в изпитната зала в даден час на пристигане (например 9:40). Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това. Ако е пристигнал по-рано повече от 30 минути, той е подранил. Ако е дошъл след часа на изпита, той е закъснял. Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали студентът е дошъл навреме, дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял
*/
/*
Вход
От конзолата се четат 4 цели числа (по едно на ред), въведени от потребителя:
•	Първият ред съдържа час на изпита – цяло число от 0 до 23.
•	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
•	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
•	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
*/
/*
Изход
На първият ред отпечатайте:
•	“Late”, ако студентът пристига по-късно от часа на изпита.
•	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
•	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
•	“mm minutes after the start” за закъснение под час.
•	“hh:mm hours after the start” за закъснение от 1 час или повече. Минутите винаги печатайте с 2 цифри, например “1:03”.
*/

//input
int examHour = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int comingHour = int.Parse(Console.ReadLine());
int comingMinutes = int.Parse(Console.ReadLine());

int allMinutesToExam = 0;
int allMinutesToComing = 0;
//calculations
allMinutesToExam = examMinutes + (examHour * 60);
allMinutesToComing = comingMinutes + (comingHour * 60);

if (((allMinutesToExam - allMinutesToComing) <= 30) && ((allMinutesToExam - allMinutesToComing) >= 0))
{
    Console.WriteLine("On time");
}
else if ((allMinutesToExam - allMinutesToComing) > 30)
{ 
    Console.WriteLine("Early");
}
else
{
    Console.WriteLine("Late");
}

int min_ = allMinutesToExam - allMinutesToComing;
int min  = Math.Abs(min_);

if (min_ < 0)
{
    if (min >= 60)
    {
        int leftMin = min % 60;
        int leftHours = min / 60;
        if (leftMin >= 10) 
        { Console.WriteLine($"{leftHours}:{leftMin} hours after the start");} //
        else 
        { Console.WriteLine($"{leftHours}:0{leftMin} hours after the start");} //
    }
    else
    {
        if (min >= 10)
        { Console.WriteLine($"{min} minutes after the start"); } //
        else
        { Console.WriteLine($"{min} minutes after the start"); } //
    }
}
else if (min_ >= 0)
{
    if (min >= 60)
    {
        int leftMin = min % 60;
        int leftHours = min / 60;
        if (leftMin >= 10)
        { Console.WriteLine($"{leftHours}:{leftMin} hours before the start");} //
        else
        { Console.WriteLine($"{leftHours}:0{leftMin} hours before the start");} //
    }
    else
    {
        if (min >= 10)
        { Console.WriteLine($"{min} minutes before the start"); } //
        else
        { Console.WriteLine($"{min} minutes before the start"); } //
    }
}







//output