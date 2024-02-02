/*
Write a program that receives a single integer and calculates if it's strong or not. A number is strong, if the sum of the factorials of each digit is equal to the number itself.
Example: 145 is a strong number, because 1! + 4! + 5! = 145. 
Print "yes", if the number is strong and "no", if the number is not strong.
*/


var input = int.Parse(Console.ReadLine());

int inputCopy = input;
int facturialSum = 0;

while (inputCopy > 0)
{
    int lastDigit = inputCopy % 10;
    inputCopy /= 10;

    int facturial = 1;
    for (int i = 1; i <= lastDigit; i++)
    {
        facturial *= i;
    }

    facturialSum += facturial;
}

if (facturialSum == input)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
