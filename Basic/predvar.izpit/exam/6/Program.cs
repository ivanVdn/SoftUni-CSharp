
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());



for (int i = 2; i <= first; i+=2)
{
	for (int j = 2; j <= second; j++)
	{
		if (j == 4 || j == 6 || j == 8 || j == 9)
		{
			continue;
		}
			
		for (int k = 2; k <= third; k+=2)
		{
            Console.WriteLine($"{i} {j} {k}");
        }
	} 

}
