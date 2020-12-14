using System;

namespace _05._PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());

            int hearthstone = 0;
            int fornite = 0;
            int overwatch = 0;
            int others = 0;
            double total = 0;

            for (int i = 1; i<=soldGames; i++)
            {
                string gameName = Console.ReadLine();

                if (gameName == "Hearthstone")
                {
                    hearthstone++;
                }
                else if (gameName == "Fornite")
                {
                    fornite++;
                }
                else if (gameName == "Overwatch")
                {
                    overwatch++;
                }
                else
                {
                    others++;
                }
                total = hearthstone + fornite + overwatch + others;

            }
            Console.WriteLine($"Hearthstone - {hearthstone*1.0/total*100:f2}%");
            Console.WriteLine($"Fornite - {fornite*1.0/total*100:f2}%");
            Console.WriteLine($"Overwatch - {overwatch*1.0/total*100:f2}%");
            Console.WriteLine($"Others - {others*1.0/total*100:f2}%");
        }
    }
}
