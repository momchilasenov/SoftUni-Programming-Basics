using System;

namespace _03._Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string cabinType = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double price = 0;

            if (cabinType == "standard cabin")
            {
                if (cruiseType == "Mediterranean")
                {
                    price = 27.50;
                }
                else if (cruiseType == "Adriatic")
                {
                    price = 22.99;
                }
                else if (cruiseType == "Aegean")
                {
                    price = 23;
                }
            }
            else if (cabinType == "cabin with balcony")
            {
                if (cruiseType == "Mediterranean")
                {
                    price = 30.2;
                }
                else if (cruiseType == "Adriatic")
                {
                    price = 25;
                }
                else if (cruiseType == "Aegean")
                {
                    price = 26.60;
                }
            }
            else if (cabinType == "apartment")
            {
                if (cruiseType == "Mediterranean")
                {
                    price = 40.5;
                }
                else if (cruiseType == "Adriatic")
                {
                    price = 34.99;
                }
                else if (cruiseType == "Aegean")
                {
                    price = 39.8;
                }
            }

            double totalCost = nights * price * 4;

            if (nights > 7)
            {
                totalCost -= totalCost * 0.25;
            }

            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {totalCost:f2} lv.");
        }
    }
}
