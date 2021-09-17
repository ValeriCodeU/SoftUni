using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValidLength = ValidLength(password);
            bool isLettersAndDigits = LetterAndDigit(password);
            bool isTwoDigitsContain = TwoDigitsContain(password);

            if (isValidLength && isLettersAndDigits && isTwoDigitsContain)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool TwoDigitsContain(string password)
        {
            bool isTwoDigitsContain = password.Count(char.IsDigit) >= 2;

            if (!isTwoDigitsContain)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }

        static bool LetterAndDigit(string password)
        {
            bool isLettersAndDigits = password.All(char.IsLetterOrDigit);

            if (!isLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
            return true;
        }

        static bool ValidLength(string password)
        {
            bool isValidLength = password.Length >= 6 && password.Length <= 10;

            if (!isValidLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }
    }
}
