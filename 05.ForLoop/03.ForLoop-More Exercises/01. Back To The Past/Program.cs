using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int lastYearAlive = int.Parse(Console.ReadLine());

            int evenYearMoney = 0;
            int oddYearMoney = 0;
            int currentAge = 18;

            for (int year = 1800; year <= lastYearAlive; year++)
            {
               
                if (year % 2 == 0)
                {
                    evenYearMoney += 12000;
                }
                else
                {
                    oddYearMoney += 12000 + (50 * currentAge);
                }
                currentAge ++; 
            }

            double totalMoneyToLive = evenYearMoney + oddYearMoney;
            double diff = inheritedMoney - totalMoneyToLive;
            if (totalMoneyToLive <= inheritedMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diff:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(diff):f2} dollars to survive.");
            }

        }
    }
}
