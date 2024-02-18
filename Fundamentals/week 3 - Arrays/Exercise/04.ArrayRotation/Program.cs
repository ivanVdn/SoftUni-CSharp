
string[] incomArr = Console.ReadLine()
    .Split()
    .ToArray();
int rotation = int.Parse(Console.ReadLine());

while (rotation > 0 )
{
    rotation--;
    for (int i = 0; i < incomArr.Length - 1; i++)
    {
        string old = incomArr[i];
        incomArr[i] = incomArr[i + 1];
        incomArr[i + 1] = old;
    }
}
Console.WriteLine(string.Join(" ", incomArr));