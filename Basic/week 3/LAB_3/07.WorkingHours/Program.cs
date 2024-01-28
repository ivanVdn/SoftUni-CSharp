/*
Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст) - въведени от потребителя и проверява дали офисът на фирма е отворен, като работното време на офисът е от 10-18 часа, от понеделник до събота включително
*/


//input
int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

//calculations
if (hour >= 10 && hour <= 18)
{
    switch (day)
    {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
        case "Saturday":
            Console.WriteLine("open");
            break;
        case "Sunday":
            Console.WriteLine("closed");
            break;
    }
}
else { Console.WriteLine("closed"); }