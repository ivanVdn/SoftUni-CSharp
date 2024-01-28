

int countOfPC = int.Parse(Console.ReadLine());
double totalSales = 0;
double totalRating = 0;

for (int i = 0; i < countOfPC; i++)
{
    string number = Console.ReadLine();
    int number1 = int.Parse(number[0].ToString());
    int number2 = int.Parse(number[1].ToString());
    double rating = int.Parse(number[2].ToString());
    double sales = number1*10 + number2;
    if (rating == 2) sales *= 0;
    else if (rating == 3) sales *= 0.50;
    else if (rating == 4) sales *= 0.70;
    else if (rating == 5) sales *= 0.85;
    else if (rating == 6) sales *= 1;
    totalSales += sales;
    totalRating += rating;
 }
Console.WriteLine($"{totalSales:f2}");
Console.WriteLine($"{totalRating / countOfPC:f2}");
