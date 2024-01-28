/*
Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден. Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си. Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза през деня и когато постигне целта си да се изписва "Goal reached! Good job!"  и колко стъпки повече е извървяла "{разликата между стъпките} steps over the goal!"
Ако иска да се прибере преди това, тя ще въведе командата "Going home" и ще въведе стъпките, които е извървяла докато се прибира. След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише: "{разликата между стъпките} more steps to reach goal."

*/


//input
bool flag = false;
int steps = 0;
int stepsSum = 0;
int target = 10_000;

//calculations and output


while (true)
{
    string input = Console.ReadLine();
    if (input == "Going home")
    {
        int goHome = int.Parse(Console.ReadLine());
        stepsSum += goHome;
        flag = true;
        break;
    }
    else
    {
        steps = int.Parse(input);
        stepsSum += steps;
        
        if (stepsSum >= target)
        {
            flag = true;
            break;
        }
    }
    


}
if (flag == true)
{
    if (stepsSum >= target)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{stepsSum - target} steps over the goal!");
    }
    else
    {
        Console.WriteLine($"{target - stepsSum} more steps to reach goal.");
    }
}