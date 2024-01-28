/*
Напишете програма, която отпечатва класа на животното според неговото име, въведено от потребителя.
1.	dog -> mammal
2.	crocodile, tortoise, snake -> reptile
3.	others -> unknown

*/

//input
string animalClas = Console.ReadLine();

//calculations and output
switch (animalClas)
{
    case "tortoise":
    case "crocodile":
    case "snake":
        Console.WriteLine("reptile");
        break;
    case "dog":
        Console.WriteLine("mammal");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}