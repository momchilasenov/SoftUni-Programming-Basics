using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFoodInKg = int.Parse(Console.ReadLine());
            int dogFoodInGrams = dogFoodInKg * 1000;

            string command = Console.ReadLine();
            int totalFoodEaten = 0;

            while (command != "Adopted")
            {
                int foodEatenByDog = int.Parse(command);
                totalFoodEaten += foodEatenByDog;

                command = Console.ReadLine();
            }
            if (totalFoodEaten <= dogFoodInGrams)
            {
                int difference = dogFoodInGrams - totalFoodEaten;
                Console.WriteLine($"Food is enough! Leftovers: {difference} grams.");
            }
            else
            {
                int foodNeeded = totalFoodEaten - dogFoodInGrams;
                Console.WriteLine($"Food is not enough. You need {foodNeeded} grams more.");
            }

        }
    }
}
