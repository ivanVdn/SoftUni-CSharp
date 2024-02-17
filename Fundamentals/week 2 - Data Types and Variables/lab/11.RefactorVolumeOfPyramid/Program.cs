
double length, width, height = 0;
Console.Write("Length: ");
length = double.Parse(Console.ReadLine());
Console.Write("Width: ");
width = double.Parse(Console.ReadLine());
Console.Write("Height: ");
height = double.Parse(Console.ReadLine());

double areaOfBasis = length * width;
double volume = ((1.0/3.0)*(areaOfBasis)) * height;
Console.Write($"Pyramid Volume: {volume:f2}");
