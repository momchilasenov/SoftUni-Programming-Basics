using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string datesOfStay = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            int price = 0;

            if (destination == "France")
            {
                if (datesOfStay == "21-23")
                {
                    price = 30;
                }
                else if (datesOfStay == "24-27")
                {
                    price = 35;
                }
                else if (datesOfStay == "28-31")
                {
                    price = 40;
                }
            }
            else if (destination == "Italy")
            {
                if (datesOfStay == "21-23")
                {
                    price = 28;
                }
                else if (datesOfStay == "24-27")
                {
                    price = 32;
                }
                else if (datesOfStay == "28-31")
                {
                    price = 39;
                }
            }
            if (destination == "Germany")
            {
                if (datesOfStay == "21-23")
                {
                    price = 32;
                }
                else if (datesOfStay == "24-27")
                {
                    price = 37;
                }
                else if (datesOfStay == "28-31")
                {
                    price = 43;
                }
            }

            int total = numberOfNights * price;

            Console.WriteLine($"Easter trip to {destination} : {total:f2} leva.");
        }
    }
}
