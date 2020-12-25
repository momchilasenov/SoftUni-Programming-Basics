using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int winnerOne = 0;
            int winnerTwo = 0;

            while (command != "End of battle")
            {
                if (command == "one")
                {
                    winnerOne++;
                    secondPlayerEggs--;
                }
                else if (command == "two")
                {
                    winnerTwo++;
                    firstPlayerEggs--;
                }

                if (firstPlayerEggs <= 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                    break;
                }
                else if (secondPlayerEggs <= 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                    break;
                }
                
                command = Console.ReadLine();

            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
            }

        }
    }
}
