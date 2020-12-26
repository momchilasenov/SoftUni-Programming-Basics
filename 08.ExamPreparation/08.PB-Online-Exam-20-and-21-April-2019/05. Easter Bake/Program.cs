using System;

namespace _05._Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEasterBreads = int.Parse(Console.ReadLine());
            double totalSugar = 0;
            double totalFlour = 0;

            double maxSugar = 0;
            double maxFlour = 0;

            for (int i = 1; i <= numberOfEasterBreads; i++)
            {
                int sugarUsed = int.Parse(Console.ReadLine());
                int flourUsed = int.Parse(Console.ReadLine());

                if (maxSugar < sugarUsed)
                {
                    maxSugar = sugarUsed;
                }
                if (maxFlour < flourUsed)
                {
                    maxFlour = flourUsed;
                }

                totalSugar += sugarUsed;
                totalFlour += flourUsed;
            }
            double packetsOfSugar = Math.Ceiling (totalSugar / 950); 
            double packetOfFlour = Math.Ceiling (totalFlour / 750);

            Console.WriteLine($"Sugar: {packetsOfSugar}");
            Console.WriteLine($"Flour: {packetOfFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
