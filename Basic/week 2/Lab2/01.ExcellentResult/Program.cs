/*
Първата задача от тази тема е да се напише конзолна програма, 
която чете оценка (дробно число), въведена от потребителя 
и отпечатва "Excellent!", ако оценката е 5.50 или по-висока.
*/
//input
double num = double.Parse(Console.ReadLine());

//calculations

//output
if (num >= 5.50)
{
    Console.WriteLine("Excellent!");
}
