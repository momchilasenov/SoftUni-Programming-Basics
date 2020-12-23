using System;

namespace _01._Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeDesi = double.Parse(Console.ReadLine());
            int monthsToSave = int.Parse(Console.ReadLine());
            double personalExpenses = double.Parse(Console.ReadLine());

            double unpredictedExpenses = incomeDesi * 0.3;

            double moneySaved = incomeDesi - unpredictedExpenses - personalExpenses;
            double totalMoneySaved = monthsToSave * moneySaved;

            Console.WriteLine($"She can save {moneySaved/incomeDesi * 100:f2}%");
            Console.WriteLine($"{totalMoneySaved:f2}");
        }
    }
}
