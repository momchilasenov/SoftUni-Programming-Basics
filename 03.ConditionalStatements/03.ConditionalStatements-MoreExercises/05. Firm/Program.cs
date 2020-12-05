using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            double workingDays = days * 0.90;
            double overtimeHours = overtimeWorkers * days * 2;

            double totalHours = Math.Floor(workingDays * 8 + overtimeHours);
            
            if (totalHours >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{totalHours-hoursNeeded} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded - totalHours} hours needed.");
            }


        }
    }
}
