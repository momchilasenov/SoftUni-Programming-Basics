using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int extraCosts = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                pricePerNight -= pricePerNight * 0.05;
            }

            double totalForStay = nights * pricePerNight;
            totalForStay += budget * (extraCosts * 1.0 / 100);

            if (budget >= totalForStay)
            {
                Console.WriteLine($"Ivanovi will be left with {budget-totalForStay:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalForStay-budget:f2} leva needed.");
            }


        }
    }
}
