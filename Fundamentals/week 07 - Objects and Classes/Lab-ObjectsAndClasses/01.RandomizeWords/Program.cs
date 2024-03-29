namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()?.Split().ToArray();

            var random = new Random();

            for (var i = 0; i < text.Length; i++)
            {
                var randomIndex = random.Next(text.Length);
                var word = text[i];
                var randomWord = text[randomIndex];

                text[i] = randomWord;
                text[randomIndex] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine, text));
        }
    }
}