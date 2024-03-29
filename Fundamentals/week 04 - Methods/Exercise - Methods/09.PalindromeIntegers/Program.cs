namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                bool isPalindrome = IsNumberPalindrome(input);
                Console.WriteLine(isPalindrome);
            }
        }

        private static bool IsNumberPalindrome(string input)
        {
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            string temp = new string(charArr);
            bool isEqual = input == temp;
            return isEqual;
        }
    }
}
