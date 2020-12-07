using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int leftSum = 0;
            //int rightSum = 0;   

            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    leftSum += number;
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    rightSum += number;
            //}

            //if (leftSum == rightSum)
            //{
            //    Console.WriteLine($"Yes, sum = {leftSum}");
            //}
            //else
            //{
            //    int difference = Math.Abs(leftSum - rightSum);
            //    Console.WriteLine($"No, diff = {difference}");
            //}


            //THE BETTER SOLUTION
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i <= n) //ако въведеш повече от n числа вече отиваш в дясната сума 
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
