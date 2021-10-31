using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
           
            int counter = 0;

            for (int i = 0; i < usernames.Length; i++)
            {
                counter = 0;
                string username = usernames[i];
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                for (int j = 0; j < username.Length; j++)
                {
                    
                    if (char.IsLetterOrDigit(username[j]) || username[j] == 95 || username[j] == 45)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }                    
                }

                if (usernames[i].Length == counter)
                {
                    Console.WriteLine(usernames[i]);
                }
            }           
        }
    }
}
