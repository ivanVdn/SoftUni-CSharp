//input

double area = double.Parse(Console.ReadLine());

//calculations

double price = area * 7.61;
double discoumt = 0.18 * price;
double finalPrice = price - discoumt;

//output

Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discoumt} lv.");