using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCargos = int.Parse(Console.ReadLine());
            double totalTonnage = 0;
            double averagePricePerTon = 0;
            double withBus = 0;
            double withTruck = 0;
            double withTrain = 0;

            for (int i = 1; i<=numberOfCargos; i++)
            {
                int tonnage = int.Parse(Console.ReadLine());
                totalTonnage += tonnage;

                if (tonnage <= 3)
                {
                    withBus += tonnage;
                }
                else if (tonnage >= 3 && tonnage <= 11)
                {
                    withTruck += tonnage;
                }
                else if ( tonnage >= 12)
                {
                    withTrain += tonnage;
                }

            }
            averagePricePerTon = (withBus*200 + 175*withTruck + 120*withTrain)*1.0 / totalTonnage;
            Console.WriteLine($"{averagePricePerTon:f2}");
            Console.WriteLine($"{(withBus / totalTonnage) * 100:f2}%");
            Console.WriteLine($"{(withTruck / totalTonnage) * 100:f2}%");
            Console.WriteLine($"{(withTrain / totalTonnage) * 100:f2}%");
        }
    }
}
