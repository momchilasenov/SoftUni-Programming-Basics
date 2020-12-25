using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double pricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guests >= 10 && guests <= 15)
            {
                pricePerPerson -= pricePerPerson * 0.15;
            }
            else if (guests > 15 && guests <= 20)
            {
                pricePerPerson -= pricePerPerson * 0.2;
            }
            else if (guests > 20)
            {
                pricePerPerson -= pricePerPerson * 0.25; 
            }

            double cakePrice = budget * 0.1;
            double totalForFood = guests * pricePerPerson;
            double total = totalForFood + cakePrice;

            if (total <= budget)
            {
                Console.WriteLine($"It is party time! {budget-total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {total-budget:f2} leva needed.");
            }

        }
    }
}
