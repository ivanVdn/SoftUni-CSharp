
decimal budget = decimal.Parse(Console.ReadLine());
decimal spendMonei = 0.0m;

while (true)
{
    decimal gameprice = 0.0m;
    var gameName = Console.ReadLine();
    switch (gameName)
    {
        case "OutFall 4": gameprice = 39.99m; break;
        case "CS: OG": gameprice = 15.99m; break;
        case "Zplinter Zell": gameprice = 19.99m; break;
        case "Honored 2": gameprice = 59.99m; break;
        case "RoverWatch": gameprice = 29.99m; break;
        case "RoverWatch Origins Edition": gameprice = 39.99m; break;
        case "Game Time": Console.WriteLine($"Total spent: ${spendMonei:f2}. Remaining: ${budget:f2}"); return;
        default: Console.WriteLine("Not Found"); continue;
    }

    if (budget >= gameprice)
    {
        budget -= gameprice; 
        spendMonei += gameprice; 
        Console.WriteLine($"Bought {gameName}");
    }
    else
    {
        Console.WriteLine("Too Expensive");
    }

    if (budget <= 0)
    {
        Console.WriteLine($"Out of money!");
        return;
    }

}

double currentBalance = double.Parse(Console.ReadLine());
double spendedMoney = 0;
while (true)
{
    double gamePrice = 0;
    string nameOfGame = Console.ReadLine();
    switch (nameOfGame)
    {
        case "Game Time": Console.WriteLine($"Total spent: ${spendedMoney:f2}. Remaining: ${currentBalance:f2}"); return;
        case "OutFall 4": gamePrice = 39.99; break;
        case "CS: OG": gamePrice = 15.99; break;
        case "Zplinter Zell": gamePrice = 19.99; break;
        case "Honored 2": gamePrice = 59.99; break;
        case "RoverWatch": gamePrice = 29.99; break;
        case "RoverWatch Origins Edition": gamePrice = 39.99; break;
        default: Console.WriteLine("Not Found"); continue;
    }

}