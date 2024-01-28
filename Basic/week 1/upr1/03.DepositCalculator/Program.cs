
//input

double suma = double.Parse(Console.ReadLine());
int srok = int.Parse(Console.ReadLine());
double lihva = double.Parse(Console.ReadLine());

//calculations

double endSum = suma + srok * (( suma * lihva) / 100) / 12;

//output

Console.WriteLine(endSum);