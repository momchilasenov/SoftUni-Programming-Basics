using System;

namespace _13._Ski_Trip_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Read Input
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string review = Console.ReadLine();

            double price = 0;
            double discount = 0;

            // 2. Calculate the total price
            switch (room)
            {
                case "room for one person":
                    price = 18;
                    break;
                case "apartment":
                    price = 25;
                    if (days < 10)
                    {
                        discount = 0.3;
                    }
                    else if (days>=10 && days <= 15)
                    {
                        discount = 0.35;
                    }
                    else if (days > 15)
                    {
                        discount = 0.5;
                    }
                    break;
                case "president apartment":
                    price = 35;
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
                    break;
            }
            // 3. Check the discount and add it to the total price     
            double totalPrice = price * (days - 1);
            totalPrice -= totalPrice * discount;
                  
            // 4. Check the feedback and add/subtract money
            if (review == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else
            {
                totalPrice -= totalPrice*0.1;
            }

            // 5. Output
            Console.WriteLine($"{totalPrice:f2}");
             
        }
    }
}
