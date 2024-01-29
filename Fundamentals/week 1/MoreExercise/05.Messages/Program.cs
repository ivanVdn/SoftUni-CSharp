
var input = int.Parse(Console.ReadLine());
var msg = string.Empty;

for (int i = 0; i < input; i++)
{
    var lethers = int.Parse(Console.ReadLine());
    var digit = lethers % 10;
    var strLengh = lethers.ToString().Length;
    var key = ' ';

    switch (digit)
    {
    case 0:
        key = ' ';
    break;
    case 2:
        if (strLengh == 1) { key = 'a'; }
        if (strLengh == 2) { key = 'b'; }
        if (strLengh == 3) { key = 'c'; }
    break;
    case 3:
        if (strLengh == 1) { key = 'd'; }
        if (strLengh == 2) { key = 'e'; }
        if (strLengh == 3) { key = 'f'; }
        break;
    case 4:
        if (strLengh == 1) { key = 'g'; }
        if (strLengh == 2) { key = 'h'; }
        if (strLengh == 3) { key = 'i'; }
        break;
    case 5:
        if (strLengh == 1) { key = 'j'; }
        if (strLengh == 2) { key = 'k'; }
        if (strLengh == 3) { key = 'l'; }
        break;
    case 6:
        if (strLengh == 1) { key = 'm'; }
        if (strLengh == 2) { key = 'n'; }
        if (strLengh == 3) { key = 'o'; }
        break;
    case 7:
        if (strLengh == 1) { key = 'p'; }
        if (strLengh == 2) { key = 'q'; }
        if (strLengh == 3) { key = 'r'; }
        if (strLengh == 4) { key = 's'; }
        break;
    case 8:
        if (strLengh == 1) { key = 't'; }
        if (strLengh == 2) { key = 'u'; }
        if (strLengh == 3) { key = 'v'; }
        break;
    case 9:
        if (strLengh == 1) { key = 'w'; }
        if (strLengh == 2) { key = 'x'; }
        if (strLengh == 3) { key = 'y'; }
        if (strLengh == 4) { key = 'z'; }
        break;
    }
    msg += key.ToString();
}
Console.WriteLine(msg);