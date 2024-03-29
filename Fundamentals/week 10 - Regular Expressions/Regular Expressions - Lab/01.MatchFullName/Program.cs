using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<name>(\b[A-Z][a-z]{1,})[\ ]([A-Z][a-z]{1,}))";
            var input = Console.ReadLine();
            

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write("{0} ", m.Value, m.Index);
            }
        }
    }
}