/*
Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура
и пресмята лицето й. 
Фигурите са четири вида: квадрат (square), правоъгълник (rectangle), кръг (circle) и триъгълник (triangle). 

На първия ред на входа се чете вида на фигурата 
            (текст със следните възможности: square, rectangle, circle или triangle). 
•	Ако фигурата е квадрат (square): 
                на следващия ред се чете едно дробно число - дължина на страната му
•	Ако фигурата е правоъгълник (rectangle): 
                на следващите два реда четат две дробни числа - дължините на страните му
•	Ако фигурата е кръг (circle): 
                на следващия ред чете едно дробно число - радиусът на кръга
•	Ако фигурата е триъгълник (triangle): 
                на следващите два реда четат две дробни числа - дължината на страната му 
                и дължината на височината към нея
Резултатът да се закръгли до 3 цифри след десетичната запетая. 


//input
        Console.Write("Enter a figure (square, rectangle, circle, triangle): ");
        string shape = Console.ReadLine();
        double area = 0;
//calculations
        switch (shape)
        {
            case "square":
                Console.Write("Enter the lenght of the side of the square: ");
                double sideLength = double.Parse(Console.ReadLine());
                area = sideLength * sideLength;
                break;
            case "rectangle":
                Console.Write("Enter the lenght of the rectangle: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                double width = double.Parse(Console.ReadLine());
                area = length * width;
                break;
            case "circle":
                Console.Write("Enter the radius: ");
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
                break;
            case "triangle":
                Console.Write("Enter the lenght of the side of the triangle: ");
                double triangleBase = double.Parse(Console.ReadLine());
                Console.Write("Enter the lenght of the height of the triangle: ");
                double height = double.Parse(Console.ReadLine());
                area = 0.5 * triangleBase * height;
                break;
            default:
                //output
                Console.WriteLine("Unvalid figure.");
                return;
        }
//output
        Console.WriteLine("Round of the figure is: " + Math.Round(area, 3));
*/


//input
Console.Write("Enter a figure (square, rectangle, circle, triangle): ");
string figure = Console.ReadLine();
double area = 0;
if (figure == "square")
{
    //calculations
    double side = double.Parse(Console.ReadLine());
    area = side * side;
    //output
    Console.WriteLine($"{area:f3}");
}
else if (figure == "rectangle")
{
//calculations
    double length = double.Parse(Console.ReadLine());
    double width = double.Parse(Console.ReadLine());
    area = length * width;
//output
    Console.WriteLine($"{area:f3}");
}
else if (figure == "circle")
{
//calculations
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * Math.Pow(radius, 2);
//output
    Console.WriteLine($"{area:f3}");
}
else if (figure == "triangle")
{
//calculations
    double triangleBase = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    area = 0.5 * triangleBase * height;
//output
    Console.WriteLine($"{area:f3}");
}
