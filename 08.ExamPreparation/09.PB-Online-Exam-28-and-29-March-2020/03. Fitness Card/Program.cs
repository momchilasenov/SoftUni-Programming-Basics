using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;
            double result = 0;

            if (sport == "Gym")
            {
                if (gender == 'm')
                {
                    price = 42;
                }
                else
                {
                    price = 35;
                }
            }
            else if (sport == "Boxing")
            {
                if (gender == 'm')
                {
                    price = 41;
                }
                else
                {
                    price = 37;
                }
            }
            else if (sport == "Yoga")
            {
                if (gender == 'm')
                {
                    price = 45;
                }
                else
                {
                    price = 42;
                }
            }
            else if (sport == "Zumba")
            {
                if (gender == 'm')
                {
                    price = 34;
                }
                else
                {
                    price = 31;
                }
            }
            else if (sport == "Dances")
            {
                if (gender == 'm')
                {
                    price = 51;
                }
                else
                {
                    price = 53;
                }
            }
            else if (sport == "Pilates")
            {
                if (gender == 'm')
                {
                    price = 39;
                }
                else
                {
                    price = 37;
                }
            }
            
            if (age <= 19)
            {
                price *= 0.8;
            }

            if (moneyAvailable >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                result = price - moneyAvailable;
                Console.WriteLine($"You don't have enough money! You need ${result:f2} more."
);
            }

        }
    }
}
