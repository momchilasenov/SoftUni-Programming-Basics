using System;
using System.Text.RegularExpressions;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double price = 0;
            string sportType = "";

            if (groupType == "boys" || groupType == "girls")
            {
                if (season == "Winter")
                {
                    price = 9.60;
                    if (groupType == "boys")
                    {
                        sportType = "Judo";
                    }
                    else if (groupType == "girls")
                    {
                        sportType = "Gymnastics";
                    }
                }
                else if (season == "Spring")
                {
                    price = 7.20;
                    if (groupType == "boys")
                    {
                        sportType = "Tennis";
                    }
                    else if (groupType == "girls")
                    {
                        sportType = "Athletics";
                    }
                }
                else if (season == "Summer")
                {
                    price = 15;
                    if (groupType == "boys")
                    {
                        sportType = "Football";
                    }
                    else if (groupType == "girls")
                    {
                        sportType = "Volleyball";
                    }
                }
            }
            else if (groupType == "mixed")
            {
                if (season == "Winter")
                {
                    price = 10;
                    sportType = "Ski";
                }
                else if (season == "Spring")
                {
                    price = 9.50;
                    sportType = "Cycling";
                }
                else if (season == "Summer")
                {
                    price = 20;
                    sportType = "Swimming";
                }
            }

            double totalPrice = students * price * nights; 

            if (students >= 50)
            {
                totalPrice -= totalPrice * 0.5;
            }
            else if (students >= 20 && students < 50)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (students >= 10 && students <20)
            {
                totalPrice -= totalPrice * 0.05; 
            }

            Console.WriteLine($"{sportType} {totalPrice:f2} lv.");
        }
    }
}
