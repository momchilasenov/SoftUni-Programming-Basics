using System;

namespace _09._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            bool flag = false;
            int number1 = 0;
            int number2 = 0;

            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = startInterval; j <= endInterval; j++)
                {
                    counter++;
                    sum = i + j;
                    if (sum == magicNumber)
                    {
                        number1 = i;
                        number2 = j;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (sum == magicNumber)
            {
                Console.WriteLine($"Combination N:{counter} ({number1} + {number2} = {magicNumber})");

            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");

            }

        }
    }
}
