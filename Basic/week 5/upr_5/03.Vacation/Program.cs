/*
Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере дали ще успее да събере необходимата сума. Тя спестява или харчи част от парите си всеки ден. Ако иска да похарчи повече от наличните си пари, то тя ще похарчи колкото има и ще ѝ останат 0 лева.
*/
/* Вход
От конзолата се четат:
•	Пари нужни за екскурзията - реално число в интервала [1.00...25000.00]
•	Налични пари - реално число в интервала [0.00...25000.00]
След това многократно се четат по два реда:
•	Вид действие – текст с възможности "spend" и "save"
•	Сумата, която ще спести / похарчи - реално число в интервала [0.01… 25000.00]
*/
/* Изход
Програмата трябва да приключи при следните случаи:
     Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
o	"You can't save the money."
o	"{Общ брой изминали дни}"
    Ако Джеси събере парите за почивката на конзолата се изписва:
o	"You saved the money for {общ брой изминали дни} days."
*/


//input
double needetMoney = double.Parse(Console.ReadLine());
double startingMoney = double.Parse(Console.ReadLine());
int countSpendDays = 0;
int countDays = 0;

//calculations
while (true)
{
    string option = Console.ReadLine();
    double sum = double.Parse(Console.ReadLine());
    countDays++;


    if (option == "spend")
    {
    countSpendDays ++;
    startingMoney -= sum;
        if (countSpendDays == 5) 
        {
            break; 
        }

        if (startingMoney <= 0)
        {
            startingMoney = 0;
        }
    }

    if (option == "save") 
    { 
        countSpendDays = 0;
        startingMoney += sum;

        if (startingMoney >= needetMoney)
        {
            break;
        }
    }
}

//output
if (startingMoney >= needetMoney)
{
    Console.WriteLine($"You saved the money for {countDays} days.");
}
else
{
    Console.WriteLine($"You can't save the money.");
    Console.WriteLine(countDays);
}


/*
//input
double moneyNeededForTrip = double.Parse(Console.ReadLine());
double currentMoney = double.Parse(Console.ReadLine());

int spendTimesInARow = 0;
int daysCounter = 0;

//calculations
while (true)
{
    string action = Console.ReadLine();
    double sum = double.Parse(Console.ReadLine());
    daysCounter++;

    if (action == "save")
    {
        currentMoney += sum;
        spendTimesInARow = 0;

        if (currentMoney >= moneyNeededForTrip)
        {
            break;
        }
    }
    if (action == "spend")
    {
        spendTimesInARow++;
        currentMoney -= sum;
        if (currentMoney < 0)
        {
            currentMoney = 0;
        }

        if (spendTimesInARow >= 5)
        {
            break;
        }
    }
}

//output 
if (currentMoney >= moneyNeededForTrip)
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}
else
{
    Console.WriteLine($"You can't save the money.");
    Console.WriteLine(daysCounter);
}
*/