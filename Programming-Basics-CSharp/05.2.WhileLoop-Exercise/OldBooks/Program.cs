using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем търсена книга
            string input = Console.ReadLine();

            int numOfBooks = 0;

            // Въвеждаме книга за търсене или команда текст: "No More Books"
            string book = Console.ReadLine();

            while (book != "No More Books")
            {              
                if (input == book)
                {
                    Console.WriteLine($"You checked {numOfBooks} books and found it.");
                    break;
                }

                book = Console.ReadLine();
                numOfBooks++;
            }

            if (book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numOfBooks} books.");
            }
        }
    }
}
