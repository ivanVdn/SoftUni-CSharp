
int[] incomingArrInts = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int length = (incomingArrInts.Length / 4);
int count;

int[] left = new int[length];
int[] revLeft = new int[length];
int[] right = new int[length];
int[] middle = new int[length * 2];
int[] leftAndRight = new int[length * 2];  //revLeftInt + rightInt
int[] result = new int[length * 2];

for (int i = 0; i < length; i++)
{
    left[i] = incomingArrInts[i];
}

count = 0;
for (int i = 0; i < length; i++)
{
    count++;
    revLeft[i] = left[length - count];
}

count = 0;
for (int i = length - 1; i >= 0; i--)
{
    count++;
    right[i] = incomingArrInts[(length * 4) - count];
}

for (int i = 0; i < length; i++)
{
    leftAndRight[i] = revLeft[i];
}

count = 0;
for (int i = length; i < length * 2; i++)
{
    count++;
    leftAndRight[i] = right[length - count];
}

for (int i = length; i < incomingArrInts.Length - length; i++)
{
    middle[i - length] = incomingArrInts[i];
}

for (int i = 0; i < length * 2; i++)
{
    result[i] = middle[i] + leftAndRight[i];
}

Console.WriteLine(string.Join(" ", result));

