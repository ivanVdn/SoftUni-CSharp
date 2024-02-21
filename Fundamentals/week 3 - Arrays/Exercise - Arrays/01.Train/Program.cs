int numberOfVagons = int.Parse(Console.ReadLine());

int[] people = new int[numberOfVagons];

int sum = 0;
for (int i = 0; i < numberOfVagons; i++)
{
    int incom = int.Parse(Console.ReadLine());
    people[i] = incom;
}

for (int i = 0;i < people.Length; i++)
{
    Console.Write(people[i] + " ");
    sum += people[i];
}
Console.WriteLine();
Console.WriteLine(sum);