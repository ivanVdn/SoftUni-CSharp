namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? word;
            while ((word = Console.ReadLine()) != "end")
            {
                //var currentWord = new char[word.Length];
                //for (int i = 0; i < word.Length; i++)
                //{
                //    currentWord[i] = word[word.Length - i - 1];
                //}

                var reversed = word.Reverse().ToArray();

                Console.WriteLine($"{word} = {new string(reversed)}");
            }
        }
    }
}
