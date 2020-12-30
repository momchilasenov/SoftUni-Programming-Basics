using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input 
            int walkMinutes = int.Parse(Console.ReadLine());
            int numberOfWalks = int.Parse(Console.ReadLine());
            int caloriesGained = int.Parse(Console.ReadLine());

            int totalWalkTime = walkMinutes * numberOfWalks;
            int caloriesBurned = totalWalkTime * 5;

            double enoughCalories = caloriesGained * 0.5;

            if (caloriesBurned >= enoughCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }

        }
    }
}
