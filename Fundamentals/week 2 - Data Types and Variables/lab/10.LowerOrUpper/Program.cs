//65 do 90 uper
//97 do 122 lo


char input = char.Parse(Console.ReadLine());

if (input >= 65 && input <= 90)
{
    Console.WriteLine("upper-case");
}
else if (input >= 97 && input <= 122) 
{
    Console.WriteLine("lower-case");
}