
var budjet = double.Parse(Console.ReadLine());
var students = int.Parse(Console.ReadLine());
var lightsabersPrice = double.Parse(Console.ReadLine());
var robesPrice = double.Parse(Console.ReadLine());
var beltsPrice = double.Parse(Console.ReadLine());

var spendMoney = 0.0;

var belts = students;
var lightsabers = Math.Ceiling(students + students * 0.1);

for (int i = belts; i > 0; i--)
{
    if (i % 6 == 0)
    {
        belts -= 1;
    }
}

spendMoney = (lightsabers * lightsabersPrice) + (students * robesPrice) + (belts * beltsPrice);
var diferenc = budjet - spendMoney;

if (spendMoney <= budjet)
{
    Console.WriteLine($"The money is enough - it would cost {spendMoney:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {Math.Abs(diferenc):f2}lv more.");
}
