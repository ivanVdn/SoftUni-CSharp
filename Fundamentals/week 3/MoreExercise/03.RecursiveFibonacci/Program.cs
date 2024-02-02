
int number = int.Parse(Console.ReadLine());
long prevNumb = 1;
long pevPrevNumb = 1;

for (int i = 2; i < number; i++)
{
    long curNumb = prevNumb + pevPrevNumb;
    pevPrevNumb = prevNumb;
    prevNumb = curNumb;
}

Console.WriteLine(prevNumb);