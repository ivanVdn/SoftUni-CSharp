
/*
Acer
login
go
let me in
recA

*********
momo
omom

*******
sunny
rainy
cloudy
sunny
not sunny

*/

var username = Console.ReadLine();

char[] charArray = username.ToCharArray();
Array.Reverse(charArray);
var reversedUsername = new string(charArray);
int count = 0;

for (int i = 0; i<=3; i++)
{
    count++;
    var password = Console.ReadLine();

    if (password == reversedUsername)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    else
    {
        if (count <= 3)
        {
            Console.WriteLine($"Incorrect password. Try again.");
        }
        else
        {
            Console.WriteLine($"User {username} blocked!");
        }
    }
}