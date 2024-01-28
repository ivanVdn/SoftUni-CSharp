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
*/

//input
Console.Write("Enter a figure (square, rectangle, circle, triangle): ");
//input
string figures = Console.ReadLine();
double area = 0;

switch (figures)
{
    case "square":
        //output
        Console.Write("Enter the lenght of the side: ");
        //input
        double side = double.Parse(Console.ReadLine());
        //calculations
        area = side * side;
        break;
    case "rectangle":
        //output
        Console.WriteLine("Enter the lenght of the sides: ");
        //output
        Console.Write("side A: ");
        //input
        double sideA = double.Parse(Console.ReadLine());
        //output
        Console.Write("side B: ");
        //input
        double sideB = double.Parse(Console.ReadLine());
        //calculations
        area = sideA * sideB;
        break;
    case "circle":
        //output
        Console.Write("Enter the radius: ");
        //input
        double radius = double.Parse(Console.ReadLine());
        //calculations
        area = (radius * radius) * Math.PI;
        break;
    case "triangle":
        //output
        Console.Write("Enter the lenght of the side: ");
        //input
        double Base = double.Parse(Console.ReadLine());
        //output
        Console.Write("Enter the lenght of the height: ");
        //input
        double height = double.Parse(Console.ReadLine());
        //calculations
        area = 0.5 * Base * height;
        break;
    default:
        //output
        Console.WriteLine("Unvalid figure.");
        break;
}
//output
Console.WriteLine("Round of the figure is: " + Math.Round(area, 3));