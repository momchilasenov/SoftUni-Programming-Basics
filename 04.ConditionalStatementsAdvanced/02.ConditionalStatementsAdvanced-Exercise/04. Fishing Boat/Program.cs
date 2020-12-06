using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. прочитаме бюджет сезон и брой рибари
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;
            //2. IF (сезон) - определяме цена 
            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }
            // 3. изчисляваме отстъпката според броя рибари
            if (fishermen <= 6)
            {
                discount = 0.9;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                discount = 0.85;
            }
            else
            {
                discount = 0.75;
            }

            //4. прибавяме отстъпката към цената за лодката
            double total = price * discount;
            //5. допълнителна отстъпка за четен брой рибари освен есен 
            bool additionalDiscount = fishermen % 2 == 0 && season != "Autumn";

            if (additionalDiscount)
            {
                total *= 0.95;
            }
            //6. output

            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {budget-total:f2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {total-budget:f2} leva.");
            }
        }
    }
}
