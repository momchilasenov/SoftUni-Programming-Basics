using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double chairPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalEntrance = numberOfPeople * entranceFee;
            double chairsNeeded = Math.Ceiling(numberOfPeople * 0.75);
            double umbrellasNeeded = Math.Ceiling(numberOfPeople * 0.5);

            double priceOfChairs = chairsNeeded * chairPrice;
            double priceOfUmbrellas = umbrellasNeeded * umbrellaPrice;

            double total = priceOfChairs + priceOfUmbrellas + totalEntrance;

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
