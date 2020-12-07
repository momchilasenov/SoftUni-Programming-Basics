using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;
                if (maxNumber < inputNumber)
                {
                    maxNumber = inputNumber;
                }

            }
            int sumWithoutMax = sum - maxNumber;
            if (sumWithoutMax == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int difference = Math.Abs(maxNumber-sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }

        }
    }
}
