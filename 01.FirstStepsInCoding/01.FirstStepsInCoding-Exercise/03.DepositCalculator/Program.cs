using System;
using System.Diagnostics.CodeAnalysis;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            //Calculations
            double totalInterest = deposit * interest / 100;
            double monthlyInterest = totalInterest / 12;
            double sum = deposit + period * monthlyInterest;
            //Output
            Console.WriteLine($"{sum:f2}");
        }
    }
}
