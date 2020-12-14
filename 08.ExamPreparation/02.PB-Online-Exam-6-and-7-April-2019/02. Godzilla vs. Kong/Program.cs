using System;

namespace _02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double priceForCLothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double totalClothes = actors * priceForCLothes;
            if (actors > 150)
            {
                totalClothes -= totalClothes * 0.10;
            }

            double total = decor + totalClothes;

            if (budget >= total)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-total:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {total-budget:f2} leva more.");
            }

        }
    }
}
