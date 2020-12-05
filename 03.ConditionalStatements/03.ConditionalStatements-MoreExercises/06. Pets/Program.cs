using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodGrams = double.Parse(Console.ReadLine());

            double dogTotal = dogFoodKg*days;
            double catTotal = catFoodKg * days;
            double turtleTotal = turtleFoodGrams / 1000 * days;

            double foodTotal = dogTotal + catTotal + turtleTotal;

            if (foodTotal <= foodLeft)
            {
                Console.WriteLine($"{Math.Floor(foodLeft-foodTotal)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodTotal-foodLeft)} more kilos of food are needed.");
            }

        }
    }
}
