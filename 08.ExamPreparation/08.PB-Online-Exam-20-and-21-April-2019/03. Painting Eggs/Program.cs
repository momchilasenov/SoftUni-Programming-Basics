using System;

namespace _03._Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggSize = Console.ReadLine();
            string colourEggs = Console.ReadLine();
            int numberOfPacks = int.Parse(Console.ReadLine());
            int price = 0;

            if (eggSize == "Large")
            {
                if (colourEggs == "Red")
                {
                    price = 16;
                }
                else if (colourEggs == "Green")
                {
                    price = 12;
                }
                else if (colourEggs == "Yellow")
                {
                    price = 9;
                }
            }
            else if (eggSize == "Medium")
            {
                if (colourEggs == "Red")
                {
                    price = 13;
                }
                else if (colourEggs == "Green")
                {
                    price = 9;
                }
                else if (colourEggs == "Yellow")
                {
                    price = 7;
                }
            }
            if (eggSize == "Small")
            {
                if (colourEggs == "Red")
                {
                    price = 9;
                }
                else if (colourEggs == "Green")
                {
                    price = 8;
                }
                else if (colourEggs == "Yellow")
                {
                    price = 5;
                }
            }

            double total = numberOfPacks * price;

            total -= total * 0.35;

            Console.WriteLine($"{total:f2} leva.");
        }
    }
}
