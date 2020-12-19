using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfClients = int.Parse(Console.ReadLine());
            int backCount = 0;
            int chestCount = 0;
            int legsCount = 0;
            int absCount = 0;
            int shakeCount = 0;
            int barCount = 0;

            double totalWorkingOut = 0;
            double totalBuyingStuff = 0;

            for (int i=1; i<= numberOfClients; i++)
            {
                string input = Console.ReadLine();

                if (input == "Back")
                {
                    backCount++;
                    totalWorkingOut++;
                }
                else if (input == "Legs")
                {
                    legsCount++;
                    totalWorkingOut++;
                }
                else if (input == "Chest")
                {
                    chestCount++;
                    totalWorkingOut++;
                }
                else if (input == "Abs")
                {
                    absCount++;
                    totalWorkingOut++;
                }
                else if (input == "Protein shake")
                {
                    shakeCount++;
                    totalBuyingStuff++;
                }
                else if (input == "Protein bar")
                {
                    barCount++;
                    totalBuyingStuff++;
                }
            }
            Console.WriteLine($"{backCount} - back");
            Console.WriteLine($"{chestCount} - chest");
            Console.WriteLine($"{legsCount} - legs");
            Console.WriteLine($"{absCount} - abs");
            Console.WriteLine($"{shakeCount} - protein shake");
            Console.WriteLine($"{barCount} - protein bar");
            Console.WriteLine($"{(totalWorkingOut/numberOfClients)*100:f2}% - work out");
            Console.WriteLine($"{(totalBuyingStuff/numberOfClients)*100:f2}% - protein");

        }
    }
}
