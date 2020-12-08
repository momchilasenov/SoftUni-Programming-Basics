using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace New_house_2
{
    class Program
    {
        static double rosesPrice = 5;
        static double dhaliasPrice = 3.80;
        static double tulipsPrice = 2.80;
        static double narcissusPrice = 3;
        static double gladiolusPrice = 2.50;
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (flowers == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    totalPrice -= numberOfFlowers * rosesPrice * 0.1; 
                }
                totalPrice += numberOfFlowers * rosesPrice; 
            }
            else if (flowers == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    totalPrice -= numberOfFlowers * dhaliasPrice * 0.15;
                }
                totalPrice += numberOfFlowers * dhaliasPrice;
            }
            else if (flowers == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    totalPrice -= numberOfFlowers * tulipsPrice * 0.15;
                }
                totalPrice += numberOfFlowers * tulipsPrice;
            }
            else if (flowers == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    totalPrice += numberOfFlowers * narcissusPrice * 0.15;
                }
                totalPrice += numberOfFlowers * narcissusPrice;
            }
            else
            {
                if (numberOfFlowers < 80)
                {
                    totalPrice += numberOfFlowers * gladiolusPrice * 0.2;
                }
                totalPrice += numberOfFlowers * gladiolusPrice;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }

        }
    }
}
