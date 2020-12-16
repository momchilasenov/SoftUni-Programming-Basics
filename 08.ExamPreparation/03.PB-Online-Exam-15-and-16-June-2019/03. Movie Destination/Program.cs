using System;

namespace _03._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int numberOfDays = int.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Winter")
            {
                if (destination == "Dubai")
                {
                    price = 45000;
                }
                else if (destination == "Sofia")
                {
                    price = 17000;
                }
                else if (destination == "London")
                {
                    price = 24000;
                }
            }
            else if (season == "Summer")
            {
                if (destination == "Dubai")
                {
                    price = 40000;
                }
                else if (destination == "Sofia")
                {
                    price = 12500;
                }
                else if (destination == "London")
                {
                    price = 20250;
                }
            }

            double totalPrice = price * numberOfDays;

            if (destination == "Dubai")
            {
                totalPrice -= totalPrice * 0.3;
            }
            else if (destination == "Sofia")
            {
                totalPrice += totalPrice * 0.25;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrice - budget:f2} leva more!");
            }
        }
    }
}
