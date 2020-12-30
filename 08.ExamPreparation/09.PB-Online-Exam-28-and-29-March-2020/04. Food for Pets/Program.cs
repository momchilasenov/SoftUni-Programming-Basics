using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            int dayCounter = 0;
            int totalFoodEaten = 0;
            int totalDogFood = 0;
            int totalCatFood = 0;
            double biscuits = 0;
            double totalBiscuits = 0;

            for (int i = 1; i<=numberOfDays; i++) 
            {
                if (totalFoodEaten >= totalFood) 
                {
                    break;
                }
                dayCounter++;
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                totalFoodEaten += dogFood + catFood;
                totalDogFood += dogFood;
                totalCatFood += catFood;
                
                if (dayCounter %3 == 0)
                {
                    biscuits = (dogFood + catFood) * 0.1;
                    totalBiscuits += biscuits;
                    
                }


            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round (totalBiscuits)}gr.");
            Console.WriteLine($"{totalFoodEaten * 1.0 / totalFood*100:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalDogFood * 1.0 / totalFoodEaten*100:f2}% eaten from the dog.");
            Console.WriteLine($"{totalCatFood * 1.0/totalFoodEaten*100:f2}% eaten from the cat.");

        }
    }
}
