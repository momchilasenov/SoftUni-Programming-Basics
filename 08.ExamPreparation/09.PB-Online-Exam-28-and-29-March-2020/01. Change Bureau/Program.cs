using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBitcoins = int.Parse(Console.ReadLine());
            double numberOfYuans = double.Parse(Console.ReadLine());
            double commissionPercentage = double.Parse(Console.ReadLine());

            double dollar = 1.76;
            double bitcoin = 1168;
            double yuan = 0.15;
            double euro = 1.95;

            double bitcoinValue = numberOfBitcoins * bitcoin;
            double yuanValue = numberOfYuans * yuan*dollar;
            double totalValue = bitcoinValue + yuanValue;
            double inEuro = totalValue / euro;
            double commission = (commissionPercentage / 100) * inEuro;
            double result = inEuro - commission;

            Console.WriteLine($"{result:f2}");

        }
    }
}
