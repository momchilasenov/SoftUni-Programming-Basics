using System;

namespace _03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());

            double price = 0;

            if (drink == "Espresso")
            {
                if (sugar == "Without")
                {
                    price = 0.90;
                }
                else if (sugar == "Normal")
                {
                    price = 1;
                }
                else if (sugar == "Extra")
                {
                    price = 1.20;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    price = 1;
                }
                else if (sugar == "Normal")
                {
                    price = 1.20;
                }
                else if (sugar == "Extra")
                {
                    price = 1.60;
                }
            }
            else if (drink == "Tea")
            {
                if (sugar == "Without")
                {
                    price = 0.5;
                }
                else if (sugar == "Normal")
                {
                    price = 0.6;
                }
                else if (sugar == "Extra")
                {
                    price = 0.7;
                }
            }

            double total = numberOfDrinks * price;

            if (sugar == "Without")
            {
                total -= total * 0.35; 
            }
            if (drink == "Espresso" && numberOfDrinks >= 5)
            {
                total -= total * 0.25;
            }
            if (total > 15)
            {
                total -= total * 0.2;
            }

            Console.WriteLine($"You bought {numberOfDrinks} cups of {drink} for {total:f2} lv.");
        }
    }
}
