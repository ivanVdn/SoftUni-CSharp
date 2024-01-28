/* Еднакви суми на четни и нечетни позиции
Напишете програма, която чете от конзолата две шестцифрени цели числа в диапазона от 100000 до 300000. Винаги първото въведено число ще бъде по малко от второто. На конзолата да се отпечатат на 1 ред разделени с интервал всички числа, които се намират между двете, прочетени от конзолата числа и отговарят на следното условие:

•	сумата от цифрите на четни и нечетни позиции да са равни. Ако няма числа, отговарящи на условието на конзолата не се извежда резултат. 
*/


//input
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

//calculation
for (int number = start; number <= end; number++)
{
    string numberText = number.ToString();
    int sumOdd = 0;
    int sumEven = 0;


    for (int charPosition = 0; charPosition < numberText.Length; charPosition++)
    {
        int digit = int.Parse(numberText[charPosition].ToString());
        if (charPosition % 2 == 0)
        {
            sumEven += digit;
        }
        else
        {
            sumOdd += digit;
        }
    }
    if (sumOdd == sumEven)
    {
        Console.Write($"{number} ");
    }
}
