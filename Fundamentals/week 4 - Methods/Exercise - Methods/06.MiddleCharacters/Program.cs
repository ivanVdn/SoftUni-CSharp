using System;

string input = Console.ReadLine();

ReturnMiddleChar(input);

void ReturnMiddleChar(string input)
{
    int midIndex = input.Length / 2;

    if (input.Length % 2 == 0)
    {
        char firstChar = input[midIndex - 1];
        char secondChar = input[midIndex];
        Console.WriteLine($"{firstChar}{secondChar}");
    }
    else
    {
        char midChar = input[midIndex];
        Console.WriteLine(midChar);
    }
}
