
int countOfRows = int.Parse(Console.ReadLine());

for (int i = 0; i < countOfRows; i++)
{
    long sum = 0;

    string numbers = Console.ReadLine();
    string[] number = numbers.Split(' ');

    long firstNumber = long.Parse(number[0]);
    long secondNumber = long.Parse(number[1]);

    if (firstNumber > secondNumber)
    {
        for (int j = 0; j < firstNumber.ToString().Length; j++)
        {
            if (firstNumber.ToString()[j] == '-')
            {
                continue;
            }
            else
            {
                sum += firstNumber.ToString()[j] - '0';
            }
        }
    }
    else
    {
        for (int j = 0; j < secondNumber.ToString().Length; j++)
        {
            if (secondNumber.ToString()[j] == '-')
            {
                continue;
            }
            else
            {
                sum += secondNumber.ToString()[j] - '0';
            }
        }
    }
    Console.WriteLine(sum);
}
