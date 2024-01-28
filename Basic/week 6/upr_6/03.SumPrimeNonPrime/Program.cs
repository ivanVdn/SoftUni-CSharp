/*Суми прости и непрости числа
Напишете програма, която чете от конзолата цели числа в диапазона, докато не се получи команда "stop". Да се намери сумата на всички въведени прости и сумата на всички въведени непрости числа. Тъй като по дефиниция от математиката отрицателните числа не могат да бъдат прости, ако на входа се подаде отрицателно число да се изведе следното съобщение "Number is negative.". В този случай въведено число се игнорира и не се прибавя към нито една от двете суми, а програмата продължава своето изпълнение, очаквайки въвеждане на следващо число. 
*/
/* Изход
На изхода да се отпечатат на два реда двете намерени суми в следния формат:
•	"Sum of all prime numbers is: {prime numbers sum}"
•	"Sum of all non prime numbers is: {nonprime numbers sum}"
*/
int primeNumbersSum = 0;
int nonPrimeNumbersSum = 0;

while (true)
{
    string input = Console.ReadLine();
    if (input == "stop") { break; }
    int number = int.Parse(input);

    if (number < 0) { Console.WriteLine("Number is negative."); continue; }

    bool itsNumberPrime = true;
    for (int i = 2; i<number; i++)
    {
        if (number % i == 0)
        {
            //non prime
            itsNumberPrime = false;
            break;
        }
    }
    if (itsNumberPrime)
    {
        primeNumbersSum += number;
    }
    else
    {
        nonPrimeNumbersSum += number;
    }
}

Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");