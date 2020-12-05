using System;

namespace _08._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string gasType = Console.ReadLine();
            string lowerGasType = gasType.ToLower();
            Console.WriteLine($"You have enough {lowerGasType}.");
            int litersInTank = int.Parse(Console.ReadLine());

            if (gasType != "Gasoline" && gasType != "Gas" && gasType != "Diesel")
            {
                Console.WriteLine("Invalid fuel!");
            }
            else if (litersInTank >= 25)

            {
                Console.WriteLine($"You have enough {lowerGasType}.");
            }
            else if (litersInTank < 25)
            {
                Console.WriteLine($"Fill your tank with {lowerGasType}!");
            }

        }
    }
}
