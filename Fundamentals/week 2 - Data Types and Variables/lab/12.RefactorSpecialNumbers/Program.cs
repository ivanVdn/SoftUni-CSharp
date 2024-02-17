

int input = int.Parse(Console.ReadLine());
bool isTrue = false;

for (int count = 1; count <= input; count++)
{
    int sumOfDigits = 0;
    int countCopy = count;
    while (count > 0)
    {
        sumOfDigits += count % 10;
        count /= 10;
    }
    isTrue = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
    Console.WriteLine($"{countCopy} -> {isTrue}");
    count = countCopy;
}

