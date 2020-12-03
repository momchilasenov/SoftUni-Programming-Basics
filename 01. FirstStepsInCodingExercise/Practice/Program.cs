using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double totalInterest = deposit * interest/100 ;
            double monthlyInterest = totalInterest / 12;
            double totalSum = deposit + period * monthlyInterest;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
