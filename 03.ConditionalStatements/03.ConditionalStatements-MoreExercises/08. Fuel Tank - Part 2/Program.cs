using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;
            double gasPrice = 0.93;

            string gasType = Console.ReadLine();
            double litersBought = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double totalMoney = 0;

            if (gasType == "Gasoline")
            {
                if (clubCard == "Yes")
                {
                    gasolinePrice -= 0.18;
                }
                totalMoney = gasolinePrice * litersBought;
            }
            else if (gasType == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    dieselPrice -= 0.12;
                }
                totalMoney = dieselPrice * litersBought;
            }
            else if (gasType == "Gas")
            {
                if (clubCard == "Yes")
                {
                    gasPrice -= 0.08;
                }
                totalMoney = gasPrice * litersBought;
            }

            if (litersBought >= 20 && litersBought <= 25)
            {
                totalMoney -= totalMoney * 0.08;
            }
            else if (litersBought > 25)
            {
                totalMoney -= totalMoney * 0.1;
            }

            Console.WriteLine($"{totalMoney:f2} lv.");
        }
    }
}
