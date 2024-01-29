
var @string = Console.ReadLine();

char[] charArray = @string.ToCharArray();
Array.Reverse(charArray);
var reversedString = new string(charArray);

Console.WriteLine(reversedString);