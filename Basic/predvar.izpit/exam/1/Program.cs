/*
•	Опаковъчна хартия - 5.80 лв. за ролка
•	Плат - 7.20 лв. за ролка
•	Лепило - 1.20 лв. за литър
 */

int numbersOfRolsOfPaper = int.Parse(Console.ReadLine());
int numbersOfRolsOfCloth = int.Parse(Console.ReadLine());
double litersOfClue = double.Parse(Console.ReadLine());
int procentOfDiscount = int.Parse(Console.ReadLine());


double paper = numbersOfRolsOfPaper * 5.8;
double cloth = numbersOfRolsOfCloth * 7.2;
double clue = litersOfClue * 1.2;

double sum = paper + cloth + clue;
double sumWithDiscount = sum - (sum * procentOfDiscount / 100);  

Console.WriteLine($"{sumWithDiscount:f3}");