//input
if (int.TryParse(Console.ReadLine(), out int promenliva))
{
    //calculations
    double a = ((promenliva / 2) * (promenliva / 2)) / 4;


    if (a % 2 == 1)   /*(promenliva % 2 == 0)*/
    {
        //output
        Console.WriteLine("прати Ани да си чете книгата");
    }
    else
    {
        //output
        Console.WriteLine("прати Ани да си чисти стаята");
    }
}

else
{
    //output
    Console.WriteLine("Грешка при въвеждане на числото.");
}