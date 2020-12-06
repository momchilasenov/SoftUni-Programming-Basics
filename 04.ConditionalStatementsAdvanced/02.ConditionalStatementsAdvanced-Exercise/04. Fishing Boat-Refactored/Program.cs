using System;
using System.Text.RegularExpressions;

namespace _04._Fishing_Boat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int springRent = 3000;
            const int summerAndAutumnRent = 4200;
            const int winterRent = 2600;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double totalMoney = 0; // 

            switch (season)
            {
                case "Spring":
                    totalMoney = springRent;
                    break;
                case "Summer":
                case "Autumn":
                    totalMoney = summerAndAutumnRent;
                    break;
                case "Winter":
                    totalMoney = winterRent;
                    break;
            }

            if (fishermen <= 6)
            {
                totalMoney -= totalMoney * 0.1; // totalMoney = totalMoney - (totalMoney*0.1);
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                totalMoney -= totalMoney * 0.15; 
            }
            else if (fishermen > 12)
            {
                totalMoney -= totalMoney * 0.25;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                totalMoney -= totalMoney * 0.05;
            }

            double result = Math.Abs(budget - totalMoney);
            if (budget >= totalMoney)
            {
                Console.WriteLine($"Yes! You have {result:f2} leva left.");

            }
            else
            {
                Console.WriteLine($"Not enough money! You need {result:f2} leva.");
            }
        }
    }
}
