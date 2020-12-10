using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            bool flag = false;

            for (int i = 1; i <= n; i++) 
            {
                for (int j = 1; j <= i; j++)
                {
                    if (currentNumber > n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }

                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
