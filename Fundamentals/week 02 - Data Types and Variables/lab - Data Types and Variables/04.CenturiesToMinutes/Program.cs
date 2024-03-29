// 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes


byte centuries = byte.Parse(Console.ReadLine());
ushort years = (ushort)(centuries * 100);
uint days = (uint)(years * 365.2422);
ulong hours = (ulong)(days * 24);
ulong minutes = hours * 60;

Console.WriteLine($"{centuries} centuries = {years} years = {days:f0} days = {hours} hours = {minutes} minutes");
