﻿//input
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int numberOfFishers = int.Parse(Console.ReadLine());

double price = 0;

//calculation
if (season == "Spring")
{
    price = 3000;
}
else if (season == "Summer" || season == "Autumn")
{
    price = 4200;
}
else if (season == "Winter")
{
    price = 2600;
}

if (numberOfFishers <= 6)
{
    price *= 0.90;
}
else if (numberOfFishers <= 11)
{
    price *= 0.85;
}
else 
{
    price *= 0.75;
}

if ((numberOfFishers % 2 == 0) && (season != "Autumn"))
{
    price *= 0.95;
}

double diferense = budget - price;

//output
if (budget >= price)
{
    Console.WriteLine($"Yes! You have {Math.Abs(diferense):f2} leva left.");
}
else 
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(diferense):f2} leva.");
}

//condition
/*
Тони и приятели много обичали да ходят за риба, те са толкова запалени по риболова, че решават да отидат на риболов с кораб. Цената за наема на кораба зависи от сезона и броя рибари.
*/
/*
Цената зависи от сезона:
•	Цената за наем на кораба през пролетта е  3000 лв.
•	Цената за наем на кораба през лятото и есента е  4200 лв.
•	Цената за наем на кораба през зимата е  2600 лв.
*/
/*
В зависимост от броя си групата ползва отстъпка:
•	Ако групата е до 6 човека включително  –  отстъпка от 10%.
•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15%.
•	Ако групата е от 12 нагоре  –  отстъпка от 25%. 
*/
/*
Рибарите ползват допълнително 5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
*/
/*
Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. 
*/
/*
Вход
От конзолата се четат точно три реда.
•	Бюджет на групата – цяло число в интервала [1…8000]
•	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
•	Брой рибари – цяло число в интервала [4…18]
*/
/*
Изход
Да се отпечата на конзолата един ред:
•	Ако бюджетът е достатъчен:
"Yes! You have {останалите пари} leva left."
•	Ако бюджетът НЕ Е достатъчен:
"Not enough money! You need {сумата, която не достига} leva."
Сумите трябва да са форматирани с точност до два знака след десетичната запетая.
*/
