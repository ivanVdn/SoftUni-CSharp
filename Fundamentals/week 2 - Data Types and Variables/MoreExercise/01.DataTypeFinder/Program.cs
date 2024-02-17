while (true)
{   
    string input = Console.ReadLine();
    if (input == "END")
    {
        break;
    }
    else if (int.TryParse(input, out int toInt))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (double.TryParse(input, out double toDouble))
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else if (char.TryParse(input, out char tosChar))
    {
        Console.WriteLine($"{input} is character type");
    }
    else if (bool.TryParse(input, out bool toBool))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }
}