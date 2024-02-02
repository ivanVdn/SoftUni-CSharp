
int orders = int.Parse(Console.ReadLine());
var price = 0.0;
var total = 0.0;

for (int i = 0; i < orders; i++)
{
    var capsulPrice = double.Parse(Console.ReadLine());
    var days = int.Parse(Console.ReadLine());
    var capsulCount = int.Parse(Console.ReadLine());

    price = ((days * capsulCount) * capsulPrice);
    Console.WriteLine($"The price for the coffee is: ${price:f2}");
    total += price;
}
Console.WriteLine($"Total: ${total:f2}");