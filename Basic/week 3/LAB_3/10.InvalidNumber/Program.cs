/*
Дадено число е валидно, ако е в диапазона [100…200] или е 0. Да се напише програма, която чете цяло число, въведено от потребителя, и печата "invalid" ако въведеното число не е валидно. 
*/



//input
int number = int.Parse(Console.ReadLine());
/*

 * решение от видеото

//calculations and output
bool isValid = number >= 100 && number <= 200 || number == 0;

if (!isValid)
{
    Console.WriteLine("invalid");
}
*/

/* 
 * мое решение 
 */
if (number >= 100 && number <= 200 || number == 0)
{
}
else
{
    Console.WriteLine("invalid");
}


/* 

 * не работи вярно

if (number < 100 && number > 200 || number != 0)
{
    Console.WriteLine("invalid");
}
*/


