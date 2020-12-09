using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();

            while (destination != "End") 
            {
                double budget = double.Parse(Console.ReadLine()); 
                double moneySaved = 0;
                double totalMoneySaved = 0;

                while (totalMoneySaved < budget) 
                {
                    moneySaved = double.Parse(Console.ReadLine());
                    totalMoneySaved += moneySaved;
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }

        }
    }
}
