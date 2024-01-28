/*
 Странно, но повечето хора си плануват от рано почивката. Млад програмист разполага с определен бюджет и свободно време в даден сезон. Напишете програма, която да приема на входа бюджета и сезона, а на изхода да изкарва, къде ще почива програмиста и колко ще похарчи.
Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. 
*/
/*
Ако е лято ще почива на къмпинг, а зимата в хотел. 
Ако е в Европа, независимо от сезона ще почива в хотел. 
Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета: 
*/
/*
•	При 100лв. или по-малко – някъде в България
o	Лято – 30% от бюджета
o	Зима – 70% от бюджета
•	При 1000лв. или по малко – някъде на Балканите
o	Лято – 40% от бюджета
o	Зима – 80% от бюджета
•	При повече от 1000лв. – някъде из Европа
o	При пътуване из Европа, независимо от сезона ще похарчи 90% от бюджета.
*/
/*
Вход
Входът се чете от конзолата и се състои от два реда, въведени от потребителя:
•	Първи ред – Бюджет, реално число в интервала [10.00...5000.00].
•	Втори ред – Един от двата възможни сезона: „summer” или “winter”
*/
/*
Изход
На конзолата трябва да се отпечатат два реда.
•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
•	Втори ред – “{Вид почивка} – {Похарчена сума}“
o	Почивката може да е между „summer” и „winter”
o	Сумата трябва да е закръглена с точност до вторият знак след запетаята.
*/

//input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string placeOfRest = "";
string kindOfVacation = "";
double costOfVacation = 0.00;

//calculations
placeOfRest = budget switch
{
     > 0 and <= 100 => "Bulgaria",
     > 100 and <= 1000 => "Balkans",
    _ => "Europe"
};
kindOfVacation = season switch
{
    "summer" when budget <= 100 => "Camp",
    "summer" when budget <= 1000 => "Camp",
    "winter" when budget <= 100 => "Hotel",
    "winter" when budget <= 1000 => "Hotel",
    _ => "Hotel"
};

costOfVacation = (season, placeOfRest) switch
{
    ("summer", "Bulgaria") => budget * 0.3,
    ("winter", "Bulgaria") => budget * 0.7,
    ("summer", "Balkans") => budget * 0.4,
    ("winter", "Balkans") => budget * 0.8,
    (_, "Europe") => budget * 0.9
};
// output
Console.WriteLine($"Somewhere in {placeOfRest}");
Console.WriteLine($"{kindOfVacation} - {costOfVacation:F2}");
