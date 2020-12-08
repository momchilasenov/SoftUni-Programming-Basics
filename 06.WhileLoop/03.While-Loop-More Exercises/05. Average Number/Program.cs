using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i<=n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                sum += input; 

            }
            double average = sum / n;
            Console.WriteLine($"{average:f2}");
        }
    }
}
