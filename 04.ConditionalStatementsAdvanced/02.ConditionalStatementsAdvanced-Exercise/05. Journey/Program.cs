using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. въвеждаме бюджет и сезон
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double spending = 0;
            string typeOfStay = "";
            //2. изход - къде ще почива и колко ще похарчи
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spending = budget * 0.3;
                }
                else if (season == "winter")
                {
                    spending = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spending = budget * 0.4;    
                }
                else
                {
                    spending = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spending = budget * 0.9;
            }

            if (destination == "Europe")
            {
                typeOfStay = "Hotel";
            }
            else if (season == "summer")
            {
                typeOfStay = "Camp";
            }
            else if (season == "winter")
            {
                typeOfStay = "Hotel";
            }

            //5. принт
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfStay} - {spending:f2}");
        }
    }
}
