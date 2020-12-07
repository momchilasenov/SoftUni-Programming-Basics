using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //double sum = 0;

            //for (int i=1; i<=n; i++)
            //{
            //    int inputNumber = int.Parse(Console.ReadLine());
            //    sum += inputNumber;
            //}
            //Console.WriteLine(sum);


            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i<n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);







        }
    }
}
