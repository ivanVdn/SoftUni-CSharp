﻿
int counter = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < counter; i++)
{
    char input = char.Parse(Console.ReadLine());
    sum += input;
}
Console.WriteLine($"The sum equals: {sum}");