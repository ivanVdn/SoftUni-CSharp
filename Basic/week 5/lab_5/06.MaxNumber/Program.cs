/*
Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-голямото измежду тях. Въвежда се по едно число на ред. 
*/

//input
int maxNumber = int.MinValue;
string input = Console.ReadLine();

//calculations
while (input != "Stop")
{
    int curentNumber = int.Parse(input);
    if (maxNumber <= curentNumber)
    {
        maxNumber = curentNumber;
    }
    input = Console.ReadLine();
}

//output
Console.WriteLine(maxNumber);
