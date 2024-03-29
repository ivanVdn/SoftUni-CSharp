﻿/* решение от упажненията
// Input
int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

// Calculations
int sum = 0;
int moneyToBeReceived = 10;

for (int currenAge = 1; currenAge <= age; currenAge++)
{
    if (currenAge % 2 == 0)
    {
        sum += moneyToBeReceived - 1;
        moneyToBeReceived += 10;
    }
    else
    {
        sum += toyPrice;
    }
}

// Output
if (sum >= washingMachinePrice)
{
    Console.WriteLine($"Yes! {sum - washingMachinePrice:f2}");
}
else
{
    Console.WriteLine($"No! {washingMachinePrice - sum:f2}");
}
*/

/* Условие
Лили вече е на N години. За всеки свой рожден ден тя получава подарък. 
•	За нечетните рождени дни (1, 3, 5...n) получава играчки.
•	За четните рождени дни (2, 4, 6...n) получава пари. 
За втория рожден ден получава 10.00 лв, като сумата се увеличава с 10.00 лв., за всеки следващ четен рожден ден (2 -> 10, 4 -> 20, 6 -> 30...и т.н.). През годините Лили тайно е спестявала парите. Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев от тях. Лили продала играчките получени през годините, всяка за P лева и добавила сумата към спестените пари. С парите искала да си купи пералня за X лева. Напишете програма, която да пресмята, колко пари е събрала и дали ѝ стигат да си купи пералня.
*/
/*Вход
Програмата прочита 3 числа, въведени от потребителя, на отделни редове:
•	Възрастта на Лили - цяло число в интервала [1...77]
•	Цената на пералнята - число в интервала [1.00...10 000.00]
•	Единична цена на играчка - цяло число в интервала [0...40]
*/
/*Изход
Да се отпечата на конзолата един ред:
•	Ако парите на Лили са достатъчни:
o	"Yes! {N}" - където N е остатъка пари след покупката
•	Ако парите не са достатъчни:
o	"No! {М}" - където M е сумата, която не достига
Числата N и M трябва да за форматирани до вторият знак след десетичната запетая.
*/


// Input
int age = int.Parse(Console.ReadLine());
double targetMoney = double.Parse(Console.ReadLine());
int toy = int.Parse(Console.ReadLine());

// Calculations
double money = 0;
int n = 1;

for (int i = 1; i <= age; i++)
 {
    if (i % 2 == 0)
    {
        money += (n * 10) - 1;
    //    money --;
        n++;
    }
    else 
    {
        money += toy;
    }

}

// Output
if (money >= targetMoney)
{
    Console.WriteLine($"Yes! {money- targetMoney:f2}");
}
else
{
   Console.WriteLine($"No! {targetMoney - money:f2}"); 
}
