using System;
using System.Threading;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int floors = int.Parse(Console.ReadLine()); 
            int rooms = int.Parse(Console.ReadLine()); 

            int lastFloor = floors;

            bool flag = false;
            
            int countFloor = floors;

            
            for (int i = 1; i <= floors; floors--) 
            // или for (int i = floors; i>0; i--)
            {

                if (lastFloor == floors)
                {
                    for (int l = 0; l < rooms; l++)
                    {
                        Console.Write($"L{floors}{l} ");
                        flag = true;

                    }

                }
                if (flag)
                {
                    flag = false;
                    continue;
                }

                countFloor--;

                if (countFloor % 2 == 0)
                {
                    Console.WriteLine();
                    for (int j = 0; j < rooms; j++)
                    {

                        Console.Write($"O{floors}{j} ");
                    }
                }
                else
                {
                    Console.WriteLine();
                    for (int k = 0; k < rooms; k++)
                    {

                        Console.Write($"A{floors}{k} ");
                    }
                }
            }
        }
    }
}
