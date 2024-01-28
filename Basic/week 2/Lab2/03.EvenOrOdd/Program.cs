/*
Да се напише програма, която чете цяло число, въведено 
от потребителя, и печата дали е четно или нечетно. 
Ако е четно отпечатайте "even", ако е нечетно "odd".
*/

//input
int number = int.Parse(Console.ReadLine());

//calculations

//output
if ((number % 2) != 0)
{
    Console.WriteLine("odd");
}
else
{
    Console.WriteLine("even");
}