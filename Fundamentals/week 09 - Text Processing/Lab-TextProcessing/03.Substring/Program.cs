namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();
            
            while (true)
            {
                var index = input.IndexOf(key);
                if (index == -1)break;
                input = input.Remove(index, key.Length);
            }

            Console.WriteLine(input);

        }
    }
}
