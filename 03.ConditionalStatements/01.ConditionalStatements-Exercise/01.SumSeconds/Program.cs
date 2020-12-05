using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Първи начин за решение
            //1.Take input data
            int runnerOne = int.Parse(Console.ReadLine());
            int runnerTwo = int.Parse(Console.ReadLine());
            int runnerThree = int.Parse(Console.ReadLine());

            // 2. Find total run time 
            int totalTimeInSeconds = runnerOne + runnerTwo + runnerThree;

            // 3. Convert total run time in minutes and seconds 
            int timeInMinutes = totalTimeInSeconds / 60;
            int timeInSeconds = totalTimeInSeconds % 60;
            
            // 4. print + seconds check 
            if (timeInSeconds < 10)
            {
                Console.WriteLine($"{timeInMinutes}:0{timeInSeconds}");
            }
            else
            {
                Console.WriteLine($"{timeInMinutes}:{timeInSeconds}");
            }

            // Втори и по-умен начин за решение
            int totaltime = 0;
            totaltime += int.Parse(Console.ReadLine());
            totaltime += int.Parse(Console.ReadLine());
            totaltime += int.Parse(Console.ReadLine());

            int hours = totaltime / 60;
            int minutes = totaltime % 60;

            Console.WriteLine($"{hours}:{minutes:D2}");

        }
    }
}
