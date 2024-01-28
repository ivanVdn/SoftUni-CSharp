/*
// Input
int tabsCount = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

// Calculations
for (int index = 0; index < tabsCount; index++)
{
    string tabName = Console.ReadLine();
    if (tabName == "Facebook")
    {
        salary -= 150;
    }
    else if (tabName == "Instagram")
    {
        salary -= 100;
    }
    else if (tabName == "Reddit")
    {
        salary -= 50;
    }

    if (salary <= 0)
    {
        break;
    }
}

// Output
if (salary > 0)
{
    Console.WriteLine(salary);
}
else
{
    Console.WriteLine("You have lost your salary.");
}
*/

/* Условие
Шеф на компания забелязва че все повече служители прекарват  време в сайтове, които ги разсейват.  
За да предотврати това, той въвежда изненадващи проверки на отворените табове на браузъра на служителите си. 
Според отворения сайт в таба се налагат следните глоби:
•	"Facebook" -> 150 лв.
•	"Instagram" -> 100 лв.
•	"Reddit" -> 50 лв.
*/
/*Вход
От конзолата се четат два реда:
•	Брой отворени табове в браузъра n - цяло число в интервала [1...10]
•	Заплата - число в интервала [500...1500]
След това n – на брой пъти се чете име на уебсайт – текст
*/
/*Изход
•	Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва 
"You have lost your salary." и програмата приключва. 
•	В противен случай след проверката на конзолата се изписва остатъкът от заплатата (да се изпише като цяло число).
*/

// Input
int tabsOpen = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

// Calculations
for (int i = 0; i < tabsOpen; i++)
{
    string tabName = Console.ReadLine();
    switch (tabName)
        {
        case "Facebook":    salary -= 150; break;
        case "Instagram":   salary -= 100; break;
        case "Reddit":      salary -=  50; break;
    }
    if (salary <= 0)
    {
        break;
    }
}

// Output
if (salary <= 0)
{
    Console.WriteLine("You have lost your salary.");
}
else
{
    Console.WriteLine(salary);
}