using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. входни данни
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0;

            if (projection == "Premiere")
            {
                price = 12;
            }
            else if (projection == "Normal")
            {
                price = 7.5;
            }
            else if (projection == "Discount")
            {
                price = 5.0;
            }
            // 2. изчисляваме приходите - цена за типа прожекция по брой места (r * c)
            double totalPrice = (columns * rows) * price;

            // 3. print 
            Console.WriteLine($"{totalPrice:f2} leva");
        }
    }
}
