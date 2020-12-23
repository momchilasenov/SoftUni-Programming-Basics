using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double beachTowel = double.Parse(Console.ReadLine());
            int discountInPercentage = int.Parse(Console.ReadLine());

            double umbrellaPrice = beachTowel * 2.0 / 3; 
            double flipFlops = umbrellaPrice * 0.75;
            double beachBag = ((beachTowel + flipFlops)/ 3);

            double total = umbrellaPrice + flipFlops + beachTowel + beachBag;

            total -= total * discountInPercentage/100;

            if (total <= budget)
            {
                Console.WriteLine($"Annie's sum is {total:f2} lv. She has {budget-total:f2} lv. left.");
            }
            else if (total> budget)
            {
                Console.WriteLine($"Annie's sum is {total:f2} lv. She needs {total-budget:f2} lv. more.");
            }
        }
    }
}
