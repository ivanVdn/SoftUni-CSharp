/*
 Иван решава да подобри Световния рекорд по плуване на дълги разстояния.На конзолата се въвежда 
рекордът в секунди, който Иван трябва да подобри,  
разстоянието в метри, което трябва да преплува и 
времето в секунди, за което плува разстояние от 1 м. 
Да се напише програма, която изчислява дали се е справил със задачата, като се има предвид, че: 
съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди.
Когато се изчислява колко пъти Иванчо ще се забави, в резултат на съпротивлението на водата, резултатът трябва да се закръгли надолу до най-близкото цяло число.
*/
/*
Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд.
*/

//input
double curentWorldRecord = double.Parse(Console.ReadLine());    //seconds
double distansInMetrs = double.Parse(Console.ReadLine());       //metres
double timeToSwimOneMeter = double.Parse(Console.ReadLine());    //time it takes to swim one meter in seconds

//calculation
double delay = (Math.Floor((distansInMetrs / 15))) * 12.5;
double swimerTime = (distansInMetrs * timeToSwimOneMeter) + delay;

//output
if (swimerTime < curentWorldRecord)
{
    Console.WriteLine($"Yes, he succeeded!The new world record is {swimerTime:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {swimerTime - curentWorldRecord:f2} seconds slower.");
}
