/*
 Напишете програма която проверява всички възможни комбинации от двойка числа в интервала от две дадени числа. На изхода се отпечатва, коя поред е комбинацията чиито сбор от числата е равен на дадено магическо число. Ако няма нито една комбинация отговаряща на условието се отпечатва съобщение, че не е намерено.
*/
/* Вход
Входът се чете от конзолата и се състои от три реда:
•	Първи ред – начало на интервала – цяло число в интервала [1...999]
•	Втори ред – край на интервала – цяло число в интервала [по-голямо от първото число...1000]
•	Трети ред – магическото число – цяло число в интервала [1...10000]
*/
/* Изход
На конзолата трябва да се отпечата един ред, според резултата:
•	Ако е намерена комбинация чиито сбор на числата е равен на магическото число
o	"Combination N:{пореден номер} ({първото число} + {второ число} = {магическото число})"
•	Ако не е намерена комбинация отговаряща на условието
o	"{броят на всички комбинации} combinations - neither equals {магическото число}"
*/


// input
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int magikNumber = int.Parse(Console.ReadLine());

//calculations
int counter = 0;
//bool isFound = false;
int test = 0;
for (int i = firstNumber; i <= secondNumber; i++)
{
    for (int j = firstNumber; j <= secondNumber; j++)
    {
        counter++;
        if (i + j == magikNumber)
        {
            Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magikNumber})");
            test = 1;
            //isFound = true;
            break;

        }
    }

    if (test == 1)
    //if (isFound)
    {
        break;
    }
}

if (test == 0)
//if (!isFound)
{
    Console.WriteLine($"{counter} combinations - neither equals {magikNumber}");
}
