using System;

namespace _08._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.въвеждаме първото число
            //2.въвеждаме второто число
            //3.изчисляваме тяхната сума(currentSum)
            //4.ако това е първият цикъл -sum = currentSum
            //5.ако това е втори, трети и т.н.цикъл
            //изчисляваме разлика - има ли разлика между sum на първия цикъл
            //и на currentSum
            //6.Ако има difference, sum придобива стойността на currentSum
            //7.Ако difference е > от 0 (от maxdifference)
            //то maxdifference приема стойността на difference
            //8.излизаме от цикъла
            //9.ако maxdifference = 0 значи няма разлики - принтираме value
            //10.Ако maxdifference != 0 - принтираме разликата(maxdifference)

            // Много е просто. Проверяваш първата двойка и записваш техните стойности
            // Срявняваш с втората двойка и ако има разлики записваш стойностите на втората двойка 
            // записваш разликата и следващият път проверяваш дали това е максималната разлика
            // накрая проверяваш дали имаш разлики или не (0) и принтираш 

            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double difference = 0;
            double maxDifference = 0;

            for (int i = 0; i<n; i++)
            {
                double numberOne = int.Parse(Console.ReadLine()); 
                double numberTwo = int.Parse(Console.ReadLine());
                double currentSum = numberOne + numberTwo;

                if (i == 0)
                {
                    sum = currentSum;
                }
                else 
                {
                    difference = Math.Abs(sum - currentSum);
                    sum = currentSum;
                }
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                }
            }
            if (maxDifference == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else 
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }



        }

        }
    }


