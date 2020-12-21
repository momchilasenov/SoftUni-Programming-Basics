using System;

namespace _05._Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int dividesBy2 = 0;
            int dividesBy3 = 0;
            int dividesBy4 = 0;

            for (int i = 1; i<=numbers; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());

                if (newNumber % 2 == 0)
                {
                    dividesBy2++;
                }
                if (newNumber % 3 == 0)
                {
                    dividesBy3++;
                }
                if (newNumber % 4 == 0)
                {
                    dividesBy4++;
                }
            }
            double percentage2 = dividesBy2*1.0 / numbers * 100;
            double percentage3 = dividesBy3*1.0 / numbers * 100;
            double percentage4 = dividesBy4*1.0 / numbers * 100;

            Console.WriteLine($"{percentage2:f2}%");
            Console.WriteLine($"{percentage3:f2}%");
            Console.WriteLine($"{percentage4:f2}%");

        }
    }
}
