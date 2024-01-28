/*
 •	При "summer" -> 15% отстъпка
•	При "winter" -> 8% оскъпяване
 */

/*
 	            Пролет (spring)	    Лято (summer)	    Есен (autumn)	    Зима (winter)
До 5 човека	    50.00 лв. на човек	48.50 лв. на човек	60.00 лв. на човек	86.00 лв. на човек
Над 5 човека	48.00 лв. на човек	45.00 лв. на човек	49.50 лв. на човек	85.00 лв. на човек


•	При "summer" -> 15% отстъпка
•	При "winter" -> 8% оскъпяване

 */

int countOfPeople = int.Parse(Console.ReadLine());
string seson = Console.ReadLine();

double priceOfTrip = 0;

switch (seson)
{
    case "spring": 
        if (countOfPeople <= 5)
        {
            priceOfTrip = 50.00;
        }
        else
        {
            priceOfTrip = 48.00;
        }
        break;
    case "summer":
        if (countOfPeople <= 5)
        {
            priceOfTrip = 48.50 * 0.85;
        }
        else
        {
            priceOfTrip = 45.00 * 0.85;
        }
        break;
    case "autumn":
        if (countOfPeople <= 5)
        {
            priceOfTrip = 60.00;
        }
        else
        {
            priceOfTrip = 49.5;
        }
        break;
    case "winter":
        if (countOfPeople <= 5)
        {
            priceOfTrip = 86.00 * 1.08;
        }
        else
        {
            priceOfTrip = 85.00 * 1.08;
        }
        break;
}

double sum =  priceOfTrip * countOfPeople;

Console.WriteLine($"{sum:f2} leva.");