using System;

namespace _01._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veggieMenus = int.Parse(Console.ReadLine());

            double chickenPrice = 10.35;
            double fishPrice = 12.40;
            double veggiePrice = 8.15;

            double total = chickenMenus * chickenPrice + fishMenus * fishPrice + veggieMenus * veggiePrice;

            double desert = total * 0.2;

            double totalPrice = total + desert + 2.50;
            Console.WriteLine($"Total: {totalPrice:f2}");


        }
    }
}
