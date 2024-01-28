/*
Да се напише програма, която чете час и минути от 24-часово денонощие, въведени от потребителя и изчислява колко ще е часът след 15 минути. 

Резултатът да се отпечата във формат часове:минути. Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59. Часовете се изписват с една или две цифри. Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо. 
*/

//input
int hour = int.Parse(Console.ReadLine());
int minuts = int.Parse(Console.ReadLine())+ 15;

//calculations
if (minuts >= 60)
{
    hour++;
    minuts = minuts % 60;
}
if (hour >= 24)
{
    hour = hour - 24;
}
if (minuts < 10)
{
    Console.WriteLine($"{hour}:0{minuts}");
}
else
{
    Console.WriteLine($"{hour}:{minuts}");
}