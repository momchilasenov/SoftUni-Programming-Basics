using System;

namespace _01._Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double sugarPricePerKilo = 0;
            double eggCratePrice = 0;
            double yeastPrice = 0;

            double flourPricePerKilo = double.Parse(Console.ReadLine());
            double flourKilos = double.Parse(Console.ReadLine());
            double sugarKilos = double.Parse(Console.ReadLine());
            int eggCrates = int.Parse(Console.ReadLine());
            int yeastPackets = int.Parse(Console.ReadLine());

            sugarPricePerKilo = flourPricePerKilo * 0.75;
            eggCratePrice = flourPricePerKilo * 1.1;
            yeastPrice = sugarPricePerKilo * 0.2;

            double flourSum = flourPricePerKilo * flourKilos;
            double sugarSum = sugarKilos * sugarPricePerKilo;
            double eggSum = eggCratePrice * eggCrates;
            double yeastSum = yeastPrice * yeastPackets;

            double total = flourSum + sugarSum + eggSum + yeastSum;

            Console.WriteLine($"{total:f2}");

        }
    }
}
