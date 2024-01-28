/* Условие
Поканени сте от академията да напишете софтуер, който да пресмята точките за актьор/актриса. Академията ще ви даде първоначални точки за актьора. След това всеки оценяващ ще дава своята оценка. Точките, които актьора получава се формират от: дължината на името на оценяващия умножено по точките, които дава делено на две. 
Ако резултатът в някой момент надхвърли 1250.5 програмата трябва да прекъсне и да се отпечата, че дадения актьор е получил номинация.
*/
/*Вход
•	Име на актьора - текст
•	Точки от академията - реално число в интервала [2.0... 450.5]
•	Брой оценяващи n - цяло число в интервала[1… 20]
На следващите n-на брой реда:
o	Име на оценяващия - текст
o	Точки от оценяващия - реално число в интервала [1.0... 50.0]
*/
/*Изход
Да се отпечата на конзолата един ред:
•	Ако точките са над 1250.5:
"Congratulations, {име на актьора} got a nominee for leading role with {точки}!"
•	Ако точките не са достатъчни:
	"Sorry, {име на актьора} you need {нужни точки} more!"
Резултатът да се форматирана до първата цифра след десетичния знак!
*/

//Input
string actorName = Console.ReadLine();
double academiPoints = double.Parse(Console.ReadLine());
int judge = int.Parse(Console.ReadLine());
//Calculations
double needetPoints = 1250.5;
for (int i = 0; i < judge; i++)
{
    string judgeName = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());

    academiPoints += judgeName.Length * judgePoints / 2;
    if (academiPoints >= needetPoints) { break; }
}
//Output
if (academiPoints >= needetPoints)
{
    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academiPoints:f1}!");
}
else
{
    double leftover = needetPoints - academiPoints;
    Console.WriteLine($"Sorry, {actorName} you need {leftover:f1} more!");
}