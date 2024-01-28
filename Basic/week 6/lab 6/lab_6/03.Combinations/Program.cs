/*
 Напишете програма, която изчислява колко решения в естествените числа (включително и нулата) има уравнението:
x1 + x2 + x3 = n
Числото n е цяло число и се въвежда от конзолата. 
*/

//input
int input = int.Parse(Console.ReadLine());
int counter = 0;

//calculation
for (int first = 0; first <= input; first++)
{
    for (int second = 0; second <= input; second++)
    {
        for (int third = 0; third <= input; third++)
        {
            if ((first + second + third) == input)
            {
                //Console.WriteLine($"{first} + {second} + {third} = {first + second + third}");
                counter++;
            }
        }
    }
}

//output
Console.WriteLine(counter);