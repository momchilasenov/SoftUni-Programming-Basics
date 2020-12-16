using System;

namespace _04._Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double payment = 0;

            while (true)
            {
                string actor = Console.ReadLine();
                if (actor == "ACTION")
                {
                    Console.WriteLine($"We are left with {budget:f2} leva.");
                    break;
                }

                if (actor.Length <= 15)
                {
                    payment = double.Parse(Console.ReadLine());
                }
                else
                {
                    payment = budget * 0.2;
                }

                if (payment > budget)
                {
                    Console.WriteLine($"We need {Math.Abs(budget - payment):f2} leva for our actors.");
                    break;
                }
                budget -= payment;
            }

        }
    }
}
