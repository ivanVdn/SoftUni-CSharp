using System.Collections.Generic;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = PasswordChec(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool PasswordChec(string password)
        {
            int count = 0;
            if (PasswordLength(password))
            {
                count++;
            }

            if (IsAlphanumeric(password))
            {
                count++;
            }

            if (TwoDigitInTheEnd(password))
            {
                count++;
            }

            if (count >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static bool TwoDigitInTheEnd(string password)
        {
            int counter = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    counter++;
                }
            }

            if (counter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }

            return true;

        }

        static bool IsAlphanumeric(string password)
        {
            int count = 0;
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }

            return true;
        }

        static bool PasswordLength(string password)
        {
            bool isInRage = password.Length < 6 || password.Length > 10;
            if (isInRage)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }
    }
}
