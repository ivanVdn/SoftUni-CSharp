namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var words = Console.ReadLine()?.Split().ToArray();
            var result = string.Empty;

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result);
        }
    }
}
