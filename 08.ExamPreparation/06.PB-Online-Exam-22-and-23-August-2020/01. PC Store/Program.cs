using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double gpuPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int numberOfRams = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double cpuPriceInLeva = cpuPrice * 1.57;
            double gpuPriceInLeva = gpuPrice * 1.57;
            double ramPriceInLeva = ramPrice * 1.57;
            double totalForRam = ramPriceInLeva * numberOfRams;
            cpuPriceInLeva -= cpuPriceInLeva * discount;
            gpuPriceInLeva -= gpuPriceInLeva * discount;

            double total = cpuPriceInLeva + gpuPriceInLeva + totalForRam;

            Console.WriteLine($"Money needed - {total:f2} leva.");

            //switch (timeOfDay)
            //{
            //    case "day":
            //        switch (month)
            //        {
            //            case "march":
            //            case "april":
            //            case "may":
            //                price = 10.5;
            //                break;
            //            case "june":
            //            case "july":
            //            case "august":
            //                price = 12.60;
            //                break;
            //        }
            //        break;
            //    case "night":
            //        switch (month)
            //        {
            //            case "march":
            //            case "april":
            //            case "may":
            //                price = 8.4;
            //                break;
            //            case "june":
            //            case "july":
            //            case "august":
            //                price = 10.2;
            //                break;
            //        }
            //        break;
            //}

        }
    }
}
