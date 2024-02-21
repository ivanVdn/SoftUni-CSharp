
int key = int.Parse(Console.ReadLine());
int numberOfLines = int.Parse(Console.ReadLine());
string msg = "";

for (int i = 0; i < numberOfLines; i++)
{
    char chars = char.Parse(Console.ReadLine());
    msg += (char)((int)chars + key);
}

Console.WriteLine(msg);