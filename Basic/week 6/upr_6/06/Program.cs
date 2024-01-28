/*
Вашата задача е да напишете програма, която да изчислява процента на билетите за всеки тип от продадените билети: студентски(student), стандартен(standard) и детски(kid), за всички прожекции. Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.
*/
/*Вход
Входът е поредица от цели числа и текст:
•	На първия ред до получаване на командата "Finish" - име на филма – текст
•	На втори ред – свободните места в салона за всяка прожекция – цяло число [1 … 100]
•	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
o	Типа на закупения билет - текст ("student", "standard", "kid")
*/
/*Изход
На конзолата трябва да се печатат следните редове:
•	След всеки филм да се отпечата, колко процента от кино залата е пълна
"{името на филма} - {процент запълненост на залата}% full."
•	При получаване на командата "Finish" да се отпечатат четири реда:
o	"Total tickets: {общият брой закупени билети за всички филми}"
o	"{процент на студентските билети}% student tickets."
o	"{процент на стандартните билети}% standard tickets."
o	"{процент на детските билети}% kids tickets."
*/

//input
string filmName = Console.ReadLine();
int totalTickets = 0;
int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;

//calc
while (filmName != "Finish")
{
    int availableSeats = int.Parse(Console.ReadLine());
    int soldTickets = 0;

    string ticketType = Console.ReadLine();

    while (ticketType != "End")
    {
        soldTickets++;

        switch (ticketType)
        {
            case "student":
                studentTickets++;
                break;
            case "standard":
                standardTickets++;
                break;
            case "kid":
                kidTickets++;
                break;
        }

        if (soldTickets >= availableSeats)
        {
            break;
        }

        ticketType = Console.ReadLine();
    }

    double percentageFull = (double)soldTickets / availableSeats * 100;
    Console.WriteLine($"{filmName} - {percentageFull:F2}% full.");

    totalTickets += soldTickets;
    filmName = Console.ReadLine();
}

double studentPercentage = (double)studentTickets / totalTickets * 100;
double standardPercentage = (double)standardTickets / totalTickets * 100;
double kidPercentage = (double)kidTickets / totalTickets * 100;

//output
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{studentPercentage:F2}% student tickets.");
Console.WriteLine($"{standardPercentage:F2}% standard tickets.");
Console.WriteLine($"{kidPercentage:F2}% kids tickets.");
