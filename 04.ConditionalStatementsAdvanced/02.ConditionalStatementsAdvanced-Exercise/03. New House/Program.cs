using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {

            Моето Решение
            string flower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;

            if (flower == "Roses")
            {
                price = 5;
                if (numberOfFlowers > 80)
                {
                    discount = 0.9;
                }
            }
            else if (flower == "Dahlias")
            {
                price = 3.80;
                if (numberOfFlowers > 90)
                {
                    discount = 0.85;
                }
            }
            else if (flower == "Tulips")
            {
                price = 2.80;
                if (numberOfFlowers > 80)
                {
                    discount = 0.85;
                }
            }
            else if (flower == "Narcissus")
            {
                price = 3;
                if (numberOfFlowers < 120)
                {
                    discount = 1.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                price = 2.50;
                if (numberOfFlowers < 80)
                {
                    discount = 1.20;
                }
            }

            if (discount == 0)
            {
                discount = 1;
            }

            double total = (price * numberOfFlowers) * discount;

            if (total <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flower} and {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
            }

        }
    }
}
