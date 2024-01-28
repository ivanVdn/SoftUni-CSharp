/*
 Напишете програма, която чете цяло число от конзолата и на всеки следващ ред цели числа, докато тяхната сума стане по-голяма или равна на първоначалното число. След приключване да се отпечата сумата на въведените числа
 */


//input
int firstNumber = int.Parse(Console.ReadLine());

//calculations and output
int sum = 0;

while (sum <= firstNumber )
{
    int number = int.Parse(Console.ReadLine());
    sum += number;
    if (sum >= firstNumber)
    {
        break;
    }
}
Console.WriteLine(sum);