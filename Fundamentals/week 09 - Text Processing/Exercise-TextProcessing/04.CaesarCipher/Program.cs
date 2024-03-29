namespace _04.CaesarCipher
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input == null) return;
            foreach (var n in input.Select(c => (int)c + 3))
            {
                Console.Write((char)n);
            }
        }
    }
}
