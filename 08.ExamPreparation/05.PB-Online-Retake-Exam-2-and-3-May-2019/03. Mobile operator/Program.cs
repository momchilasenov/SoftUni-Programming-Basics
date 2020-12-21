using System;
using System.Diagnostics.Contracts;

namespace _03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractYears = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string mobileData = Console.ReadLine();
            int monthsTopay = int.Parse(Console.ReadLine());

            double price = 0;

            if (contractYears == "one")
            {
                if (typeOfContract == "Small")
                {
                    price = 9.98;
                }
                else if (typeOfContract == "Middle")
                {
                    price = 18.99;
                }
                else if (typeOfContract == "Large")
                {
                    price = 25.98;
                }
                else if (typeOfContract == "ExtraLarge")
                {
                    price = 35.99;
                }
            }
            else if (contractYears == "two")
            {
                if (typeOfContract == "Small")
                {
                    price = 8.58;
                }
                else if (typeOfContract == "Middle")
                {
                    price = 17.09;
                }
                else if (typeOfContract == "Large")
                {
                    price = 23.59;
                }
                else if (typeOfContract == "ExtraLarge")
                {
                    price = 31.79;
                }
            }

            if (mobileData == "yes")
            {
                if (price <= 10.00)
                {
                    price += 5.50;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }
            }

            if (contractYears == "two")
            {
                price -= price * 3.75 / 100;
            }

            double totalPrice = price * monthsTopay;

            Console.WriteLine($"{totalPrice:f2} lv.");

        }
    }
}
