/*
Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой вноски. На всеки ред ще получавате сумата, която трябва да внесете в сметката, до получаване на команда "NoMoreMoney" . При всяка получена сума на конзолата трябва да се извежда "Increase: " + сумата и тя да се прибавя в сметката. Ако получите число по-малко от 0 на конзолата трябва да се изведе "Invalid operation!" и програмата да приключи. Когато програмата приключи трябва да се принтира "Total: " + общата сума в сметката форматирана до втория знак след десетичната запетая. 
*/

//input
double balance = 0;
string input = Console.ReadLine();

//calculations
while (input != "NoMoreMoney")
{
    double curentMoney = double.Parse(input);
    if (curentMoney < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    balance += curentMoney;
    Console.WriteLine($"Increase: {balance:f2}");
    input = Console.ReadLine();
}

//output
Console.WriteLine($"Total: {balance:f2}");

/*
//input, calculations and output
decimal totalAmount = 0;
while (true)
{
    string input = Console.ReadLine();
    if (input == "NoMoreMoney")
    {
        break;
    }

    decimal amount;

    if (decimal.TryParse(input, out amount))
    {
        if (amount >= 0)
        {
            Console.WriteLine($"Increase: {amount:f2}");
            totalAmount += amount;
        }
        else
        {
            Console.WriteLine("Invalid operation!");
            Console.WriteLine($"Total: {totalAmount:F2}");
            return;
        }
    }
    else
    {
        Console.WriteLine("Invalid input! Please enter a valid number or 'NoMoreMoney'.");
    }
}
Console.WriteLine($"Total: {totalAmount:F2}"); 
*/