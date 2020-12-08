using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int input = 0;

            while (number >= sum) //100 > 0
            {
                input = int.Parse(Console.ReadLine()); //10
                sum += input; //=10

                if (number <= sum) //100=10
                {
                    Console.WriteLine(sum);
                    break;
                }

            }
        }
    }
}
