using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            
            string set = Console.ReadLine();
            
            int numberOfSets = int.Parse(Console.ReadLine());

            double smallSetWatermelon = 2 * 56;
            double largeSetWatermelon = 5 * 28.7;
            double smallSetMango = 2 * 36.66;
            double largeSetMango = 5 * 19.60;
            double smallSetPineapple = 2 * 42.10;
            double largeSetPineapple = 5 * 24.80;
            double smallSetRaspberry = 2 * 20;
            double largeSetRaspberry = 5 * 15.20;

            double totalMoney = 0;

            if (fruit == "Watermelon")
            {
                if (set == "small")
                {
                    totalMoney = smallSetWatermelon * numberOfSets;
                }
                else
                {
                    totalMoney = largeSetWatermelon * numberOfSets;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (set == "small")
                {
                    totalMoney = smallSetPineapple * numberOfSets;
                }
                else
                {
                    totalMoney = largeSetPineapple * numberOfSets;
                }
            }
            else if (fruit == "Mango")
            {
                if (set == "small")
                {
                    totalMoney = smallSetMango * numberOfSets;
                }
                else
                {
                    totalMoney = largeSetMango * numberOfSets;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (set == "small")
                {
                    totalMoney = smallSetRaspberry * numberOfSets;
                }
                else
                {
                    totalMoney = largeSetRaspberry * numberOfSets;
                }
            }

            if (totalMoney >= 400 && totalMoney <= 1000)
            {
                totalMoney *= 0.85;
            }
            else if (totalMoney > 1000)
            {
                totalMoney *= 0.5;
            }
            Console.WriteLine($"{totalMoney:f2} lv.");
               
        }
    }
}
