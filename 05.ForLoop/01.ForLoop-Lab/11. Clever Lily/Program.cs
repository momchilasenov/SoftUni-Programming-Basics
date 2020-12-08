using System;
using System.IO;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLilly = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double money = 0;
            double moneyStolen = 0;
            double toys = 0;
            double totalMoneySaved = 0;


            for (int i = 1; i <= ageLilly; i++)
            {
                if (i % 2 == 0)
                {
                    money = money + 10;
                    totalMoneySaved += money; 
                    moneyStolen += 1; 
                }
                else
                {
                    toys++;
                }

            }

            double totalMoney = (totalMoneySaved - moneyStolen) + (toys * toysPrice);

            if (totalMoney >= washingMachine)
            {
                Console.WriteLine($"Yes! {totalMoney - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - totalMoney:f2}");
            }

        }
    }
}
