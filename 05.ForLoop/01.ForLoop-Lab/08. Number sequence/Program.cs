using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue; 
            int maxNumber = int.MinValue; 
            
            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (maxNumber < inputNumber) 
                {
                    maxNumber = inputNumber;
                }

                if (minNumber > inputNumber) 
                {
                    minNumber = inputNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }

        
    }
}
