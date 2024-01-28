//input
int degrees = int.Parse(Console.ReadLine());
string time = Console.ReadLine();
string shoes = "";
string outfit = "";

//calculation
switch (time)
{
    case "Morning":
        (outfit, shoes) = degrees switch
        {
            >= 10 and <= 18 => ("Sweatshirt", "Sneakers"),
            > 18 and <= 24 => ("Shirt", "Moccasins"),
            > 24 => ("T-Shirt", "Sandals"),
        };
        break;
    case "Afternoon":
        (outfit, shoes) = degrees switch
        {
            >= 10 and <= 18 => ("Shirt", "Moccasins"),
            > 18 and <= 24 => ("T-Shirt", "Sandals"),
            > 24 => ("Swim Suit", "Barefoot"),
        };
        break;
    case "Evening":
        outfit = "Shirt";
        shoes = "Moccasins";
        break;
}

//output
Console.WriteLine($" It's {degrees} degrees, get your {outfit} and {shoes}.");




/*
if (time == "Morning")
{
    if (degrees >= 10 && degrees <= 18)
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (degrees > 18 && degrees <= 24)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees >= 25)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
}
else if (time == "Afternoon")
{
    if (degrees >= 10 && degrees <= 18)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees > 18 && degrees <= 24)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (degrees >= 25)
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
}
else if (time == "Evening")
{
    outfit = "Shirt";
    shoes = "Moccasins";
}
Console.WriteLine($" It's {degrees} degrees, get your {outfit} and {shoes}.");
*/