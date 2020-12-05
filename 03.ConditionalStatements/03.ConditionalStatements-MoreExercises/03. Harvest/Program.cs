using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyardArea = int.Parse(Console.ReadLine());
            double grapesPerMeter = double.Parse(Console.ReadLine());
            int letersNeeded = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double wineProductionLand = vineyardArea * 0.4; // в квадратни метри
            double grapesKg = grapesPerMeter * wineProductionLand;
            double wineLiters = grapesKg / 2.5; 

            if (wineLiters >= letersNeeded)
            {
                double diff = wineLiters - letersNeeded;
                double winePerPerson = diff / numberOfWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLiters)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(winePerPerson)} liters per person.");
            }
            else
            {
                double diff = letersNeeded - wineLiters;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }

        }
    }
}
