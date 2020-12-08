using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForTrip = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int dayCounter = 0;
            int spendingCounter = 0;

            while (availableMoney < moneyForTrip)
            {
                dayCounter++;
                string saveOrSpend = Console.ReadLine();
                double inputMoney = double.Parse(Console.ReadLine());

                if (saveOrSpend == "spend")
                {
                    availableMoney -= inputMoney;
                    spendingCounter++;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                else if (saveOrSpend == "save")
                {
                    availableMoney += inputMoney;
                    spendingCounter = 0;
                }
                
                if (spendingCounter >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(dayCounter);
                    break;
                }

            }

            if (availableMoney >= moneyForTrip)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }

        }
    }
}
