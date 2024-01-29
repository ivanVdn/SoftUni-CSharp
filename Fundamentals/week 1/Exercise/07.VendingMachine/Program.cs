
double sum = 0.0;

while (true)
{
     var input = Console.ReadLine();
    if (input != "Start")
    {
        double money = double.Parse(input);
        if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1.0 || money == 2.0)
        { 
            sum += money;
        }
        else
        {
            Console.WriteLine($"Cannot accept {money}");
        }
    }
    else if (input == "Start") 
    {
        break; 
    }
}

while (true)
{
    var product = Console.ReadLine();
    var needMoney = 0.0;
    if (product != "End")
    {
    switch (product)
        {
        case "Nuts":
                needMoney = 2;
            break;
        case "Water":
                needMoney = 0.7;
            break;
        case "Crisps":
                needMoney = 1.5;
            break;
        case "Soda":
                needMoney = 0.8;
            break;
        case "Coke":
                needMoney = 1;
            break;
        default:
            Console.WriteLine("Invalid product");
            continue;
        }

        if (sum >= needMoney)
        {
            sum -= needMoney;
            Console.WriteLine($"Purchased {product.ToLower()}");
        }
        else 
        {                 
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine($"Change: {sum:f2}");
        break;
    }
}
