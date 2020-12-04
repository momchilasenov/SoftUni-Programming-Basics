using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerVegetables = double.Parse(Console.ReadLine());
            double pricePerFruit = double.Parse(Console.ReadLine());
            double vegetableKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());

            double totalVegetables = pricePerVegetables * vegetableKg;
            double totalFruit = pricePerFruit * fruitKg;
            double total = totalVegetables + totalFruit;
            Console.WriteLine($"{total/1.94:f2}");
        }
    }
}
