﻿/* 
За рождения си ден Любомир получил аквариум с формата на паралелепипед. 
Първоначално прочитаме от конзолата на отделни редове размерите му – дължина, широчина и височина 
в сантиметри. 
Трябва да се пресметне колко литра вода ще събира аквариума, ако се знае, че определен процент от 
вместимостта му е заета от пясък, растения, нагревател и помпа. 
        Един литър вода се равнява на един кубичен дециметър/ 1л = 1дм3/. 
Да се напише програма, която изчислява литрите вода, която са необходими за напълването на аквариума.
*/
/*
Вход
От конзолата се четат 4 реда:
1.	Дължина в см – цяло число в интервала [10 … 500]
2.	Широчина в см – цяло число в интервала [10 … 300]
3.	Височина в см – цяло число в интервала [10… 200]
4.	Процент  – реално число в интервала [0.000 … 100.000]
Изход
Да се отпечата на конзолата едно число:
•	литрите вода, които ще  събира аквариума.
*/

//v1
/*
//input
double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double percent = double.Parse(Console.ReadLine());

//calculations
double obem = (length * width * height) / 1000;
double zaetoProstranstvo = (percent / 100);
double litres = obem * (1 - zaetoProstranstvo);

//output
Console.WriteLine(litres);
*/

//v2
// input
int length = int.Parse(Console.ReadLine()); // Дължина в см
int width = int.Parse(Console.ReadLine());  // Широчина в см
int height = int.Parse(Console.ReadLine()); // Височина в см
double percentOccupied = double.Parse(Console.ReadLine()); // Процент заетост

// calculations
double volume = (length * width * height) / 1000.0; //обем в литри
double waterNeeded = volume * (1 - percentOccupied / 100);

// output
Console.WriteLine(waterNeeded);