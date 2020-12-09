using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine()); 
            int magicNumber = int.Parse(Console.ReadLine()); 
            int combinationCounter = 0;

            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = startInterval; j <= endInterval; j++)
                {
                    combinationCounter++;
                    int sum = i + j;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNumber})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");

        }
    }
}
