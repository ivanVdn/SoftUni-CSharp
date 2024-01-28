/*
Напишете програма, която чете от конзолата плод (banana / apple / orange / grapefruit / kiwi / pineapple / grapes), ден от седмицата (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество (реално число) , въведени от потребителя, и пресмята цената според цените от таблиците по-горе. Резултатът да се отпечата закръглен с 2 цифри след десетичната точка. При невалиден ден от седмицата или невалидно име на плод да се отпечата "error". 
*/

//input
string fruitType = Console.ReadLine();
string dayOfWeek   = Console.ReadLine();
double numberOfFruits = double.Parse(Console.ReadLine());

//calculations
double price = 0;
switch (dayOfWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruitType)
        {
            /*
                Магазин за плодове през работните дни работи на следните цени:
                плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
                цена	2.50	1.20	0.85	1.45	    2.70	5.50	    3.85
                */
            case "banana": Console.WriteLine($"{numberOfFruits * 2.50:f2}"); break;
            case "apple": Console.WriteLine($"{numberOfFruits * 1.20:f2}"); break;
            case "orange": Console.WriteLine($"{numberOfFruits * 0.85:f2}"); break;
            case "grapefruit": Console.WriteLine($"{numberOfFruits * 1.45:f2}"); break;
            case "kiwi": Console.WriteLine($"{numberOfFruits * 2.70:f2}"); break;
            case "pineapple": Console.WriteLine($"{numberOfFruits * 5.50:f2}"); break;
            case "grapes": Console.WriteLine($"{numberOfFruits * 3.85:f2}"); break;
            default: Console.WriteLine("error"); break;
        }
        break;
    case "Saturday":
    case "Sunday":
        switch (fruitType)
        {
            /*
                Събота и неделя магазинът работи на по-високи цени:
                плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
                цена	2.70	1.25	0.90	1.60	    3.00	5.60	    4.20
                */
            case "banana": price = 2.70; break;
            case "apple": price = 1.25; break;
            case "orange": price = 0.90; break;
            case "grapefruit": price = 1.60; break;
            case "kiwi": price = 3.00; break;
            case "pineapple": price = 5.60; break;
            case "grapes": price = 4.20; break;
            default: Console.WriteLine("error"); break;
        }
        Console.WriteLine($"{numberOfFruits * price:f2}");
        break;
    default: Console.WriteLine("error"); break;
}
