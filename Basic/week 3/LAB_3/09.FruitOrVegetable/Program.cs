﻿/*
Да се напише програма, която чете име на продукт, въведено от потребителя, и проверява дали е плод или зеленчук.
•	Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
•	Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
•	Всички останали са "unknown"
Да се изведе "fruit”, "vegetable" или "unknown" според въведения продукт.

*/

//input
string peoduktName = Console.ReadLine();

//calculations and output
switch (peoduktName)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "lemon":
    case "cherry":
    case "grapes":
        Console.WriteLine("fruit");
        break;
    case "tomato":
    case "cucumber":
    case "pepper":
    case "carrot":
        Console.WriteLine("vegetable");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}
