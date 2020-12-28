using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientsInStore = int.Parse(Console.ReadLine());
            double totalMoneyMade = 0;

            for (int i = 1; i <= clientsInStore; i++)
            {
                string command = Console.ReadLine();
                int itemCounter = 0; 
                double clientTotal = 0; 

                while (command != "Finish")
                {
                    itemCounter++;
                    if (command == "basket")
                    {
                        clientTotal += 1.50;
                    }
                    else if (command == "wreath")
                    {
                        clientTotal += 3.80;
                    }
                    else if (command == "chocolate bunny")
                    {
                        clientTotal += 7;
                    }

                    command = Console.ReadLine();
                }
                if (itemCounter%2 == 0)
                {
                    clientTotal -= clientTotal * 0.2;
                }
                Console.WriteLine($"You purchased {itemCounter} items for {clientTotal:f2} leva.");
                totalMoneyMade += clientTotal;
            }
            Console.WriteLine($"Average bill per client is: {totalMoneyMade/clientsInStore:f2} leva.");


        }
    }
}
