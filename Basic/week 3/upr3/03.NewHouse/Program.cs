/*
Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята, че Ви убеждава да напишете програма която да изчисли колко  ще им струва, да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен. Различните цветя са с различни цени. 
*/
/*
цвете               	  Роза	    Далия	Лале	Нарцис	 Гладиола
Цена на брой в лева	        5	    3.80	2.80	  3	       2.50
*/
/*
Съществуват следните отстъпки:
•	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
•	Ако Нели купи повече от 90  Далии - 15% отстъпка от крайната цена
•	Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%
*/
/*
От конзолата се четат 3 реда:
•	Вид цветя - текст с възможности - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
•	Брой цветя - цяло число в интервала [10…1000]
•	Бюджет - цяло число в интервала [50…2500]
Да се отпечата на конзолата на един ред:
•	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
•	Ако бюджета им е НЕ достатъчен - "Not enough money, you need {нужната сума} leva more."
Сумата да бъде форматирана до втория знак след десетичната запетая.
*/

//input
string flower = Console.ReadLine();
int countOfFlowers = int.Parse(Console.ReadLine());
int budjet = int.Parse(Console.ReadLine());

double priceOfFlower = 0;
double spendetMoney = 0;

//calculations
switch (flower)
{
    case "Roses":
        priceOfFlower = 5.00;
        spendetMoney = countOfFlowers * priceOfFlower;
        if (countOfFlowers > 80) { spendetMoney *= 0.9; }
        break;
    case "Dahlias":
        priceOfFlower = 3.80;
        spendetMoney = countOfFlowers * priceOfFlower;
        if (countOfFlowers > 90) { spendetMoney *= 0.85; }
        break;
    case "Tulips":
        priceOfFlower = 2.80;
        spendetMoney = countOfFlowers * priceOfFlower;
        if (countOfFlowers > 80) { spendetMoney *= 0.85; }
        break;
    case "Narcissus":
        priceOfFlower = 3.00; 
        spendetMoney = countOfFlowers * priceOfFlower;
        if (countOfFlowers < 120) { spendetMoney *= 1.15; }
        break;
    case "Gladiolus":
        priceOfFlower = 2.50; 
        spendetMoney = countOfFlowers * priceOfFlower;
        if (countOfFlowers < 80) { spendetMoney *= 1.20; }
        break;
}

//output
if (budjet >= spendetMoney)
{
    double diference = budjet - spendetMoney;
    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flower} and {Math.Abs(diference):f2} leva left.");
}
else if (budjet < spendetMoney)
{ 
    double diference = budjet - spendetMoney;
    Console.WriteLine($"Not enough money, you need {Math.Abs(diference):f2} leva more.");
}