
double priceOfParty = double.Parse(Console.ReadLine());
int countOfLovlyMsg = int.Parse(Console.ReadLine());
int countOfRoses = int.Parse(Console.ReadLine());
int countkeyHolders = int.Parse(Console.ReadLine());
int countOfBatPictures = int.Parse(Console.ReadLine());
int countOfSurprise = int.Parse(Console.ReadLine());


double sum = countOfLovlyMsg * 0.6 + countOfRoses * 7.2 + countOfBatPictures * 18.20 + countOfSurprise * 22.00 + countkeyHolders * 3.6;

if ((countOfLovlyMsg + countOfRoses + countOfBatPictures + countOfSurprise + countkeyHolders) >= 25)
{
    sum *= 0.65;
}

sum *= 0.9;
if (priceOfParty <= sum)
{
    Console.WriteLine($"Yes! {sum - priceOfParty:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {priceOfParty - sum:f2} lv needed.");
}
