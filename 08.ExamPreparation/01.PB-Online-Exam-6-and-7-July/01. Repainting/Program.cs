using System;

namespace _01._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonNeeded = int.Parse(Console.ReadLine());
            int paintNeeded = int.Parse(Console.ReadLine());
            int letersOfMixer = int.Parse(Console.ReadLine());
            int hoursForWorkers = int.Parse(Console.ReadLine());

            double nylonPrice = (nylonNeeded + 2) * 1.50;
            double paintPrice = (paintNeeded + paintNeeded * 0.1) * 14.50;
            double mixerPrice = letersOfMixer * 5;

            double totalPrice = nylonPrice + paintPrice + mixerPrice + 0.40;

            double workersSalaryPerHour = totalPrice * 0.3;
            double workersSalary = workersSalaryPerHour * hoursForWorkers;

            double endTotal = totalPrice + workersSalary;

            Console.WriteLine($"Total expenses: {endTotal:f2} lv.");
        }
    }
}
