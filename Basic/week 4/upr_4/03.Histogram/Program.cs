﻿/* Решение от упражненията
int numbersToBeRead = int.Parse(Console.ReadLine());

double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

for (int i = 0; i < numbersToBeRead; i++)
{
    int number = int.Parse(Console.ReadLine());
         if (number < 200) { p1++; }
    else if (number < 400) { p2++; }
    else if (number < 600) { p3++; }
    else if (number < 800) { p4++; }
    else                   { p5++; }
}
Console.WriteLine($"{p1 / numbersToBeRead * 100:f2}%");
Console.WriteLine($"{p2 / numbersToBeRead * 100:f2}%");
Console.WriteLine($"{p3 / numbersToBeRead * 100:f2}%");
Console.WriteLine($"{p4 / numbersToBeRead * 100:f2}%");
Console.WriteLine($"{p5 / numbersToBeRead * 100:f2}%");
*/
/* Условие
Дадени са n цели числа в интервала [1…1000]. От тях някакъв процент p1 са под 200, друг процент p2 са от 200 до 399, друг процент p3 са от 400 до 599, друг процент p4 са от 600 до 799 и останалите p5 процента са от 800 нагоре. Да се напише програма, която изчислява и отпечатва процентите p1, p2, p3, p4 и p5.
*/
/*Вход
На първия ред от входа стои цялото число n (1 ≤ n ≤ 1000) – брой числа. На следващите n реда стои по едно цяло число в интервала [1…1000] – числата върху които да бъде изчислена хистограмата.
*/
/*Изход
Да се отпечата на конзолата хистограмата – 5 реда, всеки от които съдържа число между 0% и 100%, с точност две цифри след десетичната точка, например 25.00%, 66.67%, 57.14%.
*/

//input
int cauntOfNumbers = int.Parse(Console.ReadLine());

//calculations
double p1 = 0, p2=0, p3=0, p4=0, p5=0;
for (int i = 0; i < cauntOfNumbers; i++)
{
    int number = int.Parse(Console.ReadLine());
         if (number < 200) { p1++; }
    else if (number < 400) { p2++; }
    else if (number < 600) { p3++; }
    else if (number < 800) { p4++; }
    else /*if (number >= 800)*/ { p5++; }
}
Console.WriteLine($"{p1 / cauntOfNumbers * 100:f2}%");
Console.WriteLine($"{p2 / cauntOfNumbers * 100:f2}%");
Console.WriteLine($"{p3 / cauntOfNumbers * 100:f2}%");
Console.WriteLine($"{p4 / cauntOfNumbers * 100:f2}%");
Console.WriteLine($"{p5 / cauntOfNumbers * 100:f2}%");
