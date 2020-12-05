using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. input
            //2. Calculate total money needed
            // 3. See if Money > budget

            double movieBudget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double clothesForActors = double.Parse(Console.ReadLine());

            double decor = movieBudget * 0.1;
            double moneyForActors = actors * clothesForActors;
            

            if (actors > 150)
            {
                moneyForActors = moneyForActors * 0.9;
            }

            double totalMoneyNeeded = decor + moneyForActors;
            double result = Math.Abs(totalMoneyNeeded - movieBudget);

            if (totalMoneyNeeded > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {result:f2} leva more.");
            }

            else if (totalMoneyNeeded <= movieBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {result:f2} leva left.");
            }


        }
    }
}
