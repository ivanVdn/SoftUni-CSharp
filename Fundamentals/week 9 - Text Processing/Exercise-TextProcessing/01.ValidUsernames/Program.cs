namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine()?
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (var name in usernames.Where(name => IsValidUsername(name)))
            {
                Console.WriteLine(name);
            }
        }

        static bool IsValidUsername(string name)
        {
            return name.Length is >= 3 and <= 16 && name.All(c => char.IsDigit(c) || char.IsLetter(c) || c == '-' || c == '_');
        }
    }
}
