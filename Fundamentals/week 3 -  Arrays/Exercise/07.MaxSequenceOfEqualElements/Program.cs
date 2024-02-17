
string[] incoms = Console.ReadLine()
    .Split();
int seqCount = 0;
string seqSimbol = incoms[0]; ;
for (int i = incoms.Length - 1; i >= 0; i--)
{
    int count = 1;
    for (int j = i - 1;j >= 0; j--)
    {
        if (incoms[i] == incoms[j])
        {
            count++;
            if (count >= seqCount) 
            {
                seqCount = count; 
                seqSimbol = incoms[i];
            }
        }
        else 
        {
            break; 
        }
    }
}

string[] result = new string[seqCount];
Array.Fill(result, seqSimbol);
Console.WriteLine(string.Join(" ",result));
/*
for (int i = 0; i < seqCount; i++)
{
    Console.Write($"{seqSimbol} ");
}
*/