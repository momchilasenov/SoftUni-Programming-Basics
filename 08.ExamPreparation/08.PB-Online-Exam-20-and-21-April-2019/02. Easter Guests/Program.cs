using System;

namespace _02._Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double numberOfEasterBreads = Math.Ceiling(guests *1.0 / 3);
            double numberOfEggs = guests * 2;

            double priceOfEasterBreads = numberOfEasterBreads * 4;
            double priceOfEggs = numberOfEggs * 0.45;

            double totalPrice = priceOfEasterBreads + priceOfEggs;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Lyubo bought {numberOfEasterBreads} Easter bread and {numberOfEggs} eggs.");
                Console.WriteLine($"He has {budget-totalPrice:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalPrice-budget:f2} lv. more.");
            }

        }
    }
}
