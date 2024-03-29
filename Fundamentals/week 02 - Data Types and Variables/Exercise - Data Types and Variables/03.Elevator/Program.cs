
// n / p = x cealing


int numberOfPeople = int.Parse(Console.ReadLine());
int capacitiOfElevator = int.Parse(Console.ReadLine());

int curses = (int)Math.Ceiling((double)numberOfPeople / capacitiOfElevator);

Console.WriteLine(curses);
