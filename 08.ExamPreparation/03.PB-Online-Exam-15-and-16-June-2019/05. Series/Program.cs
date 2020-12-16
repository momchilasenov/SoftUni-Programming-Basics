using System;

namespace _05._Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfSeries = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 1; i<=numberOfSeries; i++)
            {
                string seriesName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                if (seriesName == "Thrones")
                {
                    price -= price*0.5;
                }
                else if (seriesName == "Lucifer")
                {
                    price -= price * 0.4;
                }
                else if (seriesName == "Protector")
                {
                    price -= price * 0.3;
                }
                else if (seriesName == "TotalDrama")
                {
                    price -= price * 0.2;
                }
                else if (seriesName == "Area")
                {
                    price -= price * 0.1;
                }

                totalPrice += price;
                                
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {budget - totalPrice:f2} lv.");
            }
            else if (budget < totalPrice)
            {
                Console.WriteLine($"You need {totalPrice-budget:f2} lv. more to buy the series!");
            }
        }
    }
}
