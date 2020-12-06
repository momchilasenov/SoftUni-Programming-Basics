using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string placeType = "";
            string location = "";
            double price = 0;

            if (budget <= 1000)
            {
                placeType = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                placeType = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.8;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.6;
                }
            }
            else if (budget > 3000)
            {
                placeType = "Hotel";
                price = budget * 0.9;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }
            }

            Console.WriteLine($"{location} - {placeType} - {price:f2}");
        }
    }
}
