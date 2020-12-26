using System;

namespace _04._Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentEggsInShop = int.Parse(Console.ReadLine()); 
            int soldEggs = 0;

            string command = Console.ReadLine(); //buy

            while (command != "Close")
            { 
                int buyOrSell = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {
                    currentEggsInShop -= buyOrSell; 
                    soldEggs += buyOrSell;
                }
                else if (command == "Fill")
                {
                    currentEggsInShop += buyOrSell;
                }

                if (currentEggsInShop < 0)
                {
                    Console.WriteLine("Not enough eggs in store!");
                    Console.WriteLine($"You can buy only {currentEggsInShop + buyOrSell}.");
                    break;
                }

                command = Console.ReadLine();

            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
        }
    }
}
