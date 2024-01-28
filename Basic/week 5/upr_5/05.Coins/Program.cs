/*
Производителите на вендинг машини искали да направят машините си да връщат възможно най-малко монети ресто. Напишете програма, която приема сума - рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.
*/

//input
decimal changehe = decimal.Parse(Console.ReadLine());
int coinCounter = 0;

//calculation
while (changehe > 0)
{
         if (changehe >= 2)     changehe -= 2;
    else if (changehe >= 1)     changehe -= 1;
    else if (changehe >= 0.5m)  changehe -= 0.5m;
    else if (changehe >= 0.2m)  changehe -= 0.2m;
    else if (changehe >= 0.1m)  changehe -= 0.1m;
    else if (changehe >= 0.05m) changehe -= 0.05m;
    else if (changehe >= 0.02m) changehe -= 0.02m;
    else                        changehe -= 0.01m;
    coinCounter++;
    }
//output
Console.WriteLine(coinCounter);