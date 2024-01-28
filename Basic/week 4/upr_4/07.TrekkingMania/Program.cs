/* Условие
Катерачи от цяла България се събират на групи и набелязват следващите върхове за изкачване. Според размера на групата, катерачите ще изкачват различни върхове.
•	Група до 5 човека – изкачват Мусала
•	Група от 6 до 12 човека – изкачват Монблан
•	Група от 13 до 25 човека – изкачват Килиманджаро
•	Група от 26 до 40 човека –  изкачват К2
•	Група от 41 или повече човека – изкачват Еверест
Да се напише програма, която изчислява процента на катерачите изкачващи всеки връх.
*/
/*Вход
От конзолата се четат поредица от числа, всяко на отделен ред:
•	На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]
•	За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала [1...1000]
*/
/*Изход
Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00% и 100.00% с точност до втората цифра след десетичната запетая.
•	Първи ред - процентът изкачващи Мусала
•	Втори ред – процентът изкачващи Монблан
•	Трети ред – процентът изкачващи Килиманджаро
•	Четвърти ред – процентът изкачващи К2
•	Пети ред – процентът изкачващи Еверест
*/

//input
int cauntOfGroups = int.Parse(Console.ReadLine());

//calculations
double group1 = 0, group2 = 0, group3 = 0, group4 = 0, group5 = 0;
int countOfPeople = 0;
for (int i = 0; i < cauntOfGroups; i++)
{
    
    int numberOfPeopleInGroup = int.Parse(Console.ReadLine());
    countOfPeople += numberOfPeopleInGroup;
         if (numberOfPeopleInGroup <  6)        { group1+= numberOfPeopleInGroup; }
    else if (numberOfPeopleInGroup < 13)        { group2+= numberOfPeopleInGroup; }
    else if (numberOfPeopleInGroup < 26)        { group3+= numberOfPeopleInGroup; }
    else if (numberOfPeopleInGroup < 41)        { group4+= numberOfPeopleInGroup; }
    else /*if (numberOfPeopleInGroup >= 800)*/  { group5+= numberOfPeopleInGroup; }
}
Console.WriteLine($"{group1 / countOfPeople * 100:f2}%");
Console.WriteLine($"{group2 / countOfPeople * 100:f2}%");
Console.WriteLine($"{group3 / countOfPeople * 100:f2}%");
Console.WriteLine($"{group4 / countOfPeople * 100:f2}%");
Console.WriteLine($"{group5 / countOfPeople * 100:f2}%");
