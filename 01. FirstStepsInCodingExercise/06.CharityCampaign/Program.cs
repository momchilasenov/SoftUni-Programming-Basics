using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double cakePrice = 45;
            double wafflePrice = 5.80;
            double pancakePrice = 3.20;

            int numberOfDays = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesTotal = cakes * cakePrice;
            double wafflesTotal = waffles * wafflePrice;
            double pancakesTotal = pancakes * pancakePrice;

            double totalSumPerDay = (cakesTotal + wafflesTotal + pancakesTotal)*bakers;
            double totalCampaignSum = totalSumPerDay * numberOfDays;
            double sumAfterExpenses = totalCampaignSum - (totalCampaignSum / 8);

            Console.WriteLine(sumAfterExpenses);



        }
    }
}
