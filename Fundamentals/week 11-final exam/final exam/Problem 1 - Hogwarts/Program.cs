namespace Problem_1___Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var spell = Console.ReadLine();

            string? command;
            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                var cmd = command?
                    .Split()
                    .ToList();
                switch (cmd[0])
                {
                    case "Abjuration":
                        spell = spell.ToUpper();
                        Console.WriteLine(spell);
                        break;
                    case "Necromancy":
                        spell = spell.ToLower();
                        Console.WriteLine(spell);
                        break;
                    case "Illusion":
                        var index = int.Parse(cmd[1]);
                        var letter = char.Parse(cmd[2]);
                        if (index < 0 || index >= spell.Length)
                        {
                            Console.WriteLine($"The spell was too weak.");
                        }
                        else
                        {
                            var ch = spell.ToCharArray();
                            ch[index] = letter;
                            spell = new string(ch);
                            Console.WriteLine("Done!");
                        }
                        break;
                    case "Divination":
                        if (spell.Contains(cmd[1]))
                        {
                            spell = spell.Replace(cmd[1], cmd[2]);
                            Console.WriteLine(spell);
                        }
                        break;
                    case "Alteration":
                        if (spell.Contains(cmd[1]))
                        {
                            var substring = cmd[1];
                            index = spell.IndexOf(substring);
                            var length = substring.Length;
                            spell = spell.Remove(index, length);
                            Console.WriteLine(spell);
                        }
                        break;
                    default:
                        Console.WriteLine($"The spell did not work!");
                        break;
                }
            }

        }
    }
}
