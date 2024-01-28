int sequenceLength = int.Parse(Console.ReadLine());

int[] DNA = new int[sequenceLength];
int dnaSum = 0;
int dnaCount = -1;
int dnaStartindex = -1;
int dnaSmples = 0;
int sample = 0;
string command;
while ((command = Console.ReadLine()) != "Clone them!")
{
    sample++;
    int[] currentDNA = command.Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    int currCount = 0;
    int currStartIndex = 0;
    int currEndIndex = 0;
    int currDNASum = 0;
    bool isBeterDNA = false;

    int count = 0;
    for (int i = 0; i < currentDNA.Length; i++)
    {
        if (currentDNA[i] != 1)
        {
            count = 0;
            continue;
        }

        count++;
        if (count > currCount)
        {
            currCount = count;
            currEndIndex = i;
        }
    }
    currStartIndex = currEndIndex - currCount + 1;
    currDNASum = currentDNA.Sum();

    if (currCount > dnaCount)
    {
        isBeterDNA = true;
    }
    else if (currCount == dnaCount)
    {
        if (currStartIndex < dnaStartindex)
        {
            isBeterDNA = true;
        }
        else if (currStartIndex == dnaStartindex)
        {
            if (currDNASum > dnaSum)
            {
                isBeterDNA = true;
            }
        }
    }

    if (isBeterDNA)
    {
        DNA = currentDNA;
        dnaStartindex = currStartIndex;
        dnaCount = currCount;
        dnaSum = currDNASum;
        dnaSmples = sample;
    }
}
Console.WriteLine($"Best DNA sample {dnaSmples} with sum: {dnaSum}.");
Console.WriteLine(string.Join(" ", DNA));
