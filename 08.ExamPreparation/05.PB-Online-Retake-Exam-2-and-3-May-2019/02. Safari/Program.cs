using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double letersNeeded = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double gasPrice = letersNeeded * 2.10;
            double totalCost = gasPrice + 100;

            double discount = 0;

            if (dayOfWeek == "Saturday")
            {
                discount = 0.1;
            }
            else if (dayOfWeek == "Sunday")
            {
                discount = 0.2;
            }

            totalCost -= totalCost * discount;

            if (budget >= totalCost)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalCost:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalCost-budget:f2} lv.");
            }
        }
    }
}
