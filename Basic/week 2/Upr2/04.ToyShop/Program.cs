/*
Цени на играчките:
•	Пъзел - 2.60 лв.
•	Говореща кукла - 3 лв.
•	Плюшено мече - 4.10 лв.
•	Миньон - 8.20 лв.
•	Камионче - 2 лв.
Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена. 
От спечелените пари Петя трябва да даде 10% за наема на магазина. 
Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
Вход
От конзолата се четат 6 реда:
1.	Цена на екскурзията     - реално число
2.	Брой пъзели             - цяло число
3.	Брой говорещи кукли     - цяло число
4.	Брой плюшени мечета     - цяло число
5.	Брой миньони            - цяло число
6.	Брой камиончета         - цяло число
Изход
На конзолата се отпечатва:
•	Ако парите са достатъчни се отпечатва:
o	"Yes! {оставащите пари} lv left."
•	Ако парите НЕ са достатъчни се отпечатва:
o	"Not enough money! {недостигащите пари} lv needed."
*/

//input
double tripPrice = double.Parse(Console.ReadLine());
int puzelCount  = int.Parse(Console.ReadLine());
int dolsCount = int.Parse(Console.ReadLine());
int bearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int truckCount = int.Parse(Console.ReadLine());

//calculations
double allToysCount = puzelCount + dolsCount + bearsCount + minionsCount + truckCount;
double totalSum = (puzelCount * 2.60) + (dolsCount * 3.0) + (bearsCount * 4.10) + (minionsCount * 8.20) + (truckCount * 2.0);

if (allToysCount >= 50)
{
    totalSum *= 0.75;
}
totalSum *= 0.90;

//output
if (totalSum >= tripPrice)
{
    Console.WriteLine($"Yes! {totalSum - tripPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {tripPrice - totalSum:f2} lv needed.");
}