namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var result = Result(input[0], input[1]);
            Console.WriteLine(result);
        }

        private static int Result(string word1, string word2)
        {
            var length = Math.Min(word1.Length, word2.Length);
            var result = 0;
            for (var i = 0; i < length; i++){result += word1[i] * word2[i];}
            for (var i = length; i < word1.Length; i++){ result += word1[i];}
            for (var i = length; i < word2.Length; i++){result += word2[i];}

            return result;
        }
    }
}
