
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int countOfTargets = 0;
int copyOfN = N;

while (N >= M)
{
    N -= M;
    if (N == (copyOfN * 0.5))
    {
        if (Y != 0)
        {
            int res = N / Y;
            if (res >= 0 && Y != 0)
            {
                N = res;
            }
        }
    }
    countOfTargets++;
}
Console.WriteLine(N);
Console.WriteLine(countOfTargets);

