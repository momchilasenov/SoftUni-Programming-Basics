using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBottles = int.Parse(Console.ReadLine());

            int availableDetergent = numberOfBottles * 750;

            string input = Console.ReadLine();
            int numberOfWashes = 0;
            int detergentUsed = 0;
            int dishesOrPots = 0;
            int totalDetergentUsed = 0;
            int numberOfPots = 0;
            int numberOfDishes = 0;


            
                        
            while (input != "End") 
            {
                numberOfWashes++; 
                dishesOrPots = int.Parse(input); 

                if (numberOfWashes % 3 == 0) 
                {
                    detergentUsed = 15; 
                    availableDetergent -= dishesOrPots * detergentUsed; 

                }
                else 
                {
                    detergentUsed = 5;
                    availableDetergent -= dishesOrPots * detergentUsed;

                }

                totalDetergentUsed += dishesOrPots * detergentUsed;

                if (availableDetergent<0) 
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(availableDetergent)} ml. more necessary!");
                    break;
                }

                
                if (numberOfWashes % 3 == 0)
                {
                    numberOfPots += dishesOrPots;
                }
                else
                {
                    numberOfDishes += dishesOrPots;
                }

                input = Console.ReadLine();

            }

            if (input == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{numberOfDishes} dishes and {numberOfPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {availableDetergent} ml.");
            }
        }
    }
}
