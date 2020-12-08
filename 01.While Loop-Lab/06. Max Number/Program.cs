using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double number = 0;
            double maxNumber = double.MinValue;

            while (input != "Stop")
            {
                number = double.Parse(input);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine(maxNumber);
        }
    }
}
