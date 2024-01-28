//input

int allPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int deys = int.Parse(Console.ReadLine());

//calculations

int hourPerBook = allPages / pagesPerHour;
int hourPerDey = hourPerBook / deys;

//output

Console.WriteLine(hourPerDey);
