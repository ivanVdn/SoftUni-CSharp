using System.Text.RegularExpressions;

namespace _04.StarEnigma
{

    internal class Program
    {
        internal static void Main()
        {
            var pattern = @"@(?<planet>[a-zA-Z]+).*:(?<population>\d+).*!(?<type>[AD]).*->(?<soldiers>\d+)";

            var encryptedMessage = Console.ReadLine();
            var decryptedMessage = DecryptMessage(encryptedMessage);

            var matches = Regex.Match(decryptedMessage, pattern);
        }

        private static string DecryptMessage(string? encryptedMessage)
        {
            var decryptedMessage = "";
            var key = "STARstar";
            foreach (var c in encryptedMessage)
            {
                if ("starSTAR".Contains(c))
                {
                    decryptedMessage += (char)(c - encryptedMessage.Count(x => key.Contains(x)));
                }
                else
                {
                    decryptedMessage += c;
                }
            }

            return decryptedMessage;
        }

    }
}
