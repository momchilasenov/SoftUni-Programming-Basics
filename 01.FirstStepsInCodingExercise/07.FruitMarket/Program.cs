using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesInBgn = double.Parse(Console.ReadLine());
            double bananasInKg = double.Parse(Console.ReadLine());
            double orangesInKg = double.Parse(Console.ReadLine());
            double raspberriesInKg = double.Parse(Console.ReadLine());
            double strawberriesInKg = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesInBgn / 2;
            double orangesPrice = raspberriesPrice - (raspberriesPrice * 0.4);
            double bananasPrice = raspberriesPrice - (raspberriesPrice * 0.8);

            double strawberriesSum = strawberriesInBgn * strawberriesInKg;
            double raspberriesSum = raspberriesPrice * raspberriesInKg;
            double orangesSum = orangesPrice * orangesInKg;
            double bananasSum = bananasPrice * bananasInKg;

            double totalSum = strawberriesSum + raspberriesSum + orangesSum + bananasSum;

            Console.WriteLine($"{totalSum:f2}");


        }
    }
}
