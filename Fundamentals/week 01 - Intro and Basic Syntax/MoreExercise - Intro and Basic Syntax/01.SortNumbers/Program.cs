
int i;
int n = 3;
int[] arr = new int[n + 1];


for (i = 1; i <= n; i++)
{
    arr[i] = Convert.ToInt16(Console.ReadLine());
}

for (i = 1; i <= n; i++)
{
    for (int j = 1; j <= n - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}


for (i = n; i > 0; i--)
{
    Console.WriteLine(arr[i]);
}