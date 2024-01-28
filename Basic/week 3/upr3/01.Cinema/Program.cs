﻿/*
В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони. Има три вида прожекции с билети на различни цени:
•	Premiere – премиерна прожекция, на цена 12.00 лева.
•	Normal – стандартна прожекция, на цена 7.50 лева.
•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
Напишете програма, която чете тип прожекция (стринг), брой редове и брой колони в залата (цели числа), въведени от потребителя, и изчислява общите приходи от билети при пълна зала. Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.   
*/

//input
string typeOfProjection = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int columns  = int.Parse(Console.ReadLine());

//calculations
int numberOfPlaces = row * columns;
double profit = 0;
switch (typeOfProjection)
{
    case "Premiere":
        profit = numberOfPlaces * 12.00;
        break;
    case "Normal":
        profit = numberOfPlaces * 7.5;
        break;
    case "Discount":
        profit = numberOfPlaces * 5.00;
        break;
}
Console.WriteLine($"{profit:f2} leva");