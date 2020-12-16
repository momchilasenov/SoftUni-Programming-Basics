using System;
using System.Globalization;

namespace _03._Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string menu = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());

            double price = 0;

            if (menu == "Drink")
            {
                if (movie == "John Wick")
                {
                    price = 12;
                }
                else if (movie == "Star Wars")
                {
                    price = 18;
                }
                else if (movie == "Jumanji")
                {
                    price = 9;
                }
            }
            else if (menu == "Popcorn")
            {
                if (movie == "John Wick")
                {
                    price = 15;
                }
                else if (movie == "Star Wars")
                {
                    price = 25;
                }
                else if (movie == "Jumanji")
                {
                    price = 11;
                }
            }
            else if (menu == "Menu")
            {
                if (movie == "John Wick")
                {
                    price = 19;
                }
                else if (movie == "Star Wars")
                {
                    price = 30;
                }
                else if (movie == "Jumanji")
                {
                    price = 14;
                }
            }

            double totalPrice = price * numberOfTickets;

            if (movie == "Star Wars" && numberOfTickets >= 4)
            {
                totalPrice -= totalPrice * 0.3;
            }
            else if (movie == "Jumanji" && numberOfTickets == 2)
            {
                totalPrice -= totalPrice * 0.15;
            }

            Console.WriteLine($"Your bill is {totalPrice:f2} leva.");

        }
    }
}
