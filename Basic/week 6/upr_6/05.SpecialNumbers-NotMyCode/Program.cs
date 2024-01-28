/*Да се напише програма, която чете едно цяло число N, въведено от потребителя, и генерира всички възможни "специални" числа от 1111 до 9999. За да бъде "специалнo" едно число, то трябва да отговаря на следното условие: 
•	N да се дели на всяка една от неговите цифри без остатък.
Пример: при N = 16, 2418 е специално число:
•	16 / 2 = 8 без остатък
•	16 / 4 = 4 без остатък
•	16 / 1 = 16 без остатък
•	16 / 8 = 2 без остатък
*/
/*Вход
Входът се чете от конзолата и се състои от едно цяло число в интервала [1…600000]
*/
/*Изход
На конзолата трябва да се отпечатат всички "специални" числа, разделени с интервал
*/


int n = int.Parse(Console.ReadLine());

for (int num = 1111; num <= 9999; num++)
{
    int currentNum = num;
    bool isSpecial = true;

    while (currentNum > 0)
    {
        int digit = currentNum % 10;
        currentNum /= 10;

        if (digit == 0 || n % digit != 0)
        {
            isSpecial = false;
            break;
        }
    }

    if (isSpecial)
    {
        Console.Write($"{num} ");
    }
}

/* решение на колега от курса
 * int number = int.Parse(Console.ReadLine());

for (int firstDigit = 1111 / 1000 % 10; firstDigit <= 9999 / 1000 % 10; firstDigit++)
{
    for (int secondDigit = 1111 / 100 % 10; secondDigit <= 9999 / 100 % 10; secondDigit++)
    {
        for (int thirdDigit = 1111 / 10 % 10; thirdDigit <= 9999 / 10 % 10; thirdDigit++)
        {
            for (int fourthDigit = 1111 % 10; fourthDigit <= 9999 % 10; fourthDigit++)
            {
                if (number % firstDigit == 0 && number % secondDigit == 0 && number % thirdDigit == 0 && number % fourthDigit == 0)
                {
                    Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit} ");
                }
            }
        }
    }
}
*/