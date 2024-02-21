/*

				Friday		Saturday		Sunday
Students		8.45		9.80			10.46
Business		10.90		15.60			16
Regular			15			20				22.50

There are also discounts based on some conditions:
•	For Students – if the group is 30 or more people, you should reduce the total price by 15%.
•	For Business – if the group is 100 or more people, 10 of the people stay for free.
•	For Regular – if the group is between 10 and 20  people (both inclusively), reduce the total price by 5%.
Note: You should reduce the prices in that EXACT order!

*/


var countOfPeople = int.Parse(Console.ReadLine());
var typeOfTheGroup = Console.ReadLine();
var dayOfTheWeek = Console.ReadLine();

double price = 0;
double totalPrice = 0;


switch (dayOfTheWeek)
{
    case "Friday":
        if (typeOfTheGroup == "Students")
        {
            price = 8.45;
        }
        else if (typeOfTheGroup == "Business")
        {
            price = 10.90;
        }
        else if (typeOfTheGroup == "Regular")
        {
            price = 15;
        }
        break;
	case "Saturday":
        if (typeOfTheGroup == "Students")
        {
            price = 9.80;
        }
        else if (typeOfTheGroup == "Business")
        {
            price = 15.60;
        }
        else if (typeOfTheGroup == "Regular")
        {
            price = 20;
        }
        break;
	case "Sunday":
        if (typeOfTheGroup == "Students")
        {
            price = 10.46;
        }
        else if (typeOfTheGroup == "Business")
        {
            price = 16;
        }
        else if (typeOfTheGroup == "Regular")
        {
            price = 22.50;
        }
        break;
}

if (typeOfTheGroup == "Students")
{
    if (countOfPeople >= 30)
    {
        //you should reduce the total price by 15%.
        totalPrice = price * countOfPeople;
        totalPrice -= (totalPrice * 15 / 100);
    }
    else
    {
        totalPrice = price * countOfPeople;
    }
}
else if (typeOfTheGroup == "Business")
{
    if (countOfPeople >= 100)
    {
        //10 of the people stay for free.
        countOfPeople -= 10;
        totalPrice = price * countOfPeople;
    }
    else
    {
        totalPrice = price * countOfPeople;
    }
}
else if (typeOfTheGroup == "Regular")
{
    if (countOfPeople >= 10 && countOfPeople <= 20)
    {
        //reduce the total price by 5%.
        totalPrice = price * countOfPeople;
        totalPrice -= (totalPrice * 5 / 100);
    }
    else
    {
        totalPrice = price * countOfPeople;
    }
}

Console.WriteLine($"Total price: {totalPrice:f2}");