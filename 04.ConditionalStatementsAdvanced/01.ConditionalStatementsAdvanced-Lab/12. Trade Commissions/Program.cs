﻿using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double percentage = 0;

            if (city != "Sofia" && city != "Plovdiv" && city != "Varna" || sales < 0)
            {
                Console.WriteLine("error");
            }
            else if (sales >= 0 && sales <= 500)
            {
                if (city == "Sofia")
                {
                    percentage = 0.05;
                }
                else if (city == "Varna")
                {
                    percentage = 0.045;
                }
                else if (city == "Plovdiv")
                {
                    percentage = 0.055;
                }
                Console.WriteLine($"{sales * percentage:f2}");

            }
            else if (sales > 500 && sales <= 1000)
            {
                if (city == "Sofia")
                {
                    percentage = 0.07;
                }
                else if (city == "Varna")
                {
                    percentage = 0.075;
                }
                else if (city == "Plovdiv")
                {
                    percentage = 0.08;
                }
                Console.WriteLine($"{sales * percentage:f2}");

            }
            else if (sales > 1000 && sales <= 10000)
            {
                if (city == "Sofia")
                {
                    percentage = 0.08;
                }
                else if (city == "Varna")
                {
                    percentage = 0.10;
                }
                else if (city == "Plovdiv")
                {
                    percentage = 0.12;
                }
                Console.WriteLine($"{sales * percentage:f2}");

            }
            else if (sales > 10000)
            {
                if (city == "Sofia")
                {
                    percentage = 0.12;
                }
                else if (city == "Varna")
                {
                    percentage = 0.13;
                }
                else if (city == "Plovdiv")
                {
                    percentage = 0.145;
                }
                Console.WriteLine($"{sales * percentage:f2}");
            }


        }
    }
}
