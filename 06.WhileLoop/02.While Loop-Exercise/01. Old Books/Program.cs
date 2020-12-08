using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {

            string favoriteBook = Console.ReadLine();

            string nextBookName = Console.ReadLine();
            int counter = 0;
            bool bookIsFound = false;

            while (nextBookName != "No More Books")
            {
                if (nextBookName == favoriteBook)
                {
                    bookIsFound = true;
                    break;
                }
                nextBookName = Console.ReadLine();
                counter++;
            }

            if (bookIsFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}

