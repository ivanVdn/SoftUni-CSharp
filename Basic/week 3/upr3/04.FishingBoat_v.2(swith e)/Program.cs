//input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

//cslculations
(string destination, string place, double sum) = budget switch
{
    <= 100 when season == "summer" => ("Bulgaria", "Camp", (budget * 0.30)),
    > 100 and <= 1000 when season == "summer" => ("Balkans", "Camp", (budget * 0.40)),
    <= 100 when season == "winter" => ("Bulgaria", "Hotel", (budget * 0.70)),
    > 100 and <= 1000 when season == "winter" => ("Balkans", "Hotel", (budget * 0.80)),
    _ => ("Europe", "Hotel", (budget * 0.90))
};

//output
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{place} - {sum:f2}");