using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double payPerKm = 0;

            if (kmPerMonth <= 5000)
            {
                if (season == "Autumn" || season == "Spring")
                {
                    payPerKm = 0.75;
                }
                else if (season == "Summer")
                {
                    payPerKm = 0.90;
                }
                else
                {
                    payPerKm = 1.05;
                }
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == "Autumn" || season == "Spring")
                {
                    payPerKm = 0.95;
                }
                else if (season == "Summer")
                {
                    payPerKm = 1.10;
                }
                else
                {
                    payPerKm = 1.25;
                }
            }
            else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                payPerKm = 1.45;
            }

            double totalKm = kmPerMonth * 4 * payPerKm;

            totalKm -= totalKm * 0.1; 

            Console.WriteLine($"{totalKm:f2}");
        }
    }
}
