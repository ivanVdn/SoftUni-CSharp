/*
Напишете програма, която чете две цели числа (N1 и N2) и оператор, с който да се извърши дадена математическа операция с тях. Възможните операции са: Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%). При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен. 

При обикновеното деление – резултата. При модулното деление – остатъка. Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели. В този случай трябва да се отпечата специално съобщениe.
*/
/*
Вход
От конзолата се прочитат 3 реда, въведени от потребителя:
•	N1 – цяло число в интервала [0...40 000]
•	N2 – цяло число в интервала [0...40 000]
•	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
*/
/*
Изход
Да се отпечата на конзолата един ред:
•	Ако операцията е деление:
        "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
•	Ако операцията е модулно деление: 
        "{N1} % {N2} = {остатък}"
•	В случай на деление с 0 (нула): 
        "Cannot divide {N1} by zero"
*/


//input
//Console.WriteLine("Enter an integer in the range [0...40000]");
int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter an another integer in the range [0...40000]");
int number2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter operator - one character among: +, -, *, / or %");
string op = Console.ReadLine();

double result = 0.0;
bool itsTrue = false;
string ok = "";
//calculation
switch (op)
{
    case "+":
        result = number1 + number2;
        itsTrue = true;
        ok = "ok";
        break;
    case "-":
        result = number1 - number2;
        itsTrue = true;
        ok = "ok";
        break;
    case "*":
        result = number1 * number2;
        itsTrue = true;
        ok = "ok";
        break;
    case "%":
    case "/":
        if (number2 == 0)
        {
            Console.WriteLine($"Cannot divide {number1} by zero");
        }
        else if (op == "%")
        {
            result = number1 % number2;
            itsTrue = true;
        }
        else if (op == "/")
        {
            result = number1 / (double)number2;
            Console.WriteLine($"{number1} {op} {number2} = {result:f2}");
        }
        break;
}
//output
if (itsTrue) 
{
    if ((result % 2 == 0) && (ok == "ok"))
    { 
        Console.WriteLine($"{number1} {op} {number2} = {(int)result} - even");
    }
    else if ((result % 2 != 0) && (ok == "ok"))
    {
        Console.WriteLine($"{number1} {op} {number2} = {(int)result} - odd");
    }
    else
    {
        Console.WriteLine($"{number1} {op} {number2} = {(int)result}");
    }
}
