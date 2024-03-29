int numberOfBrackets = int.Parse(Console.ReadLine());
int closing = 0;
int opening = 0;
string word = "";
bool isClosincfirst = false;

for (int i = 0; i < numberOfBrackets; i++)
{
    string input = Console.ReadLine();

    word += input;

    if (input == "(")
    {
        opening++;
    }
    else if (input == ")")
    {
        closing++;
    }

    if (closing > opening)
    {
        isClosincfirst = true;
    }
}

if (!isClosincfirst)
{
    if (opening == closing)
    {
        Console.WriteLine("BALANCED");
    }
    else
    {
        Console.WriteLine("UNBALANCED");
    }
}
else
{
    Console.WriteLine("UNBALANCED");
}
