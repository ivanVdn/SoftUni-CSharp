/*
You will receive two whole numbers from the console representing the start and the end of a sequence of numbers. 
Your task is to print two lines:
•	On the first line, print all numbers from the start of the sequence to the end inclusive.
•	On the second line, print the sum of the sequence in the format: "Sum: {sum}".

*/


var firstNum = int.Parse(Console.ReadLine());
var lastNum = int.Parse(Console.ReadLine());

var sum = 0;


for (int i = firstNum; i <= lastNum; i++)
{
    sum += firstNum;
    Console.Write($"{firstNum} ");
    firstNum++;
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");