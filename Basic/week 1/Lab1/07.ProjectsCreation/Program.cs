//input

string name = Console.ReadLine();
int projects = int.Parse(Console.ReadLine());

//calculations

int hours = projects * 3;

//output

Console.WriteLine($"The architect {name} will need {hours} hours to complete {projects} project/s.");