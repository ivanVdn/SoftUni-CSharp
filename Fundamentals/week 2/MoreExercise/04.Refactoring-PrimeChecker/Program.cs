
int count = int.Parse(Console.ReadLine());
for (int i = 2; i <= count; i++)
{
    bool isPrime = false;
    for (int cepitel = 2; cepitel < i; cepitel++)
    {
        if (i % cepitel == 0)
        {
            isPrime = true;
            break;
        }
    }
    bool reversed = !isPrime;
    string fromBool = reversed.ToString().ToLower();

    Console.WriteLine($"{i} -> {fromBool}");
}
