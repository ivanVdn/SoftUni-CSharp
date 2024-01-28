/*

вариант 1

//input

int nailon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int razreditel = int.Parse(Console.ReadLine());
int vreme = int.Parse(Console.ReadLine());

//calculations

double nailonPrice = (nailon + 2) * 1.5;
double paintPrice = (paint + (paint * 0.1))  * 14.50;
double razreditelPrice = razreditel * 5.00;
double sum = nailonPrice + paintPrice + razreditelPrice + 0.40;


double work = (sum * 0.3) * vreme;
double allSum = sum + work;


//output

Console.WriteLine($"{allSum}");

*/


/*
вариант 2 
*/


//input

int nailon = int.Parse(Console.ReadLine()) + 2;
double paint = double.Parse(Console.ReadLine()) * 1.1);
int razreditel = int.Parse(Console.ReadLine());
int vreme = int.Parse(Console.ReadLine());

//calculations

double nailonPrice = nailon * 1.5;
double paintPrice = paint * 14.50;
double razreditelPrice = razreditel * 5.00;
double sum = nailonPrice + paintPrice + razreditelPrice + 0.40;


double work = (sum * 0.3) * vreme;
double allSum = sum + work;


//output

Console.WriteLine($"{allSum}");