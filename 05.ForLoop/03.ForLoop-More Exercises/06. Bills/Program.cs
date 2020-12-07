using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            const int waterPrice = 20;
            const int internetPrice = 15;
            int months = int.Parse(Console.ReadLine());
            double totalElectricity = 0;
            double totalWater = 0;
            double totalInternet = 0;
            double others = 0;

            for (int i = 1; i<=months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());

                totalElectricity += electricity;
                totalWater += waterPrice;
                totalInternet += internetPrice;
                others += (electricity + waterPrice + internetPrice) * 1.2;
            }
            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            double average = (totalInternet + totalElectricity + totalWater + others) / months;
            Console.WriteLine($"Average: {average:f2} lv");

        }
    }
}
