using System;
using System.Xml.Schema;

namespace _01._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            //static input 
            double pens = 5.80;
            double markers = 7.20;
            double liquid = 1.20;

            //Input
            int numberOfPens = int.Parse(Console.ReadLine());
            int numberOfMarkers = int.Parse(Console.ReadLine());
            double cleaningLiquid = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalPriceForOrder = numberOfMarkers * markers + numberOfPens * pens + cleaningLiquid * liquid;
            double discountSum = totalPriceForOrder * discount/100;
            double needMoney = totalPriceForOrder - discountSum;

            Console.WriteLine($"{needMoney:f3}");

        }
    }
}
