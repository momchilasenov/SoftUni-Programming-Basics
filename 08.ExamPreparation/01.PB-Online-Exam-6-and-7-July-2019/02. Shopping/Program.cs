using System;

namespace _02._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int cpus = int.Parse(Console.ReadLine());
            int rams = int.Parse(Console.ReadLine());

            double videocardPrice = 250;
            double cpuPrice = (videocards * videocardPrice) * 0.35;
            double ramPrice = (videocards * videocardPrice) * 0.10;

            double totalPrice = videocardPrice * videocards + cpus * cpuPrice + rams * ramPrice;

            if (videocards > cpus)
            {
                totalPrice -= totalPrice * 0.15;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget-totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice-budget:f2} leva more!");
            }
        }
    }
}
