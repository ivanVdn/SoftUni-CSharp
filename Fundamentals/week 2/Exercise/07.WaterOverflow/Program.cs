int count = int.Parse(Console.ReadLine());
int curentLitres = 0;

for (int i = 0; i < count; i++)
{
    int entredtLitres = int.Parse(Console.ReadLine());

    if (entredtLitres <= (255 - curentLitres))
    {
        curentLitres += entredtLitres;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}
Console.WriteLine(curentLitres);
