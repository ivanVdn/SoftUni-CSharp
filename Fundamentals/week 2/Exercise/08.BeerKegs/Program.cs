
int count = int.Parse(Console.ReadLine());
double curentVolume = 0;
string curentModel = "";

for (int i = 0; i < count; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    uint height = uint.Parse(Console.ReadLine());
    double volume = Math.PI * Math.Pow(radius, 2) * height;
    if (curentVolume <= volume)
    {
        curentVolume = volume;
        curentModel = model;
    }
}
Console.WriteLine(curentModel);
