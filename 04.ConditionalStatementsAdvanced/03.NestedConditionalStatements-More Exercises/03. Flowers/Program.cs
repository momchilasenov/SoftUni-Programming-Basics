using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysantemumsBought = int.Parse(Console.ReadLine());
            int rosesBought = int.Parse(Console.ReadLine());
            int tulipsBought = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double chrysantemumPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;

            double discount = 0;
            double totalPrice = 0;

            if (season == "Spring" || season == "Summer")
            {
                chrysantemumPrice = 2.00;
                rosesPrice = 4.10;
                tulipsPrice = 2.50;
                if (rosesBought > 7 && season == "Spring")
                {
                    discount += 0.05;
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysantemumPrice = 3.75;
                rosesPrice = 4.50;
                tulipsPrice = 4.15;
                if (rosesBought >= 10 && season == "Winter")
                {
                    discount += 0.10;
                }
            }

            totalPrice = chrysantemumsBought * chrysantemumPrice + rosesBought * rosesPrice + tulipsBought * tulipsPrice;

            if (holiday == 'Y')
            {
                totalPrice += totalPrice * 0.15;
            }

            if (rosesBought + tulipsBought + chrysantemumsBought > 20)
            {
                totalPrice -= totalPrice * 0.20;
            }

            double finalPrice = totalPrice - (totalPrice*discount);

            Console.WriteLine($"{finalPrice+2:f2}");



        }
    }
}
