/*
Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите:
*/
/*
Напишете конзолна програма, която чете име на град (стринг) и обем на продажби (реално число) , въведени от потребителя, и изчислява и извежда размера на търговската комисионна според горната таблица. Резултатът да се изведе форматиран до 2 цифри след десетичната точка. При невалиден град или обем на продажбите (отрицателно число) да се отпечата "error". 
*/

//input
string nameOfCyti   = Console.ReadLine();
double sales        = double.Parse(Console.ReadLine());

//calculations
bool isValid = false;
if (sales < 0)
{
    Console.WriteLine("error");
}
else
{
double comision = 0;
    switch (nameOfCyti)
    {
        /*
        Град/продажби	0 ≤ s ≤ 500	    500 < s ≤ 1 000	    1 000 < s ≤ 10 000	    s > 10 000
        Sofia       	    5%	                7%	                8%	                12%
        Varna        	    4.5%	            7.5%	            10%	                13%
        Plovdiv        	    5.5%	            8%	                12%	                14.5%
        */

        case "Sofia":
            isValid = true;
            if (sales >= 0 && sales <= 500)
            {
                comision = 5;//5
            }
            else if (sales > 500 && sales <= 1_000)
            {
                comision = 7;//7
            }
            else if (sales > 1_000 && sales <= 10_000)
            {
                comision = 8;//8
            }
            else if (sales > 10_000)
            {
                comision = 12;//12
            }
            break;
        case "Varna":
            isValid = true;
            if (sales >= 0 && sales <= 500)
            {
                comision = 4.5;//4.5
            }
            else if (sales > 500 && sales <= 1_000)
            {
                comision = 7.5;//7.5
            }
            else if (sales > 1_000 && sales <= 10_000)
            {
                comision = 10;//10
            }
            else if (sales > 10_000)
            {
                comision = 13;//13
            }
            break;
        case "Plovdiv":
            isValid = true;
            if (sales >= 0 && sales <= 500)
            {
                comision = 5.5;//5.5
            }
            else if (sales > 500 && sales <= 1_000)
            {
                comision = 8;//8
            }
            else if (sales > 1_000 && sales <= 10_000)
            {
                comision = 12;//12
            }
            else if (sales > 10_000)
            {
                comision = 14.5;//14,5
            }
            break;
        default: Console.WriteLine("error"); break;
    }

    if (isValid == true)
    {
        double result = comision * sales / 100;
        Console.WriteLine($"{result:f2}");
    }
}