//input

int dogs = int.Parse(Console.ReadLine());
int cats = int.Parse(Console.ReadLine());

//calculations

double dogsFood = dogs * 2.5;
double catsFood = cats * 4;
double money = dogsFood + catsFood;

//output

Console.WriteLine($"{money:f1} lv.");