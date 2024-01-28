/*
Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-малкото измежду тях. Въвежда се по едно число на ред. 
*/

//input
int minNumber = int.MaxValue;
string input = Console.ReadLine();

//calculations
while (input != "Stop")
{
    int curentNumber = int.Parse(input);
    if (minNumber >= curentNumber)
    {
        minNumber = curentNumber;
    }
    input = Console.ReadLine();
}

//output
Console.WriteLine(minNumber);