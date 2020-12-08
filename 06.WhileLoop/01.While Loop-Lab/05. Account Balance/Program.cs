using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //double number = 0;
            //double sum = 0;

            //while (input != "NoMoreMoney")
            //{
            //    number = double.Parse(input);
            //    if (number < 0)
            //    {
            //        Console.WriteLine("Invalid operation!");
            //        Console.WriteLine($"Total: {sum:f2}");
            //        break;
            //    }

            //    Console.WriteLine($"Increase: {number:f2}");
            //    input = Console.ReadLine();
            //    sum += number;

            //}
            //if (input == "NoMoreMoney")
            //{
            //    Console.WriteLine($"Total: {sum:f2}");
            //}
            //---------------------------------------------

	    //Additional Solution

            string input = Console.ReadLine();
            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double deposit = double.Parse(input);
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {deposit:f2}");
                sum += deposit;
                input = Console.ReadLine();

            }
            Console.WriteLine($"Total: {sum:f2}");

        }
    }
}
