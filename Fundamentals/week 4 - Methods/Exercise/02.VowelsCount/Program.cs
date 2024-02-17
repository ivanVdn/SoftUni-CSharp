namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(vowelsCheck(input));


        }

        static int vowelsCheck(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentLetter = input[i].ToString();

                if (currentLetter == "a" || currentLetter == "e" || currentLetter == "u" || currentLetter == "i" ||
                    currentLetter == "o" || currentLetter == "A" || currentLetter == "E" || currentLetter == "U" ||
                    currentLetter == "I" || currentLetter == "O")
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}
