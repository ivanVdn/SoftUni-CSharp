namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var banned = Console.ReadLine().Split(", ");
            var text = Console.ReadLine();
            int n = 0;
            foreach (var t in banned)
            {
                while (text.Contains(t))
                {
                    text = text.Replace(t, new string('*', t.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
