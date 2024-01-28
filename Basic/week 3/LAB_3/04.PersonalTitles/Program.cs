/*
Да се напише конзолна програма, която прочита възраст (реално число) и пол ('m' или 'f'), въведени от потребителя, и отпечатва обръщение измежду следните:
•	"Mr." – мъж (пол 'm') на 16 или повече години
•	"Master" – момче (пол 'm') под 16 години
•	"Ms." – жена (пол 'f') на 16 или повече години
•	"Miss" – момиче (пол 'f') под 16 години
*/

//input
double years = double.Parse(Console.ReadLine());
string gender = Console.ReadLine();

//calculations and output
switch (gender)
{
    case "m":
        if (years < 16)
        {
            Console.WriteLine("Master");
        }
        else
        {
            Console.WriteLine("Mr.");
        }
        break;
    case "f":
        if (years < 16)
        {
            Console.WriteLine("Miss");
        }
        else
        {
            Console.WriteLine("Ms.");
        }
        break;
    default:

        break;
}