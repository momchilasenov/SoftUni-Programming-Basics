using System;
using System.Numerics;

namespace _04._Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialDeposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double simpleRate = 0;
            double complexRate = 0;

            double simpleDeposit = initialDeposit;
            double complexDeposit = initialDeposit;
            string chosenInterest = "";

            for (int i = 1; i <= months; i++)
            {

                simpleRate = simpleDeposit + 0.03 * initialDeposit;
                complexRate = complexDeposit + 0.027 * complexDeposit;

                simpleDeposit = simpleRate;
                complexDeposit = complexRate;

            }
            
            if (simpleRate > complexRate)
            {
                chosenInterest = "simple";
            }
            else if (simpleRate < complexRate)
            {
                chosenInterest = "complex";
            }

            double difference = Math.Abs(simpleRate - complexRate);

            Console.WriteLine($"Simple interest rate: {simpleRate:f2} lv.");
            Console.WriteLine($"Complex interest rate: {complexRate:f2} lv.");
            Console.WriteLine($"Choose a {chosenInterest} interest rate. You will win {difference:f2} lv.");
        }
    }
}
