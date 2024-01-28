
/*
Напишете програма, която чете продукт (низ), град (низ) и количество (десетично число), въведени от потребителя, и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения град.  
*/
//input
string product = Console.ReadLine();
string cyti = Console.ReadLine();
double countOfProducts = double.Parse(Console.ReadLine());

//calculations
switch (cyti) 
{
/*
град / продукт	coffee	water	beer	sweets	peanuts
Sofia	        0.50	0.80	1.20	1.45	1.60
Plovdiv	        0.40	0.70	1.15	1.30	1.50
Varna	        0.45	0.70	1.10	1.35	1.55
*/
    case "Sofia":
        switch (product)
        {
            case "coffee":Console.WriteLine($"{countOfProducts * 0.50:f2}");break;
            case "water":Console.WriteLine($"{countOfProducts * 0.80:f2}"); break;
            case "beer": Console.WriteLine($"{countOfProducts * 1.20:f2}"); break;
            case "sweets": Console.WriteLine($"{countOfProducts * 1.45:f2}"); break;
            case "peanuts": Console.WriteLine($"{countOfProducts * 1.60:f2}"); break;
        } 
        break;
    case "Plovdiv":
        switch (product)
        {
            case "coffee": Console.WriteLine($"{countOfProducts * 0.40:f2}"); break;
            case "water": Console.WriteLine($"{countOfProducts * 0.70:f2}"); break;
            case "beer": Console.WriteLine($"{countOfProducts * 1.15:f2}"); break;
            case "sweets": Console.WriteLine($"{countOfProducts * 1.30:f2}"); break;
            case "peanuts": Console.WriteLine($"{countOfProducts * 1.50:f2}"); break;
        }
        break;
    case "Varna":
        switch (product)
        {
            case "coffee": Console.WriteLine($"{countOfProducts * 0.45:f2}"); break;
            case "water": Console.WriteLine($"{countOfProducts * 0.70:f2}"); break;
            case "beer": Console.WriteLine($"{countOfProducts * 1.10:f2}"); break;
            case "sweets": Console.WriteLine($"{countOfProducts * 1.35:f2}"); break;
            case "peanuts": Console.WriteLine($"{countOfProducts * 1.55:f2}"); break;
        }
        break;
}