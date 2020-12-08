using System;
using System.Xml.Schema;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string review = Console.ReadLine();
            
            double price = 0;
            double discount = 0;
              
            if (room == "room for one person")
            {
                price = 18.00;
            }
            else if (room == "apartment")
            {
                price = 25.00;

                if (days < 10)
                {
                    discount = 0.3;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.35;
                }
                else if (days > 15)
                {
                    discount = 0.5;
                }
            }
            else if (room == "president apartment")
            {
                price = 35.00;
                
                if (days < 10)
                {
                    discount = 0.1;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.15;
                }
                else if (days > 15)
                {
                    discount = 0.2;
                }
            }

            double total = price * (days - 1);
            // 4. приспадане на намаление от цената
            total -= total * discount;

            if (review == "positive")
            {
                total += total * 0.25;
            }
            else if (review == "negative")
            {
                total -= total * 0.1;
            }

            Console.WriteLine($"{total:f2}");


        }
    }
}
