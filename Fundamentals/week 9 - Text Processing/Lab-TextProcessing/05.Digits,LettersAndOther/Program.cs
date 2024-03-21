using System.Text;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var digit = string.Empty;
            var letter = string.Empty; 
            var other = string.Empty;

            foreach (var chars in input)
            {
                if (char.IsDigit(chars))
                {
                    digit += chars;
                }
                else if (char.IsLetter(chars))
                {
                    letter += chars;
                }
                else
                {
                    other += chars;
                }
            }

            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(other);


        }
    }
}
