namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());


            PrintChars(firstChar, secondChar);

        }

        static void PrintChars(char firstChar, char secondChar)
        {
            firstChar = SwichCaracters(firstChar, ref secondChar);

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
        }

        static char SwichCaracters(char firstChar, ref char secondChar)
        {
            if ((int)firstChar > (int)secondChar)
            {
                char curent = firstChar;
                firstChar = secondChar;
                secondChar = curent;
            }

            return firstChar;
        }
    }
}
