/*
 Напишете програма, която първоначално прочита име и парола на потребителски профил. След това чете парола за вход.
•	при въвеждане на грешна парола: потребителя да се подкани да въведе нова парола.
•	при въвеждане на правилна парола: отпечатваме "Welcome {username}!".
*/

//input
string username = Console.ReadLine();
string password = Console.ReadLine();
string input = "";

//calculations and output
while (input != password)
{
    input = Console.ReadLine();
    if (input == password)
    {
        Console.WriteLine($"Welcome {username}!");
        break;
    }
}