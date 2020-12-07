using System;

namespace _03._Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            for (double i = 1; i <= n; i++)
            {
                double inputNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += inputNumber;
                    if (evenMax < inputNumber)
                    {
                        evenMax = inputNumber;
                    }
                    if (evenMin > inputNumber)
                    {
                        evenMin = inputNumber;
                    }
                }
                else if (i % 2 == 1)
                {
                    oddSum += inputNumber;
                    if (oddMax < inputNumber)
                    {
                        oddMax = inputNumber;
                    }
                    if (oddMin > inputNumber)
                    {
                        oddMin = inputNumber;
                    }
                }

            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddSum == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenSum == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }

        }

    }
}

