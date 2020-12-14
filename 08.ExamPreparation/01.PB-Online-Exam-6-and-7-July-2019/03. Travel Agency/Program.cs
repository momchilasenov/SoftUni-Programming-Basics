using System;

namespace _03._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string packetType = Console.ReadLine();
            string VIP = Console.ReadLine();
            int daysOfStay = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;

            if (daysOfStay <= 0)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }

            if (city == "Bansko" || city == "Borovets")
            {
                if (packetType == "withEquipment")
                {
                    price = 100;
                    discount = 0.1;
                }
                else if (packetType == "noEquipment")
                {
                    price = 80;
                    discount = 0.05;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (packetType == "withBreakfast")
                {
                    price = 130;
                    discount = 0.12;
                }
                else if (packetType == "noBreakfast")
                {
                    price = 100;
                    discount = 0.07;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            double pricePerDay = price;

            if (VIP == "yes")
            {
                pricePerDay -= price * discount;
            }

            double totalPrice = pricePerDay * daysOfStay;

            if (daysOfStay > 7)
            {
                totalPrice -= pricePerDay;
            }

            Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
        }
    }
}
