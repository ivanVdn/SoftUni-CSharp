/*
Поканени сте на 30-ти рожден ден, на който рожденикът черпи с огромна торта. Той обаче не знае колко парчета могат да си вземат гостите от нея. Вашата задача е да напишете програма, която изчислява броя на парчетата, които гостите са взели, преди тя да свърши. Ще получите размерите на тортата (широчина и дължина – цели числа в интервала [1...1000]) и след това на всеки ред, до получаване на командата "STOP" или докато не свърши тортата, броят на парчетата, които гостите вземат от нея. 
Бележка: Едно парче торта е с размер 1х1 см.
Да се отпечата на конзолата един от следните редове:
•	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
•	"No more cake left! You need {брой недостигащи парчета} pieces more."
*/


//input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());

bool flag = false;
int numberOfPice = 0;
int remainingPices = 0;
int allPieceOfCake = length * width;

//calc
remainingPices = allPieceOfCake;

while (true)
{
    string input = Console.ReadLine();
    if (input == "STOP")
    {
        flag = true;
        break; 
    }
    else
    {
        numberOfPice = int.Parse(input);
        remainingPices -= numberOfPice;
        
        if (remainingPices <= 0)
        {
            flag = true;
            break;
        }        
    }
}

//output
if (flag == true)
{
    if (remainingPices <= 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(remainingPices)} pieces more.");
        //Console.WriteLine($"no more {Math.Abs(remainingPices)}");
    }
    else
    {
        Console.WriteLine($"{remainingPices} pieces are left.");
        //Console.WriteLine($"more {remainingPices}");
    }
}

