/*
Атанас решава да прекара отпуската си в Банско и да кара ски. Преди да отиде обаче, трябва да резервира хотел и да изчисли колко ще му струва престоя. 
*/
/*
Налични са следните видове помещения, със следните цени за престой:
	"room for one person" – 18.00 лв за нощувка
	"apartment" – 25.00 лв за нощувка 
	"president apartment" – 35.00 лв за нощувка
*/
/*
Според броят на дните, в които ще остане в хотела (пример: 11 дни = 10 нощувки) и видът на помещението, което ще избере, той може да ползва различно намаление. 
*/
/*Намаленията са както следва:
вид помещение	        по-малко от 10 дни	        между 10 и 15 дни	        повече от 15 дни
room for one person	    не ползва намаление	        не ползва намаление	        не ползва намаление
apartment	            30% от крайната цена	    35% от крайната цена	    50% от крайната цена
president apartment	    10% от крайната цена	    15% от крайната цена	    20% от крайната цена
*/
/* оценката на Атанас
След престоя, оценката на Атанас за услугите на хотела може да е позитивна (positive) или негативна (negative) . Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25% от нея. Ако оценката му е негативна приспада от цената 10%.
positive = + 25%
negative = - 10%
*/
/*Вход
Входът се чете от конзолата и се състои от три реда:
•	Първи ред - дни за престой - цяло число в интервала [0...365]
•	Втори ред - вид помещение - "room for one person", "apartment" или "president apartment"
•	Трети ред - оценка - "positive"  или "negative"
*/
/*Изход
На конзолата трябва да се отпечата един ред:
•	Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.
*/


//input

int dayOfTrip = int.Parse(Console.ReadLine())-1;  //дни за престой - цяло число в интервала [0...365]
string typeOfRoom = Console.ReadLine();         //вид помещение - "room for one person", "apartment" или "president apartment"
string rating = Console.ReadLine();             //оценка - "positive"  или "negative"

double price = 0;

//calculations
switch (typeOfRoom)
{
    case "room for one person":
        price = dayOfTrip * 18.00;
        break;
    case "apartment":
        price = dayOfTrip * 25.00;
        if (dayOfTrip < 10)
        {
            price *= 0.7;
        }
        else if (dayOfTrip >= 10 && dayOfTrip <= 15)
        {
            price *= 0.65;
        }
        else if (dayOfTrip > 15)
        {
            price *= 0.5;
        }
        break;
    case "president apartment":
        price = dayOfTrip * 35.00;
        if (dayOfTrip < 10)
        {
            price *= 0.9;
        }
        else if (dayOfTrip >= 10 && dayOfTrip <= 15)
        {
            price *= 0.85;
        }
        else if (dayOfTrip > 15)
        {
            price *= 0.8;
        }
        break;
}

if (rating == "positive")
{
    price *= 1.25;
}
else if (rating == "negative")
{
    price *= 0.90;
}
Console.WriteLine($"{price:f2}");