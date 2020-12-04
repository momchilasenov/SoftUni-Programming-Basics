using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine()); //скумрия
            double spratPrice = double.Parse(Console.ReadLine()); // цаца
            double bonitoKg = double.Parse(Console.ReadLine()); //паламуд
            double scadKg = double.Parse(Console.ReadLine()); //сафрид
            int clamsKg = int.Parse(Console.ReadLine()); //миди

            double bonitoPrice = mackerelPrice * 1.6;
            double scadPrice = spratPrice * 1.8;
            const double clamsPrice = 7.50;

            double totalMoneyNeeded = bonitoKg * bonitoPrice + scadKg * scadPrice + clamsKg * clamsPrice;

            Console.WriteLine($"{totalMoneyNeeded:f2}");

            
        }
    }
}
